using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KyrsovaKalendar
{
    public partial class LogIn : Form
    {
        private string path = @"C:\Users\Ivanchik\source\repos\KyrsovaKalendar\users";
        private bool isAdmin = false;
        public LogIn()
        {
            InitializeComponent();
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    MessageBox.Show($"Папка '{path}' не існує.");
                    return;
                }

                string[] files = Directory.GetFiles(path);

                foreach (string file in files)
                {
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    string[] fileLines = File.ReadAllLines(file);
                    if (fileName == loginTextBox.Text && fileLines[0] == passwordTextBox.Text)
                    {
                        isAdmin = fileLines[1] == "admin" ? true : false;
                        MessageBox.Show($"Вхід успішний. Роль: {(isAdmin ? "admin" : "user")}");
                        this.Hide();
                        Calendar calendar = new Calendar(isAdmin);
                        calendar.ShowDialog();
                        this.Close();
                        return;
                    }
                }
                MessageBox.Show("Невірний логін або пароль.");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка: {ex.Message}");
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SignIn sign = new SignIn(path);
            sign.ShowDialog();
        }
    }
}
