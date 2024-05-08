using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KyrsovaKalendar
{
    public partial class Calendar : Form
    {
        int month, year;
        DateTime now = DateTime.Now;
        public Calendar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
                UserControlDays userDays = new UserControlDays();
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
        private void prevButton_Click(object sender, EventArgs e)
        {
            dayPanel.Controls.Clear();
            if (month == 1)
            {
                month = 13;
                year--;
            }
            CalcCalendar(--month, year);
        }

    }
}
