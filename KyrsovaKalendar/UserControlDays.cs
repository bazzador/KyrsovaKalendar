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
    public partial class UserControlDays : UserControl
    {
        public UserControlDays()
        {
            InitializeComponent();
        }
        private void UserControlDays_Click(object sender, EventArgs e)
        {
            // Ваша логіка обробника подій Click для UserControlDays
            DayInfo form = new DayInfo(this);
            form.ShowDialog();
        }
        public void AddClickEventToUserControlDays()
        {
            this.Click += UserControlDays_Click;
        }
        public void Days(int numDay)
        {
            labelDays.Text = numDay + "";
        }

    }
}
