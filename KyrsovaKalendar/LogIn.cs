using System;
using System.IO;
using System.Windows.Forms;

namespace KyrsovaKalendar
{
    public static class user
    {
        public static bool IsAdmin { get; set; }
    }
    public partial class LogIn : Form
    {
        private string path = @"C:\Users\Ivanchik\source\repos\KyrsovaKalendar\users";
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
                        user.IsAdmin = fileLines[1] == "admin" ? true : false;
                        MessageBox.Show($"Вхід успішний. Роль: {(user.IsAdmin ? "admin" : "user")}");
                        this.Hide();
                        Calendar calendar = new Calendar(user.IsAdmin);
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
