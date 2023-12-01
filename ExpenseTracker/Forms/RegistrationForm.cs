using ExpenseTracker.Models;
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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password1 = txtPassword1.Text;
            string password2 = txtPassword2.Text;
            ExpenseTrakerDbContext dbContext = new ExpenseTrakerDbContext();
            if (password1 != password2)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }
            var existingUser = dbContext.Users.FirstOrDefault(u => u.Login == login);
            if (existingUser != null)
            {
                MessageBox.Show("Пользователь с таким именем уже существует!");
                return;
            }
            if (txtLogin.Text.Length < 5 || txtLogin.Text.Length > 20)
            {
                MessageBox.Show("Имя пользователя должно содержать от 5 до 20 символов!");
                return;
            }
            if (txtPassword1.Text.Length < 8 || txtPassword1.Text.Length > 20)
            {
                MessageBox.Show("Пароль должен содержать от 8 до 20 символов!");
                return;
            }
            Random random = new Random();
            int pincode = random.Next(1000, 9999);
            MessageBox.Show("Ваш пин код: " + pincode + "\nЗапомните его, для восстановления пароля");
            var newUser = new User
            {
                Login = login,
                Password = password1,
                Pincode = pincode
            };
            dbContext.Users.Add(newUser);
            dbContext.SaveChanges();

            MessageBox.Show("Регистрация успешна!");
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && e.KeyChar >= 'А' && e.KeyChar <= 'я')
            {
                e.Handled = true;
            }
        }

        private void txtPassword1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && e.KeyChar >= 'А' && e.KeyChar <= 'я')
            {
                e.Handled = true;
            }
        }

        private void txtPassword2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && e.KeyChar >= 'А' && e.KeyChar <= 'я')
            {
                e.Handled = true;
            }
        }
    }
}
