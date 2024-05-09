using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KyrsovaKalendar.CreateEvent;

namespace KyrsovaKalendar
{
    public partial class CreateEvent : Form
    {
        DayInfo store;
        int numberOfSelectedSubject;
        //private IEventFactory eventFactory;
        public CreateEvent(DayInfo store)
        {
            InitializeComponent();
            this.store = store;
        }
        public CreateEvent(DayInfo store, Event1 eventToChange)
        {
            InitializeComponent();
            if (eventToChange != null)
            {
                eventName.Text = eventToChange.name;
                eventDate1.Value = eventToChange.startDate;
                eventDate2.Value = eventToChange.endDate;
                eventInfo.Text = eventToChange.info;
                eventTimeStart.Value = eventToChange.timeStart;
                eventTimeLength.Value = eventToChange.timeLength;
                eventCost.Text = eventToChange.cost.ToString();
                eventLimit.Text = eventToChange.limit;
                this.store = store;
            }
        }
        public class Event1
        {
            public string name;
            public DateTime startDate;
            public DateTime endDate;
            public string info;
            public DateTime timeStart;
            public DateTime timeLength;
            public int cost;
            public string limit;

            public Event1(string name, DateTime startDate, DateTime endDate, string info, DateTime timeStart, DateTime timeLength, int cost, string limits)
            {
                this.name = name;
                this.startDate = startDate;
                this.endDate = endDate;
                this.info = info;
                this.timeStart = timeStart;
                this.timeLength = timeLength;
                this.cost = cost;
                this.limit = limits;
            }
        }
        abstract public class Event
        {
            public string name;
            public DateTime startDate;
            public DateTime endDate;
            public string location;
            public string info;
            public DateTime timeStart;
            public DateTime timeLength;
            public int cost;
            public string siteLink;
            public string limit;

            protected Event(string name, DateTime startDate, DateTime endDate, 
                string location, string info, DateTime timeStart, DateTime timeLength, 
                int cost, string limit, string siteLink)
            {
                this.name = name;
                this.startDate = startDate;
                this.endDate = endDate;
                this.location = location;
                this.info = info;
                this.timeStart = timeStart;
                this.timeLength = timeLength;
                this.cost = cost;
                this.limit = limit;
                this.siteLink = siteLink;

            }
        }
        public class TematicEvenings : Event
        {
            public string author { get; set; }

            public TematicEvenings(string name, string author, DateTime startDate,
                DateTime endDate, string location, string info, DateTime timeStart,
                DateTime timeLength, int cost, string limit, string siteLink)
                : base(name, startDate, endDate, location, info, timeStart, timeLength, cost, limit, siteLink)
            {
                this.author = author;
            }
        }
        public class Questions : Event
        {
            public string questions { get; set; }

            public Questions(string name, DateTime startDate,
                DateTime endDate, string location, string info, DateTime timeStart,
                DateTime timeLength, int cost, string siteLink, string limit)
                : base(name, startDate, endDate, location, info, timeStart, timeLength, cost, limit, siteLink)
            {
                this.questions = questions;
            }
        }
        public class Meeting : Event
        {
            public Meeting(string name, DateTime startDate,
                DateTime endDate, string location, string info, DateTime timeStart,
                DateTime timeLength, int cost, string limit, string siteLink)
                : base(name, startDate, endDate, location, info, timeStart, timeLength, cost, limit, siteLink)
            {
            }
        }
        public class Standup : Event
        {
            public Standup(string name, DateTime startDate,
                DateTime endDate, string location, string info, DateTime timeStart,
                DateTime timeLength, int cost, string limit, string siteLink)
                : base(name, startDate, endDate, location, info, timeStart, timeLength, cost, limit, siteLink)
            {
            }
        }
        public class Entertainment : Event
        {
            public string goal { get; set; }
            public string tools { get; set; }
            public string program { get; set; }
            public string authors { get; set; }

            public Entertainment(string name, DateTime startDate,
                DateTime endDate, string location, string goal, string tools, string info, DateTime timeStart,
                DateTime timeLength, int cost, string limit, string siteLink)
                : base(name, startDate, endDate, location, info, timeStart, timeLength, cost, limit, siteLink)
            {
                this.goal = goal;
                this.tools = tools;
                this.program = info;
                this.authors = authors;
            }
        }

        public void changeEvent(Event1 selectedEvent)
        {
            if (selectedEvent != null)
            {
                eventName.Text = selectedEvent.name;
                eventDate1.Value = selectedEvent.startDate;
                eventDate2.Value = selectedEvent.endDate;
                eventInfo.Text = selectedEvent.info;
                eventTimeStart.Value = selectedEvent.timeStart;
                eventTimeLength.Value = selectedEvent.timeLength;
                eventCost.Text = selectedEvent.cost.ToString();
                eventLimit.Text = selectedEvent.limit;
            }
        }
        public void saveEvent_Click(object sender, EventArgs e)
        {
            //Event1 newEvent = new Event1(eventName.Text, eventDate1.Value, eventDate2.Value, eventInfo.Text, eventTimeStart.Value, eventTimeLength.Value, int.Parse(eventCost.Text), eventLimit.Text);
            //store.events.Add(newEvent);
            switch (numberOfSelectedSubject)
            {
                case 1:
                    TematicEvenings newEvent1 = new TematicEvenings(eventName.Text, eventAuthor.Text, eventDate1.Value, eventDate2.Value, eventLocation.Text, 
                        eventInfo.Text, eventTimeStart.Value, eventTimeLength.Value, 
                        int.Parse(eventCost.Text), eventLimit.Text, eventLink.Text);
                    break;
                case 2:
                    Questions newEvent2 = new Questions(eventName.Text, eventDate1.Value, eventDate2.Value, eventLocation.Text, 
                        eventInfo.Text, eventTimeStart.Value, eventTimeLength.Value, int.Parse(eventCost.Text), 
                        eventLimit.Text, eventLink.Text);
                    break;
                case 3:
                    Meeting newEvent3 = new Meeting(eventName.Text, eventDate1.Value, eventDate2.Value, eventLocation.Text, eventInfo.Text,
                        eventTimeStart.Value, eventTimeLength.Value, int.Parse(eventCost.Text), eventLimit.Text, eventLink.Text);
                    break;
                case 4:
                    Standup newEvent4 = new Standup(eventName.Text, eventDate1.Value, eventDate2.Value, eventLocation.Text,
                        eventInfo.Text, eventTimeStart.Value, eventTimeLength.Value,
                        int.Parse(eventCost.Text), eventLimit.Text, eventLink.Text);
                    break;
                case 5:
                    Entertainment newEvent5 = new Entertainment(eventName.Text, eventDate1.Value, eventDate2.Value, eventLocation.Text,
                         eventGoal.Text, eventTools.Text, eventInfo.Text, eventTimeStart.Value, eventTimeLength.Value, int.Parse(eventCost.Text), eventLimit.Text, eventLink.Text);
                    break;
            }
        }

        private void exitCreateEvent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateEvent_FormClosed(object sender, FormClosedEventArgs e)
        {
            store.UpdateEvents();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSubject = comboBox1.SelectedItem.ToString();
            numberOfSelectedSubject = (int)selectedSubject[0] - 48;
            switch (numberOfSelectedSubject)
            {
                case 1:
                    //name_1.Location = new System.Drawing.Point(388, 45);
                    date_2.Location = new Point(482, 75);
                    location_3.Location = new Point(474, 105);
                    info_4.Location = new Point(473, 140);
                    info_4.Text = "Основна інформація:";
                    start_5.Location = new Point(479, 280);
                    time_6.Location = new Point(423, 310);
                    cost_7.Location = new Point(492, 340);
                    limit_8.Location = new Point(511, 370);
                    //eventName.Location = new Point(592, 45);
                    eventDate1.Location = new Point(592, 75);
                    eventDate2.Location = new Point(742, 75);
                    eventInfo.Location = new Point(592, 140);
                    eventCost.Location = new Point(592, 340);
                    eventLimit.Location = new Point(592, 370);
                    eventTimeStart.Location = new Point(592, 280);
                    eventTimeLength.Location = new Point(592, 310);
                    eventLocation.Location = new Point(592, 105);
                    author_22.Visible = false;
                    eventAuthor.Visible = false;
                    goal_55.Visible = false;
                    eventGoal.Visible = false;
                    eventTools.Visible = false;
                    tools_55.Visible = false;
                    
                    break;
                case 2:
                    author_22.Visible = true;
                    eventAuthor.Visible = true;
                    //name_1.Location = new System.Drawing.Point(388, 45);
                    author_22.Location = new Point(543, 75);
                    date_2.Location = new Point(482, 75 + 30);
                    location_3.Location = new Point(474, 105 + 30);
                    info_4.Location = new Point(522, 140 + 35);
                    info_4.Text = "Запитання:";
                    start_5.Location = new Point(479, 280 + 30);
                    time_6.Location = new Point(423, 310 + 30);
                    cost_7.Location = new Point(492, 340 + 30);
                    limit_8.Location = new Point(511, 370 + 30);
                    //eventName.Location = new System.Drawing.Point(592, 45 + 30);
                    eventDate1.Location = new Point(592, 75 + 30);
                    eventDate2.Location = new Point(742, 75 + 30);
                    eventInfo.Location = new Point(592, 140 + 30);
                    eventCost.Location = new Point(592, 340 + 30);
                    eventLimit.Location = new Point(592, 370 + 30);
                    eventTimeStart.Location = new Point(592, 280 + 30);
                    eventTimeLength.Location = new Point(592, 310 + 30);
                    eventLocation.Location = new Point(592, 105 + 30);
                    goal_55.Visible = false;
                    eventGoal.Visible = false;
                    eventTools.Visible = false;
                    tools_55.Visible = false;
                    break;
                case 3:
                    //name_1.Location = new System.Drawing.Point(388, 45);
                    date_2.Location = new Point(482, 75);
                    location_3.Location = new Point(474, 105);
                    info_4.Location = new Point(514, 140);
                    info_4.Text = "Гості заходу:";
                    start_5.Location = new Point(479, 280);
                    time_6.Location = new Point(423, 310);
                    cost_7.Location = new Point(492, 340);
                    limit_8.Location = new Point(511, 370);
                    //eventName.Location = new Point(592, 45);
                    eventDate1.Location = new Point(592, 75);
                    eventDate2.Location = new Point(742, 75);
                    eventInfo.Location = new Point(592, 140);
                    eventCost.Location = new Point(592, 340);
                    eventLimit.Location = new Point(592, 370);
                    eventTimeStart.Location = new Point(592, 280);
                    eventTimeLength.Location = new Point(592, 310);
                    eventLocation.Location = new Point(592, 105);
                    author_22.Visible = false;
                    eventAuthor.Visible = false;
                    goal_55.Visible = false;
                    eventGoal.Visible = false;
                    eventTools.Visible = false;
                    tools_55.Visible = false;
                    break;
                case 4:
                    //name_1.Location = new System.Drawing.Point(388, 45);
                    date_2.Location = new Point(482, 75);
                    location_3.Location = new Point(474, 105);
                    info_4.Location = new Point(478, 140);
                    info_4.Text = "Програма та ведучі:";
                    start_5.Location = new Point(479, 280);
                    time_6.Location = new Point(423, 310);
                    cost_7.Location = new Point(492, 340);
                    limit_8.Location = new Point(511, 370);
                    //eventName.Location = new Point(592, 45);
                    eventDate1.Location = new Point(592, 75);
                    eventDate2.Location = new Point(742, 75);
                    eventInfo.Location = new Point(592, 140);
                    eventCost.Location = new Point(592, 340);
                    eventLimit.Location = new Point(592, 370);
                    eventTimeStart.Location = new Point(592, 280);
                    eventTimeLength.Location = new Point(592, 310);
                    eventLocation.Location = new Point(592, 105);
                    author_22.Visible = false;
                    eventAuthor.Visible = false;
                    goal_55.Visible = false;
                    eventGoal.Visible = false;
                    eventTools.Visible = false;
                    tools_55.Visible = false;
                    break;
                case 5:
                    goal_55.Visible = true;
                    eventGoal.Visible = true;
                    eventTools.Visible = true;
                    tools_55.Visible = true;
                    name_1.Location = new Point(388, 45);
                    date_2.Location = new Point(482, 105-30);
                    location_3.Location = new Point(474, 135-30);
                    info_4.Location = new Point(478, 300 - 30);
                    start_5.Location = new Point(479, 440 - 30);
                    time_6.Location = new Point(423, 470 - 30);
                    cost_7.Location = new Point(492, 500 - 30);
                    limit_8.Location = new Point(511, 530 - 30);
                    goal_55.Location = new Point(550, 170 - 30);
                    eventGoal.Location = new Point(593, 170 - 30);
                    eventTools.Location = new Point(593, 235 - 30);
                    tools_55.Location = new Point(514, 235 - 30);
                    eventName.Location = new Point(592, 45);
                    eventDate1.Location = new Point(593, 105-30);
                    eventDate2.Location = new Point(742, 105-30);
                    eventInfo.Location = new Point(592, 300 - 30);
                    eventCost.Location = new Point(592, 500 - 30);
                    eventLimit.Location = new Point(592, 530 - 30);
                    eventTimeStart.Location = new Point(592, 440 - 30);
                    eventTimeLength.Location = new Point(592, 470 - 30);
                    eventLocation.Location = new Point(593, 135 - 30);
                    eventAuthor.Visible = false;
                    author_22.Visible = false;
                    break;
            }
        }
    }
}
//C:\Users\Ivanchik\source\repos\KyrsovaKalendar\events