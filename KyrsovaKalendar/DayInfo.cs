﻿using System;
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
        public UserControlDays parentUserControl;
        public List<Event> events;
        private int currentItem=0;
        public DayInfo(UserControlDays userControl)
        {
            InitializeComponent();
            parentUserControl = userControl;
            events = new List<Event>();
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
                eventName.Text = selectedEvent.name;
                eventDate1.Text = selectedEvent.startDate.ToString();
                eventDate2.Text = selectedEvent.endDate.ToString();
                eventInfo.Text = selectedEvent.info;
                eventTimeStart.Text = selectedEvent.timeStart.ToString();
                eventTimeLength.Text = selectedEvent.timeLength.ToString();
                eventCost.Text = selectedEvent.cost.ToString();
                eventLimit.Text = selectedEvent.limit;
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
            folderPath = Path.Combine(filePath, parentUserControl.dayFolder + "_" + parentUserControl.monthFolder + "_" + parentUserControl.yearFolder);
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
                    }
                }
                UpdateEvents();
            }
        }
    }
}
