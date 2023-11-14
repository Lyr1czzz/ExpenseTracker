
using ExpenseTracker.Models;
using ExpenseTracker.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class UC_Category : UserControl
    {
        public MainForm mainForm;
        public UC_Statistics uC_Statistics;
        public int CategoryId { get; set; }
        public UC_Category(MainForm mainForm)
        {
            InitializeComponent();
            UpdateInterface.UpdateNotes(mainForm, this);
            this.mainForm = mainForm;
        }



        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            ExpenseTrakerDbContext _db = new ExpenseTrakerDbContext();
            var notesToDelete = _db.Notes
                .Where(n => n.Categoryid == CategoryId);
            _db.Notes.RemoveRange(notesToDelete);
            _db.SaveChanges();
            var deleteCategory = _db.Categories
                .FirstOrDefault(c => c.Userid == CurrentUser.userId && c.Name == this.Name);

            _db.Categories.Remove(deleteCategory);
            _db.SaveChanges();
            UpdateInterface.UpdateCategory(mainForm);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            if (txtPrice.Text == string.Empty) return;
            ExpenseTrakerDbContext _db = new ExpenseTrakerDbContext();
            var user = _db.Users.FirstOrDefault(u => u.Id == CurrentUser.userId);

            decimal usdprice = 0;
            decimal brprice = 0;
            decimal ruprice = 0;

            if (mainForm.ComboCurrency.SelectedIndex == 0)
            {
                user.Usdbalance -= decimal.Parse(txtPrice.Text) / 100;
                user.Brbalance -= decimal.Parse(txtPrice.Text) / 30;
                user.Rubalance -= decimal.Parse(txtPrice.Text);

                usdprice = decimal.Parse(txtPrice.Text) / 100;
                brprice = decimal.Parse(txtPrice.Text) / 30;
                ruprice = decimal.Parse(txtPrice.Text);
            }
            else if (mainForm.ComboCurrency.SelectedIndex == 1)
            {
                user.Usdbalance -= decimal.Parse(txtPrice.Text) / 3;
                user.Brbalance -= decimal.Parse(txtPrice.Text);
                user.Rubalance -= decimal.Parse(txtPrice.Text) * 30;

                usdprice = decimal.Parse(txtPrice.Text) / 3;
                brprice = decimal.Parse(txtPrice.Text);
                ruprice = decimal.Parse(txtPrice.Text) * 30;
            }
            else if (mainForm.ComboCurrency.SelectedIndex == 2)
            {
                user.Usdbalance -= decimal.Parse(txtPrice.Text);
                user.Brbalance -= decimal.Parse(txtPrice.Text) * 3;
                user.Rubalance -= decimal.Parse(txtPrice.Text) * 100;

                usdprice = decimal.Parse(txtPrice.Text);
                brprice = decimal.Parse(txtPrice.Text) * 3;
                ruprice = decimal.Parse(txtPrice.Text) * 100;
            }

            Note note = new Note()
            {
                Categoryid = CategoryId,
                Text = txtText.Text,
                Usdprice = usdprice,
                Brprice = brprice,
                Ruprice = ruprice,
                Date = DateTime.Now.ToUniversalTime(),
            };
            _db.Notes.Add(note);



            _db.SaveChanges();
            UpdateInterface.UpdateNotes(mainForm, this);
            UpdateInterface.CreateInterfacePages(mainForm);
            UpdateInterface.UpdateBalance(mainForm);
            txtPrice.Clear();
            txtText.Clear();
        }
    }
}
