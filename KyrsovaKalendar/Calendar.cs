using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KyrsovaKalendar.CreateEvent;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KyrsovaKalendar
{
    public partial class Calendar : Form
    {
        public int month, year;
        DateTime now = DateTime.Now;
        public string directoriesPath = @"C:\Users\Ivanchik\source\repos\KyrsovaKalendar\events";
        static public bool isAdmin;
        public Calendar(bool _isAdmin)
        {
            InitializeComponent();
            isAdmin = _isAdmin;
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            month = now.Month;
            year = now.Year;
            CalcCalendar(month, year);
        }
        private void CalcCalendar(int month, int year)
        {
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            date.Text = monthName + " " + year;
            DateTime startOfMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayOfTheWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d"));
            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank userBlank = new UserControlBlank();
                dayPanel.Controls.Add(userBlank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays userDays = new UserControlDays(month, year);
                userDays.Days(i);
                dayPanel.Controls.Add(userDays);
                userDays.AddClickEventToUserControlDays();
            }
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            dayPanel.Controls.Clear();
            if (month == 12)
            {
                month = 0;
                year++;
            }
            CalcCalendar(++month, year);
        }
        private void buttonEventShow_Click(object sender, EventArgs e)
        {
            ShowEventForm form1 = new ShowEventForm();
            form1.ShowDialog();
        }

        private void FindEventButton_Click(object sender, EventArgs e)
        {
            FindEvent();
        }
        private void FindEvent()
        {
            if (FindEventTextBox.Text != "")
            {
                string[] eventFolders = Directory.GetDirectories(directoriesPath);
                string fileName = FindEventTextBox.Text;
                Regex fileNameRegex = new Regex(@"(\d{1,2})_(\d{1,2})_(\d{4})$");
                foreach (string folderPath in eventFolders)
                {
                    string[] files = Directory.GetFiles(folderPath);
                    foreach (string filePath in files)
                    {
                        string fileNameOnly = Path.GetFileName(filePath);
                        if (fileName+".txt" == fileNameOnly)
                        {
                            Match match = fileNameRegex.Match(folderPath);
                            if (match.Success)
                            {   DayInfo dayInfo = new DayInfo(int.Parse(match.Groups[1].Value), int.Parse(match.Groups[2].Value), int.Parse(match.Groups[3].Value), Array.IndexOf(files, filePath));
                                dayInfo.ShowDialog();
                            }
                        }
                    }
                }
                MessageBox.Show("Файл не знайдено!");
            }
            else
            {
                MessageBox.Show("Вкажіть назву події для пошуку!");
            }
        }
        private void prevButton_Click(object sender, EventArgs e)
        {
            dayPanel.Controls.Clear();
            if (month == 1)
            {
                month = 13; year--;
            }
            CalcCalendar(--month, year);
        }

    }
}
