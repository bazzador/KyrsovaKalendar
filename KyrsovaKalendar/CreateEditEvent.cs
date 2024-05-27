using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace KyrsovaKalendar
{
    public partial class CreateEditEvent : Form
    {
        DayInfo dayInfo;
        int indexEventToChange;
        int numberOfSelectedSubject;
        public CreateEditEvent(DayInfo dayInfo)
        {
            InitializeComponent();
            this.dayInfo = dayInfo;
            this.indexEventToChange = -1;
        }
        public CreateEditEvent(DayInfo dayInfo, int indexEventToChange)
        {
            InitializeComponent();
            this.dayInfo = dayInfo;
            this.indexEventToChange = indexEventToChange;
        }
        public interface IDataManagement
        {
            void WriteDataToFile(string fileName);
            Event ReadDataFromFile(string[] fileName);
        }
        abstract public class Event : IDataManagement
        {
            public string type { get; set; }    
            public Event copyEvent { get; protected set; }
            public string name { get; set; }
            public DateTime startDate { get; set; } 
            public DateTime endDate { get; set; }
            public string location { get; set; }
            public string info { get; set; }
            public DateTime timeStart { get; set; }
            public DateTime timeLength { get; set; }
            public int cost { get; set; }
            public string siteLink { get; set; }
            public string limit { get; set; }
            protected Event(string type, string name, DateTime startDate, DateTime endDate, 
                string location, string info, DateTime timeStart, DateTime timeLength, 
                int cost, string limit, string siteLink)
            {
                this.type = type;
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
            protected Event()
            {

            }
            abstract public Event ReadDataFromFile(string[] fileName);
            abstract public void WriteDataToFile(string directory);
            protected string ExtractData(string[] fileLines, string key)
            {
                StringBuilder sb = new StringBuilder();
                bool recording = false;

                foreach (string line in fileLines)
                {
                    if (line.StartsWith(key))
                    {
                        if (recording) break;
                        sb.Append(line.Substring(key.Length));
                        recording = true;
                    }
                    else if (recording)
                    {
                        if (line.Contains(": ") && !line.StartsWith(" ")) break; // Stop if a new key is detected
                        sb.Append(Environment.NewLine).Append(line);
                    }
                }
                return sb.ToString().Trim();
            }
        }
        public class TematicEvenings : Event
        {
            public TematicEvenings(string type, string name, DateTime startDate,
                DateTime endDate, string location, string info, DateTime timeStart,
                DateTime timeLength, int cost, string limit, string siteLink)
                : base(type, name, startDate, endDate, location, info, timeStart, timeLength, cost, limit, siteLink)
            {
                this.type = "TematicEvenings";
            }
            public TematicEvenings() { }
            public override Event ReadDataFromFile(string[] fileLines)
            {
                string type = ExtractData(fileLines, "Type: ");
                string name = ExtractData(fileLines, "Name: ");
                DateTime startDate = DateTime.Parse(ExtractData(fileLines, "Start Date: "));
                DateTime endDate = DateTime.Parse(ExtractData(fileLines, "End Date: "));
                string location = ExtractData(fileLines, "Location: ");
                string info = ExtractData(fileLines, "Info: ");
                DateTime timeStart = DateTime.Parse(ExtractData(fileLines, "Time Start: "));
                DateTime timeLength = DateTime.Parse(ExtractData(fileLines, "Time Length: "));
                int cost = int.Parse(ExtractData(fileLines, "Cost: "));
                string limit = ExtractData(fileLines, "Limit: ");
                string siteLink = ExtractData(fileLines, "Site Link: ");

                return new TematicEvenings(type, name, startDate, endDate, location, info, timeStart, timeLength, cost, limit, siteLink);
            }
            public override void WriteDataToFile(string directory)
            {
                string fileName = $"{name}.txt";
                string filePath = Path.Combine(directory, fileName);
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"Type: {type}");
                    writer.WriteLine($"Name: {name}");
                    writer.WriteLine($"Start Date: {startDate}");
                    writer.WriteLine($"End Date: {endDate}");
                    writer.WriteLine($"Location: {location}");
                    writer.WriteLine($"Info: {info}");
                    writer.WriteLine($"Time Start: {timeStart}");
                    writer.WriteLine($"Time Length: {timeLength}");
                    writer.WriteLine($"Cost: {cost}");
                    writer.WriteLine($"Limit: {limit}");
                    writer.WriteLine($"Site Link: {siteLink}");
                }
            }
        }
        public class Questions : Event
        {
            public string author {  get; set; }
            public Questions(string type, string name, string author, DateTime startDate,
                DateTime endDate, string location, string info, DateTime timeStart,
                DateTime timeLength, int cost, string siteLink, string limit)
                : base(type, name, startDate, endDate, location, info, timeStart, timeLength, cost, limit, siteLink)
            {
                this.type = "Questions";
                this.author= author;
            }
            public Questions() { }
            public override Event ReadDataFromFile(string[] fileLines)
            {
                string type = ExtractData(fileLines, "Type: ");
                string name = ExtractData(fileLines, "Name: ");
                string author = ExtractData(fileLines, "Author: ");
                DateTime startDate = DateTime.Parse(ExtractData(fileLines, "Start Date: "));
                DateTime endDate = DateTime.Parse(ExtractData(fileLines, "End Date: "));
                string location = ExtractData(fileLines, "Location: ");
                string info = ExtractData(fileLines, "Info: ");
                DateTime timeStart = DateTime.Parse(ExtractData(fileLines, "Time Start: "));
                DateTime timeLength = DateTime.Parse(ExtractData(fileLines, "Time Length: "));
                int cost = int.Parse(ExtractData(fileLines, "Cost: "));
                string limit = ExtractData(fileLines, "Limit: ");
                string siteLink = ExtractData(fileLines, "Site Link: ");
                return new Questions(type, name, author, startDate, endDate, location, info, timeStart, timeLength, cost, siteLink, limit);
            }

            public override void WriteDataToFile(string directory)
            {
                string fileName = $"{name}.txt";
                string filePath = Path.Combine(directory, fileName);
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"Type: {type}");
                    writer.WriteLine($"Name: {name}");
                    writer.WriteLine($"Author: {author}");
                    writer.WriteLine($"Start Date: {startDate}");
                    writer.WriteLine($"End Date: {endDate}");
                    writer.WriteLine($"Location: {location}");
                    writer.WriteLine($"Info: {info}");
                    writer.WriteLine($"Time Start: {timeStart}");
                    writer.WriteLine($"Time Length: {timeLength}");
                    writer.WriteLine($"Cost: {cost}");
                    writer.WriteLine($"Limit: {limit}");
                    writer.WriteLine($"Site Link: {siteLink}");
                }
            }
        }
        public class Meeting : Event
        {
            public Meeting(string type, string name, DateTime startDate,
                DateTime endDate, string location, string info, DateTime timeStart,
                DateTime timeLength, int cost, string limit, string siteLink)
                : base(type, name, startDate, endDate, location, info, timeStart, timeLength, cost, limit, siteLink)
            {
                this.type = "Meeting";
            }
            public Meeting() { }
            public override Event ReadDataFromFile(string[] fileLines)
            {
                string type = ExtractData(fileLines, "Type: ");
                string name = ExtractData(fileLines, "Name: ");
                DateTime startDate = DateTime.Parse(ExtractData(fileLines, "Start Date: "));
                DateTime endDate = DateTime.Parse(ExtractData(fileLines, "End Date: "));
                string location = ExtractData(fileLines, "Location: ");
                string info = ExtractData(fileLines, "Info: ");
                DateTime timeStart = DateTime.Parse(ExtractData(fileLines, "Time Start: "));
                DateTime timeLength = DateTime.Parse(ExtractData(fileLines, "Time Length: "));
                int cost = int.Parse(ExtractData(fileLines, "Cost: "));
                string limit = ExtractData(fileLines, "Limit: ");
                string siteLink = ExtractData(fileLines, "Site Link: ");

                return new Meeting(type, name, startDate, endDate, location, info, timeStart, timeLength, cost, limit, siteLink);
            }

            public override void WriteDataToFile(string directory)
            {
                string fileName = $"{name}.txt";
                string filePath = Path.Combine(directory, fileName);
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"Type: {type}");
                    writer.WriteLine($"Name: {name}");
                    writer.WriteLine($"Start Date: {startDate}");
                    writer.WriteLine($"End Date: {endDate}");
                    writer.WriteLine($"Location: {location}");
                    writer.WriteLine($"Info: {info}");
                    writer.WriteLine($"Time Start: {timeStart}");
                    writer.WriteLine($"Time Length: {timeLength}");
                    writer.WriteLine($"Cost: {cost}");
                    writer.WriteLine($"Limit: {limit}");
                    writer.WriteLine($"Site Link: {siteLink}");
                }
            }
        }
        public class Standup : Event
        {
            public Standup(string type, string name, DateTime startDate,
                DateTime endDate, string location, string info, DateTime timeStart,
                DateTime timeLength, int cost, string limit, string siteLink)
                : base(type, name, startDate, endDate, location, info, timeStart, timeLength, cost, limit, siteLink)
            {
                this.type = "Standup";
            }
            public Standup() { }
            public override Event ReadDataFromFile(string[] fileLines)
            {
                string type = ExtractData(fileLines, "Type: ");
                string name = ExtractData(fileLines, "Name: ");
                DateTime startDate = DateTime.Parse(ExtractData(fileLines, "Start Date: "));
                DateTime endDate = DateTime.Parse(ExtractData(fileLines, "End Date: "));
                string location = ExtractData(fileLines, "Location: ");
                string info = ExtractData(fileLines, "Info: ");
                DateTime timeStart = DateTime.Parse(ExtractData(fileLines, "Time Start: "));
                DateTime timeLength = DateTime.Parse(ExtractData(fileLines, "Time Length: "));
                int cost = int.Parse(ExtractData(fileLines, "Cost: "));
                string limit = ExtractData(fileLines, "Limit: ");
                string siteLink = ExtractData(fileLines, "Site Link: ");

                return new Standup(type, name, startDate, endDate, location, info, timeStart, timeLength, cost, limit, siteLink);
            }
            public override void WriteDataToFile(string directory)
            {
                string fileName = $"{name}.txt";
                string filePath = Path.Combine(directory, fileName);
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"Type: {type}");
                    writer.WriteLine($"Name: {name}");
                    writer.WriteLine($"Start Date: {startDate}");
                    writer.WriteLine($"End Date: {endDate}");
                    writer.WriteLine($"Location: {location}");
                    writer.WriteLine($"Info: {info}");
                    writer.WriteLine($"Time Start: {timeStart}");
                    writer.WriteLine($"Time Length: {timeLength}");
                    writer.WriteLine($"Cost: {cost}");
                    writer.WriteLine($"Limit: {limit}");
                    writer.WriteLine($"Site Link: {siteLink}");
                }
            }
        }
        public class Entertainment : Event
        {
            public string goal { get; set; }
            public string tools { get; set; }
            public string author { get; set; }

            public Entertainment(string type, string name, string author, DateTime startDate,
                DateTime endDate, string location, string goal, string tools, string info, DateTime timeStart,
                DateTime timeLength, int cost, string limit, string siteLink)
                : base(type, name, startDate, endDate, location, info, timeStart, timeLength, cost, limit, siteLink)
            {
                this.type = "Entertainment";
                this.goal = goal;
                this.tools = tools;
                this.author = author;
            }
            public Entertainment() { }
            public override Event ReadDataFromFile(string[] fileLines)
            {
                string type = ExtractData(fileLines, "Type: ");
                string name = ExtractData(fileLines, "Name: ");
                string author = ExtractData(fileLines, "Author: ");
                DateTime startDate = DateTime.Parse(ExtractData(fileLines, "Start Date: "));
                DateTime endDate = DateTime.Parse(ExtractData(fileLines, "End Date: "));
                string location = ExtractData(fileLines, "Location: ");
                string goal = ExtractData(fileLines, "Goal: ");
                string tools = ExtractData(fileLines, "Tools: ");
                string info = ExtractData(fileLines, "Info: ");
                DateTime timeStart = DateTime.Parse(ExtractData(fileLines, "Time Start: "));
                DateTime timeLength = DateTime.Parse(ExtractData(fileLines, "Time Length: "));
                int cost = int.Parse(ExtractData(fileLines, "Cost: "));
                string limit = ExtractData(fileLines, "Limit: ");
                string siteLink = ExtractData(fileLines, "Site Link: ");

                return new Entertainment(type, name, author, startDate, endDate, location, goal, tools, 
                                         info, timeStart, timeLength, cost, limit, siteLink);
            }

            public override void WriteDataToFile(string directory)
            {
                string fileName = $"{name}.txt";
                string filePath = Path.Combine(directory, fileName);
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"Type: {type}");
                    writer.WriteLine($"Name: {name}");
                    writer.WriteLine($"Author: {author}");
                    writer.WriteLine($"Start Date: {startDate}");
                    writer.WriteLine($"End Date: {endDate}");
                    writer.WriteLine($"Location: {location}");
                    writer.WriteLine($"Goal: {goal}");
                    writer.WriteLine($"Tools: {tools}");
                    writer.WriteLine($"Info: {info}");
                    writer.WriteLine($"Time Start: {timeStart}");
                    writer.WriteLine($"Time Length: {timeLength}");
                    writer.WriteLine($"Cost: {cost}");
                    writer.WriteLine($"Limit: {limit}");
                    writer.WriteLine($"Site Link: {siteLink}");
                }
            }
        }
        public void saveEvent_Click(object sender, EventArgs e)
        {
            try
            {
                int cost = 0; // Значення за замовчуванням
                if (!string.IsNullOrWhiteSpace(eventCost.Text) && int.Parse(eventCost.Text) > 0)
                {
                    cost = int.Parse(eventCost.Text);
                }
                switch (numberOfSelectedSubject)
                {   
                    case 1:
                        TematicEvenings newEvent1 = new TematicEvenings("TematicEvenings", eventName.Text, eventDate1.Value, eventDate2.Value, eventLocation.Text,
                            eventInfo.Text, eventTimeStart.Value, eventTimeLength.Value, cost, eventLimit.Text, eventLink.Text);
                        newEvent1.WriteDataToFile(dayInfo.folderPath);
                        dayInfo.events.Add(newEvent1);
                        break;
                    case 2:
                        Questions newEvent2 = new Questions("Questions", eventName.Text, eventAuthor.Text, eventDate1.Value, eventDate2.Value, eventLocation.Text,
                            eventInfo.Text, eventTimeStart.Value, eventTimeLength.Value, cost, eventLimit.Text, eventLink.Text);
                        newEvent2.WriteDataToFile(dayInfo.folderPath);
                        dayInfo.events.Add(newEvent2);
                        break;
                    case 3:
                        Meeting newEvent3 = new Meeting("Meeting", eventName.Text, eventDate1.Value, eventDate2.Value, eventLocation.Text, eventInfo.Text,
                            eventTimeStart.Value, eventTimeLength.Value, cost, eventLimit.Text, eventLink.Text);
                        newEvent3.WriteDataToFile(dayInfo.folderPath);
                        dayInfo.events.Add(newEvent3);
                        break;
                    case 4:
                        Standup newEvent4 = new Standup("Standup", eventName.Text, eventDate1.Value, eventDate2.Value, eventLocation.Text,
                            eventInfo.Text, eventTimeStart.Value, eventTimeLength.Value, cost, eventLimit.Text, eventLink.Text);
                        newEvent4.WriteDataToFile(dayInfo.folderPath);
                        dayInfo.events.Add(newEvent4);
                        break;
                    case 5:
                        Entertainment newEvent5 = new Entertainment("Entertainment", eventName.Text, eventAuthor.Text, eventDate1.Value, eventDate2.Value, eventLocation.Text,
                             eventGoal.Text, eventTools.Text, eventInfo.Text, eventTimeStart.Value, eventTimeLength.Value, cost, eventLimit.Text, eventLink.Text);
                        newEvent5.WriteDataToFile(dayInfo.folderPath);
                        dayInfo.events.Add(newEvent5);
                        break;
                    }
            }catch(Exception ex) { MessageBox.Show("Перевірте правильність введення значень! Обов'язково повинна бути назва події та її ціна"); }
        }
        private void CreateEvent_FormClosed(object sender, FormClosedEventArgs e)
        {
            dayInfo.UpdateEvents();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrepareField(comboBox1.SelectedItem.ToString());
        }
        private void PrepareField(string selectedSubject)
        {
            numberOfSelectedSubject = (int)selectedSubject[0] - 48;
            switch (numberOfSelectedSubject)
            {
                case 1://+
                    date_2.Location = new Point(464, 75);
                    location_3.Location = new Point(454, 105);
                    info_4.Location = new Point(440, 140);
                    info_4.Text = "Основна інформація:";
                    start_5.Location = new Point(462, 280);
                    time_6.Location = new Point(394, 310);
                    cost_7.Location = new Point(475, 340);
                    limit_8.Location = new Point(497, 370);
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
                case 2://+
                    author_22.Visible = true;
                    eventAuthor.Visible = true;
                    author_22.Location = new Point(535, 75);
                    date_2.Location = new Point(464, 105);
                    location_3.Location = new Point(454, 135);
                    info_4.Location = new Point(507, 175);
                    info_4.Text = "Запитання:";
                    start_5.Location = new Point(462, 310);
                    time_6.Location = new Point(394, 340);
                    cost_7.Location = new Point(475, 370);
                    limit_8.Location = new Point(497, 400);
                    eventDate1.Location = new Point(592, 105);
                    eventDate2.Location = new Point(742, 105);
                    eventInfo.Location = new Point(592, 170);
                    eventCost.Location = new Point(592, 370);
                    eventLimit.Location = new Point(592, 400);
                    eventTimeStart.Location = new Point(592, 310);
                    eventTimeLength.Location = new Point(592, 340);
                    eventLocation.Location = new Point(592, 135);
                    goal_55.Visible = false;
                    eventGoal.Visible = false;
                    eventTools.Visible = false;
                    tools_55.Visible = false;
                    break;
                case 3:
                    date_2.Location = new Point(464, 75);
                    location_3.Location = new Point(454, 105);
                    info_4.Location = new Point(496, 140);
                    info_4.Text = "Гості заходу:";
                    start_5.Location = new Point(462, 280);
                    time_6.Location = new Point(394, 310);
                    cost_7.Location = new Point(475, 340);
                    limit_8.Location = new Point(497, 370);
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
                    date_2.Location = new Point(464, 75);
                    location_3.Location = new Point(454, 105);
                    info_4.Location = new Point(449, 140);
                    info_4.Text = "Програма та ведучі:";
                    start_5.Location = new Point(462, 280);
                    time_6.Location = new Point(394, 310);
                    cost_7.Location = new Point(475, 340);
                    limit_8.Location = new Point(497, 370);
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
                case 5://+
                    eventAuthor.Visible = true;
                    author_22.Visible = true;
                    goal_55.Visible = true;
                    eventGoal.Visible = true;
                    eventTools.Visible = true;
                    tools_55.Visible = true;
                    author_22.Location = new Point(535, 75);
                    date_2.Location = new Point(464, 105);
                    location_3.Location = new Point(454, 135);
                    goal_55.Location = new Point(541, 170);
                    tools_55.Location = new Point(495, 235);
                    info_4.Text = "Програма та ведучі:";
                    info_4.Location = new Point(449, 300);
                    start_5.Location = new Point(462, 440);
                    time_6.Location = new Point(394, 470);
                    cost_7.Location = new Point(475, 500);
                    limit_8.Location = new Point(497, 530);
                    eventGoal.Location = new Point(593, 170);
                    eventTools.Location = new Point(593, 235);
                    eventDate1.Location = new Point(593, 105);
                    eventDate2.Location = new Point(742, 105);
                    eventInfo.Location = new Point(592, 300);
                    eventCost.Location = new Point(592, 500);
                    eventLimit.Location = new Point(592, 530);
                    eventTimeStart.Location = new Point(592, 440);
                    eventTimeLength.Location = new Point(592, 470);
                    eventLocation.Location = new Point(593, 135);
                    break;
            }
            eventName.Location = new Point(592, 45);name_1.Location = new Point(352, 43);
            name_1.Visible = true;date_2.Visible = true;location_3.Visible = true;info_4.Visible = true;start_5.Visible = true;time_6.Visible = true;cost_7.Visible = true;limit_8.Visible = true; link_9.Visible = true;
            eventName.Visible = true;eventDate1.Visible = true;eventDate2.Visible = true;eventLocation.Visible = true;eventInfo.Visible = true;eventTimeStart.Visible = true;eventTimeLength.Visible = true;eventCost.Visible = true;eventLimit.Visible = true;eventLink.Visible = true;
        }
        private void CreateEvent_Load(object sender, EventArgs e)
        {
            if (indexEventToChange >=0)
            {
                if (indexEventToChange!=-1)
                {
                    name_1.Visible = true; date_2.Visible = true; location_3.Visible = true; info_4.Visible = true; start_5.Visible = true; time_6.Visible = true; cost_7.Visible = true; limit_8.Visible = true;//388, 45
                    eventName.Visible = true; eventName.Text = dayInfo.events[indexEventToChange].name; eventDate1.Visible = true; eventDate1.Value = dayInfo.events[indexEventToChange].startDate; eventDate2.Visible = true; eventDate2.Value = dayInfo.events[indexEventToChange].endDate; eventLocation.Visible = true; eventLocation.Text = dayInfo.events[indexEventToChange].location; eventInfo.Visible = true; eventInfo.Text = dayInfo.events[indexEventToChange].info; eventTimeStart.Visible = true; eventTimeStart.Value = dayInfo.events[indexEventToChange].timeStart; eventTimeLength.Visible = true; eventTimeLength.Value = dayInfo.events[indexEventToChange].timeLength; eventCost.Visible = true; eventCost.Text = Convert.ToString(dayInfo.events[indexEventToChange].cost); eventLimit.Visible = true; eventLimit.Text = dayInfo.events[indexEventToChange].limit; eventLink.Text = dayInfo.events[indexEventToChange].siteLink;
                    switch (dayInfo.events[indexEventToChange].type)
                    {
                        case "TematicEvenings":
                            comboBox1.SelectedIndex = 0;
                            break;
                        case "Questions":
                            Questions copyEvent = (Questions)dayInfo.events[indexEventToChange];
                            eventAuthor.Text = copyEvent.author;
                            comboBox1.SelectedIndex = 1;
                            break;
                        case "Meeting":
                            comboBox1.SelectedIndex = 2;
                            break;
                        case "Standup":
                            comboBox1.SelectedIndex = 3;
                            break;
                        case "Entertainment":
                            Entertainment copyEvent1 = (Entertainment)dayInfo.events[indexEventToChange];
                            eventAuthor.Text = copyEvent1.author;eventGoal.Text = copyEvent1.goal;eventTools.Text = copyEvent1.tools;
                            comboBox1.SelectedIndex = 4;
                            break;
                    }
                    File.Delete(dayInfo.folderPath + '\\' + dayInfo.events[indexEventToChange].name + ".txt");
                    dayInfo.events.Remove(dayInfo.events[indexEventToChange]);
                }
            }
        }

        private void exitProgram_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Чи дійсно ви хочете вийти з програми?", "Вихід з програми", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
