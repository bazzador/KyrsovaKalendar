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
                PrepareField(selectedEvent); 
            }
        }
        private void PrepareField(Event selectedEvent)
        {
            int x = 388 - 150;
            int y = 100 - 45;
            name_1.Location = new Point(150, 100); eventName.Location = new Point(592 - x, 45 + y); name_1.Visible = true; date_2.Visible = true; location_3.Visible = true; info_4.Visible = true; start_5.Visible = true; time_6.Visible = true; cost_7.Visible = true; limit_8.Visible = true;//388, 45
            eventName.Visible = true; eventName.Text = selectedEvent.name; eventDate1.Visible = true; eventDate1.Text = selectedEvent.startDate.ToString(); eventDate2.Visible = true; eventDate2.Text = selectedEvent.endDate.ToString(); eventLocation.Visible = true; eventLocation.Text = selectedEvent.location; eventInfo.Visible = true; eventInfo.Text = selectedEvent.info; eventTimeStart.Visible = true; eventTimeStart.Text = selectedEvent.timeStart.ToString(); eventTimeLength.Visible = true; eventTimeLength.Text = selectedEvent.timeLength.ToString(); eventCost.Visible = true; eventCost.Text = selectedEvent.cost.ToString(); eventLimit.Visible = true; eventLimit.Text = selectedEvent.limit; eventLink.Visible = true; eventLink.Text = selectedEvent.siteLink;
            switch (selectedEvent.type)
            {
                // author goal tools
                case "TematicEvenings":
                    date_2.Location = new Point(482 - x, 75 + y);
                    location_3.Location = new Point(474 - x, 105 + y);
                    info_4.Location = new Point(473 - x, 140 + y);
                    info_4.Text = "Основна інформація:";
                    start_5.Location = new Point(479 - x, 280 + y);
                    time_6.Location = new Point(423 - x, 310 + y);
                    cost_7.Location = new Point(492 - x, 340 + y);
                    limit_8.Location = new Point(511 - x, 370 + y);
                    eventDate1.Location = new Point(592 - x, 75 + y);
                    eventDate2.Location = new Point(742 - x, 75 + y);
                    eventInfo.Location = new Point(592 - x, 140 + y);
                    eventCost.Location = new Point(592 - x, 340 + y);
                    eventLimit.Location = new Point(592 - x, 370 + y);
                    eventTimeStart.Location = new Point(592 - x, 280 + y);
                    eventTimeLength.Location = new Point(592 - x, 310 + y);
                    eventLocation.Location = new Point(592 - x, 105 + y);
                    author_22.Visible = false;
                    eventAuthor.Visible = false;
                    goal_55.Visible = false;
                    eventGoal.Visible = false;
                    eventTools.Visible = false;
                    tools_55.Visible = false;

                    break;
                case "Questions": //author
                    Questions copyEvent = (Questions)selectedEvent;
                    author_22.Location = new Point(543-x, 75 + y);
                    date_2.Location = new Point(482 - x, 105 + y);
                    location_3.Location = new Point(474 - x, 135 + y);
                    info_4.Location = new Point(522 - x, 170 + y);
                    info_4.Text = "Запитання:";
                    start_5.Location = new Point(479 - x, 310 + y);
                    time_6.Location = new Point(423 - x, 340 + y);
                    cost_7.Location = new Point(492 - x, 370 + y);
                    limit_8.Location = new Point(511 - x, 400 + y);
                    eventAuthor.Location = new Point(592 - x, 75 + y);
                    eventDate1.Location = new Point(592 - x, 105 + y);
                    eventDate2.Location = new Point(742 - x, 105 + y);
                    eventInfo.Location = new Point(592 - x, 170 + y);
                    eventCost.Location = new Point(592 - x, 370 + y);
                    eventLimit.Location = new Point(592 - x, 400 + y);
                    eventTimeStart.Location = new Point(592 - x, 310 + y);
                    eventTimeLength.Location = new Point(592 - x, 340 + y);
                    eventLocation.Location = new Point(592 - x, 135 + y);
                    eventAuthor.Text = copyEvent.author;
                    author_22.Visible = true;
                    eventAuthor.Visible = true;
                    goal_55.Visible = false;
                    eventGoal.Visible = false;
                    eventTools.Visible = false;
                    tools_55.Visible = false;
                    break;
                case "Meeting":
                    date_2.Location = new Point(482 - x, 75 + y);
                    location_3.Location = new Point(474 - x, 105 + y);
                    info_4.Location = new Point(514 - x, 140 + y);
                    info_4.Text = "Гості заходу:";
                    start_5.Location = new Point(479 - x, 280 + y);
                    time_6.Location = new Point(423 - x, 310 + y);
                    cost_7.Location = new Point(492 - x, 340 + y);
                    limit_8.Location = new Point(511 - x, 370 + y);
                    eventDate1.Location = new Point(592 - x, 75 + y);
                    eventDate2.Location = new Point(742 - x, 75 + y);
                    eventInfo.Location = new Point(592 - x, 140 + y);
                    eventCost.Location = new Point(592 - x, 340 + y);
                    eventLimit.Location = new Point(592 - x, 370 + y);
                    eventTimeStart.Location = new Point(592 - x, 280 + y);
                    eventTimeLength.Location = new Point(592 - x, 310 + y);
                    eventLocation.Location = new Point(592 - x, 105 + y);
                    author_22.Visible = false;
                    eventAuthor.Visible = false;
                    goal_55.Visible = false;
                    eventGoal.Visible = false;
                    eventTools.Visible = false;
                    tools_55.Visible = false;
                    break;
                case "Standup":
                    date_2.Location = new Point(482 - x, 75 + y);
                    location_3.Location = new Point(474 - x, 105 + y);
                    info_4.Location = new Point(478 - x, 140 + y);
                    info_4.Text = "Програма та ведучі:";
                    start_5.Location = new Point(479 - x, 280 + y);
                    time_6.Location = new Point(423 - x, 310 + y);
                    cost_7.Location = new Point(492 - x, 340 + y);
                    limit_8.Location = new Point(511 - x, 370 + y);
                    eventDate1.Location = new Point(592 - x, 75 + y);
                    eventDate2.Location = new Point(742 - x, 75 + y);
                    eventInfo.Location = new Point(592 - x, 140 + y);
                    eventCost.Location = new Point(592 - x, 340 + y);
                    eventLimit.Location = new Point(592 - x, 370 + y);
                    eventTimeStart.Location = new Point(592 - x, 280 + y);
                    eventTimeLength.Location = new Point(592 - x, 310 + y);
                    eventLocation.Location = new Point(592 - x, 105 + y);
                    author_22.Visible = false;
                    eventAuthor.Visible = false;
                    goal_55.Visible = false;
                    eventGoal.Visible = false;
                    eventTools.Visible = false;
                    tools_55.Visible = false;
                    break;
                case "Entertainment": //goal tools author
                    Entertainment copyEvent1 = (Entertainment)selectedEvent;
                    author_22.Location = new Point(543 - x, 75 + y);
                    date_2.Location = new Point(482 - x, 105 + y);
                    location_3.Location = new Point(474 - x, 135 + y);
                    goal_55.Location = new Point(550 - x, 170 + y);
                    tools_55.Location = new Point(514 - x, 230 + y);
                    info_4.Text = "Програма та ведучі:";
                    info_4.Location = new Point(478 - x, 290 + y);
                    start_5.Location = new Point(479 - x, 420 + y);
                    time_6.Location = new Point(423 - x, 450 + y);
                    cost_7.Location = new Point(492 - x, 480 + y);
                    limit_8.Location = new Point(511 - x, 510 + y);
                    eventAuthor.Location = new Point(592 - x, 75 + y);
                    eventDate1.Location = new Point(593 - x, 105 + y);
                    eventDate2.Location = new Point(742 - x, 105 + y);
                    eventLocation.Location = new Point(593 - x, 135 + y);
                    eventGoal.Location = new Point(593 - x, 170 + y);
                    eventTools.Location = new Point(593 - x, 230 + y);
                    eventInfo.Location = new Point(592 - x, 290 + y);
                    eventTimeStart.Location = new Point(592 - x, 420 + y);
                    eventTimeLength.Location = new Point(592 - x, 450 + y);
                    eventCost.Location = new Point(592 - x, 480 + y);
                    eventLimit.Location = new Point(592 - x, 510 + y);
                    eventAuthor.Text = copyEvent1.author;
                    eventGoal.Text = copyEvent1.goal;
                    eventTools.Text = copyEvent1.tools;
                    eventAuthor.Visible = true;
                    author_22.Visible = true;
                    goal_55.Visible = true;
                    eventGoal.Visible = true;
                    eventTools.Visible = true;
                    tools_55.Visible = true;
                    break;
            }
        }

        private void ChangeEvent_Click(object sender, EventArgs e)
        {
            if (EventComboBox.SelectedIndex >=0)
            {
                CreateEvent createEvent = new CreateEvent(this, EventComboBox.SelectedIndex);
                UpdateEvents();
                createEvent.ShowDialog();
            }
            else MessageBox.Show("Оберіть подію для зміни!");
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
