
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
    public partial class NewPasswordForm : Form
    {
        public NewPasswordForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password1 = txtPassword1.Text;
            string password2 = txtPassword2.Text;
            try
            {
                ExpenseTrakerDbContext dbContext = new ExpenseTrakerDbContext();
                var user = dbContext.Users
                    .FirstOrDefault(u => u.Login == login);
                if (user == null)
                {
                    MessageBox.Show("Неправильное имя пользователя!");
                    return;
                }
                if (password1 != password2)
                {
                    MessageBox.Show("Пароли не совпадают!");
                    return;
                }
                if (password1.Length < 8 && password1.Length > 20)
                {
                    MessageBox.Show("Пароль должен содержать от 8 до 20 символов!");
                    return;
                }
                PinForm pinForm = new PinForm(login, password1);
                pinForm.ShowDialog();

                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при входе: {ex.Message}");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void NewPasswordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
