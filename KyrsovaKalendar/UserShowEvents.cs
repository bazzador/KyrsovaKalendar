using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KyrsovaKalendar
{
    public partial class UserShowEvents : UserControl
    {
        private DateTime date; 
        public UserShowEvents(string dayOfWeek, DateTime date, string[] eventNames)
        {
            InitializeComponent();
            DayOfWeek(dayOfWeek);
            Day(Convert.ToString(date.Day));
            Month(Convert.ToString(date.Month));
            this.date = date;
            if (eventNames != null)
            {
               ListEvent(eventNames);
                if (eventNames.Length > 11)
                {
                    eventList.ScrollAlwaysVisible = true;
                }
            }
           
        }
        public void DayOfWeek(string dayOfWeek)
        {
            this.dayOfWeek.Text = dayOfWeek;
        }
        public void Day(string day)
        {
            this.day.Text = day;
        }
        public void Month(string month)
        {
            this.month.Text = date.ToString("MMMM");
        }
        public void ListEvent(string[] events)
        {
            foreach(string name in events)
            {
                string documentName = GetDocumentName(name);
                eventList.Items.Add(documentName);
            }
        }
        static string GetDocumentName(string filePath)
        {
            string[] parts = filePath.Split('\\');

            string fileName = parts[parts.Length - 1];

            string[] fileNameParts = fileName.Split('.');

            string documentName = fileNameParts[0];

            return documentName;
        }
        private void UserShowEvents_Click(object sender, EventArgs e)
        {
            DayInfo form = new DayInfo(date.Day, date.Month, date.Year);
            form.ShowDialog();
        }

        private void eventList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DayInfo dayInfo = new DayInfo(date.Day, date.Month, date.Year, eventList.SelectedIndex);
            dayInfo.ShowDialog();
        }
    }
}
