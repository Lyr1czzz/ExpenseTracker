
using ExpenseTracker.Models;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;
            try
            {
                ExpenseTrakerDbContext dbContext = new ExpenseTrakerDbContext();
                var user = dbContext.Users
                    .FirstOrDefault(u => u.Login == login && u.Password == password);
                if (user == null)
                {
                    MessageBox.Show("Неправильное имя пользователя или пароль!");
                    return;
                }
                CurrentUser.userId = user.Id;
                CurrentUser.userLogin = user.Login;
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при входе: {ex.Message}");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewPasswordForm newPasswordForm = new NewPasswordForm();
            newPasswordForm.Show();
            this.Hide();
        }
    }
}
