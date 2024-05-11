using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KyrsovaKalendar
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> ukrainianDayOfWeek = new Dictionary<string, string>()
        {
            {"Monday", "Понеділок"},
            {"Tuesday", "Вівторок"},
            {"Wednesday", "Середа"},
            {"Thursday", "Четвер"},
            {"Friday", "П'ятниця"},
            {"Saturday", "Субота"},
            {"Sunday", "Неділя"}
        };
        public Form1()
        {
            InitializeComponent();
            Display10Days();
        }
        private void Display10Days()
        {
            DateTime now = DateTime.Now;
            for (int i = 0; i < 10; i++) 
            {
                string dayOfWeek = ukrainianDayOfWeek[now.DayOfWeek.ToString()];
                string day = now.Day.ToString();
                string month = now.ToString("MMMM");
                UserShowEvents usEvents = new UserShowEvents(dayOfWeek, day, month);
                eventsPanel.Controls.Add(usEvents);
                now = now.AddDays(1);
            }
        }
    }
}
