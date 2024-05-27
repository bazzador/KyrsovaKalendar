using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
namespace KyrsovaKalendar
{
    public partial class ShowEventForm : Form
    {
        public string filePath = @"C:\Users\Ivanchik\source\repos\KyrsovaKalendar\events\";
        public string folderPath;
        private Dictionary<string, string> ukrainianDayOfWeek = new Dictionary<string, string>()
        {
            {"Monday", "ПН"},
            {"Tuesday", "ВТ"},
            {"Wednesday", "СР"},
            {"Thursday", "ЧТ"},
            {"Friday", "ПТ"},
            {"Saturday", "СБ"},
            {"Sunday", "НД"}
        };
        public ShowEventForm()
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
                folderPath = Path.Combine(filePath, now.Day + "_" + now.Month + "_" + now.Year);
                string[] eventFiles = null;
                if (Directory.Exists(folderPath))
                {
                    eventFiles = Directory.GetFiles(folderPath);
                }
                UserShowEvents usEvents = new UserShowEvents(dayOfWeek, now, eventFiles);
                eventsPanel.Controls.Add(usEvents);
                now = now.AddDays(1);
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
