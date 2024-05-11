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
        public UserShowEvents(string dayOfWeek, string day, string month)
        {
            InitializeComponent();
            DayOfWeek(dayOfWeek);
            Day(day);
            Month(month);
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
            this.month.Text = month;
        }
    }
}
