using ExpenseTracker.Models;
using ExpenseTracker.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class PinForm : Form
    {
        public string login;
        public string password;
        public PinForm(string login, string password)
        {
            InitializeComponent();
            this.login = login;
            this.password = password;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            ExpenseTrakerDbContext dbContext = new ExpenseTrakerDbContext();
            var user = dbContext.Users
                .FirstOrDefault(u => u.Login == login
                && u.Password == password
                && u.Pincode == int.Parse(txtPincode.Text));
            bool flag = UpdateInterface.CheckPincode(this, int.Parse(txtPincode.Text));
            if (flag)
            {
                MessageBox.Show("Пароль успешно сменен!");
                user.Password = password;
                dbContext.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный пинкод!");
            }
        }
    }
}
