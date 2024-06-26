﻿using System;
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
    public partial class UserControlDays : UserControl
    {
        public int dayFolder;
        public int monthFolder;
        public int yearFolder;
        public UserControlDays(int monthFolder, int yearFolder)
        {
            InitializeComponent();
            this.monthFolder = monthFolder;
            this.yearFolder = yearFolder;
        }
        private void UserControlDays_Click(object sender, EventArgs e)
        {
            DayInfo form = new DayInfo(dayFolder, monthFolder, yearFolder);
            form.ShowDialog();
        }
        public void AddClickEventToUserControlDays()
        {
            Click += UserControlDays_Click;
        }
        public void Days(int numDay)    
        {
            labelDays.Text = numDay + "";
            dayFolder = numDay;
        }

    }
}
