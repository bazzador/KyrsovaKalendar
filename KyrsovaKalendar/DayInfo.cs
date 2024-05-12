using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KyrsovaKalendar.CreateEvent;

namespace KyrsovaKalendar
{
    public partial class DayInfo : Form
    {
        public string filePath = "C:\\Users\\Ivanchik\\source\\repos\\KyrsovaKalendar\\events\\";
        public string folderPath;
        public List<Event> events;
        private int currentItem = 0;
        public int userDay { get; set; }
        public int userMonth {  get; set; }
        public int userYear { get; set; }
        public int indexOfEvent { get; set; }   
        public DayInfo(int userDay, int userMonth, int userYear, int indexOfEvent=-1)
        {
            InitializeComponent();
            this.userDay = userDay;
            this.userMonth = userMonth;
            this.userYear = userYear;
            events = new List<Event>();
            this.indexOfEvent = indexOfEvent;
            //EventComboBox.DataSource = events.Select(ev => ev.name).ToList();
        }
        private void createEventButton_Click(object sender, EventArgs e)
        {
            CreateEvent createEvent = new CreateEvent(this);
            createEvent.ShowDialog();
        }
        public void UpdateEvents()
        {
            EventComboBox.DataSource = null; // Спочатку встановлюємо DataSource на null
            EventComboBox.DataSource = events.Select(ev => ev.name).ToList(); // Передаємо новий список імен подій як DataSource
            //EventComboBox.Items.Add(events[currentItem]);
            currentItem++;
            //UpdateEventComboBox();
        }

        private void EventComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = EventComboBox.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < events.Count)
            {
                Event selectedEvent = events[selectedIndex];
                string typeName = events[selectedIndex].type;
                PrepareField(typeName); 
            }
        }
        private void PrepareField(string type)
        {
            name_1.Location = new Point(150, 100); //388, 45
            int x = 388 - 150;
            int y = 100 - 45;
            switch (type)
            {

                case "TematicEvenings":
                    date_2.Location = new Point(482-x, 75+y);
                    location_3.Location = new Point(474-x, 105 + y);
                    info_4.Location = new Point(473-x, 140 + y);
                    info_4.Text = "Основна інформація:";
                    start_5.Location = new Point(479-x, 280 + y);
                    time_6.Location = new Point(423-x, 310 + y);
                    cost_7.Location = new Point(492-x, 340 + y);
                    limit_8.Location = new Point(511-x, 370 + y);
                    eventName.Location = new Point(592-x, 45 + y);
                    eventDate1.Location = new Point(592-x, 75 + y);
                    eventDate2.Location = new Point(742-x, 75 + y);
                    eventInfo.Location = new Point(592-x, 140 + y);
                    eventCost.Location = new Point(592-x, 340 + y);
                    eventLimit.Location = new Point(592-x, 370 + y);
                    eventTimeStart.Location = new Point(592-x, 280 + y);
                    eventTimeLength.Location = new Point(592-x, 310 + y);
                    eventLocation.Location = new Point(592-x, 105 + y);
                    author_22.Visible = false;
                    eventAuthor.Visible = false;
                    goal_55.Visible = false;
                    eventGoal.Visible = false;
                    eventTools.Visible = false;
                    tools_55.Visible = false;

                    break;
                case "Questions":
                    author_22.Visible = true;
                    eventAuthor.Visible = true;
                    author_22.Location = new Point(543 - x, 75 + y);
                    date_2.Location = new Point(482 - x, 75 + 30 + y);
                    location_3.Location = new Point(474 - x, 105 + 30 + y);
                    info_4.Location = new Point(522 - x, 140 + 35 + y);
                    info_4.Text = "Запитання:";
                    start_5.Location = new Point(479 - x, 280 + 30 + y);
                    time_6.Location = new Point(423 - x, 310 + 30 + y);
                    cost_7.Location = new Point(492 - x, 340 + 30 + y);
                    limit_8.Location = new Point(511 - x, 370 + 30 + y);
                    eventName.Location = new Point(592 - x, 45 + 30 + y);
                    eventDate1.Location = new Point(592 - x, 75 + 30 + y);
                    eventDate2.Location = new Point(742 - x, 75 + 30 + y);
                    eventInfo.Location = new Point(592 - x, 140 + 30 + y);
                    eventCost.Location = new Point(592 - x, 340 + 30 + y);
                    eventLimit.Location = new Point(592 - x, 370 + 30 + y);
                    eventTimeStart.Location = new Point(592 - x, 280 + 30 + y);
                    eventTimeLength.Location = new Point(592 - x, 310 + 30 + y);
                    eventLocation.Location = new Point(592 - x, 105 + 30 + y);
                    goal_55.Visible = false;
                    eventGoal.Visible = false;
                    eventTools.Visible = false;
                    tools_55.Visible = false;
                    break;
                    case "Meeting":
                    date_2.Location = new Point(482, 75);
                    location_3.Location = new Point(474, 105);
                    info_4.Location = new Point(514, 140);
                    info_4.Text = "Гості заходу:";
                    start_5.Location = new Point(479, 280);
                    time_6.Location = new Point(423, 310);
                    cost_7.Location = new Point(492, 340);
                    limit_8.Location = new Point(511, 370);
                    eventName.Location = new Point(592, 45);
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
                case "Standup":
                    date_2.Location = new Point(482, 75);
                    location_3.Location = new Point(474, 105);
                    info_4.Location = new Point(478, 140);
                    info_4.Text = "Програма та ведучі:";
                    start_5.Location = new Point(479, 280);
                    time_6.Location = new Point(423, 310);
                    cost_7.Location = new Point(492, 340);
                    limit_8.Location = new Point(511, 370);
                    eventName.Location = new Point(592, 45);
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
                case "Entertainment":
                    goal_55.Visible = true;
                    eventGoal.Visible = true;
                    eventTools.Visible = true;
                    tools_55.Visible = true;
                    date_2.Location = new Point(482, 75);
                    location_3.Location = new Point(474, 105);
                    info_4.Location = new Point(478, 270);
                    start_5.Location = new Point(479, 41);
                    time_6.Location = new Point(423, 44);
                    cost_7.Location = new Point(492, 470);
                    limit_8.Location = new Point(511, 500);
                    goal_55.Location = new Point(550, 140);
                    eventGoal.Location = new Point(593, 140);
                    eventTools.Location = new Point(593, 205);
                    tools_55.Location = new Point(514, 205);
                    eventName.Location = new Point(592, 45);
                    eventDate1.Location = new Point(593, 75);
                    eventDate2.Location = new Point(742, 75);
                    eventInfo.Location = new Point(592, 270);
                    eventCost.Location = new Point(592, 470);
                    eventLimit.Location = new Point(592, 500);
                    eventTimeStart.Location = new Point(592, 410);
                    eventTimeLength.Location = new Point(592, 440);
                    eventLocation.Location = new Point(593, 105);
                    eventAuthor.Visible = false;
                    author_22.Visible = false;
                    break;
            }
        }

        private void ChangeEvent_Click(object sender, EventArgs e)
        {
            Event selectedEvent = events[EventComboBox.SelectedIndex];
            events.Remove(selectedEvent);
            selectedEvent.CollectEventData(selectedEvent);
            CreateEvent createEvent = new CreateEvent(this, selectedEvent);
            createEvent.ShowDialog();  
        }

        private void DayInfo_Load(object sender, EventArgs e)
        {
            folderPath = Path.Combine(filePath, userDay + "_" + userMonth + "_" + userYear);
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            else if(!(Directory.GetFiles(folderPath).Length == 0 && Directory.GetDirectories(folderPath).Length == 0))
            {
                string[] eventFiles = Directory.GetFiles(folderPath);
                foreach(string files in eventFiles)
                {
                    string[] lines = File.ReadAllLines(files);
                    string type = lines[0].Substring("Type: ".Length);
                    switch (type)
                    {
                        case "TematicEvenings":
                            TematicEvenings tematicEvenings = new TematicEvenings();
                            events.Add(tematicEvenings.ReadDataFromFile(lines));
                            break;
                        case "Questions":
                            Questions questions = new Questions();
                            events.Add(questions.ReadDataFromFile(lines));
                            break;
                        case "Meeting":
                            Meeting meeting = new Meeting();
                            events.Add(meeting.ReadDataFromFile(lines));
                            break;
                        case "Standup":
                            Standup standup = new Standup();
                            events.Add(standup.ReadDataFromFile(lines));
                            break;
                        case "Entertainment":
                            Entertainment entertainment = new Entertainment();
                            events.Add(entertainment.ReadDataFromFile(lines));
                            break;
                    }
                }
                UpdateEvents();
            }
           if(indexOfEvent!=-1) EventComboBox.SelectedIndex = indexOfEvent;
        }
    }
}
