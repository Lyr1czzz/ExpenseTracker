
using ExpenseTracker.Models;
using ExpenseTracker.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker.Forms
{
    public partial class UC_AddBalance : UserControl
    {
        private MainForm mainForm;

        public UC_AddBalance(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void btnAddBalance_Click(object sender, EventArgs e)
        {
            try
            {
                ExpenseTrakerDbContext dbContext = new ExpenseTrakerDbContext();
                var user = dbContext.Users.FirstOrDefault(u => u.Id == CurrentUser.userId);
                if (user != null)
                {
                    try
                    {
                        user.Usdbalance += decimal.Parse(txtPrice.Text) / 3;
                        user.Brbalance += decimal.Parse(txtPrice.Text);
                        user.Rubalance += decimal.Parse(txtPrice.Text) * 30;
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка ввода");
                        return;
                    }
                    dbContext.SaveChanges();
                    txtPrice.Clear();
                    UpdateInterface.UpdateBalance(mainForm);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка пополнения!");
            }
        }
    }
}
