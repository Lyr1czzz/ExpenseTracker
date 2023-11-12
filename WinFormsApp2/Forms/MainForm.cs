
using ExpenseTracker.Models;
using ExpenseTracker.Service;
using Siticone.Desktop.UI.WinForms;
using Siticone.Desktop.UI.WinForms.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ExpenseTracker.Forms
{
    public partial class MainForm : Form
    {
        public UC_Statistics uC_Statistics { get; set; }
        public UC_Category uC_Category { get; set; }

        public MainForm()
        {
            InitializeComponent();
            mainUpdateInterface();
            ComboCurrency.SelectedIndex = 1;
        }

        public void mainUpdateInterface()
        {
            UpdateInterface.UpdateBalance(this);
            UpdateInterface.UpdateCategory(this);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void siticoneComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExpenseTrakerDbContext dbContext = new ExpenseTrakerDbContext();
            var user = dbContext.Users.FirstOrDefault(u => u.Login == CurrentUser.userLogin);
            if (user != null)
            {
                if (ComboCurrency.SelectedIndex == 0)
                {
                    lblBalance.Text = (user.Rubalance).ToString();
                }
                else if (ComboCurrency.SelectedIndex == 1)
                {
                    lblBalance.Text = user.Brbalance.ToString();
                }
                else if (ComboCurrency.SelectedIndex == 2)
                {
                    lblBalance.Text = (user.Usdbalance).ToString();
                }
            }
            UpdateInterface.UpdateCategory(this);
            UpdateInterface.UpdateDiagram(this, uC_Statistics);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
