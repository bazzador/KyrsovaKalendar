using System;
using System.IO;
using System.Windows.Forms;

namespace KyrsovaKalendar
{
    public partial class SignIn : Form
    {
        string path;
        public SignIn(string path)
        {
            InitializeComponent();
            this.path = path;  
        }

        private void signInConfirmButton_Click(object sender, EventArgs e)
        {
            string fileName = Path.Combine(path, loginTextBox.Text + ".txt");
            string role = radioButton1.Checked ? "admin" : "user";
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(passwordTextBox.Text);
                writer.WriteLine(role);
            }
            MessageBox.Show("Новий користувач створений!");
            this.Close();
        }
    }
}
