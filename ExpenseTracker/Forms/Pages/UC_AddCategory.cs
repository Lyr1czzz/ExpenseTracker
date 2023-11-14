
using ExpenseTracker.Models;
using ExpenseTracker.Service;
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
    public partial class UC_AddCategory : UserControl
    {
        public MainForm mainForm;

        public UC_AddCategory(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            ExpenseTrakerDbContext _db = new ExpenseTrakerDbContext();
            var categories = _db.Categories.Where(c => c.Userid == CurrentUser.userId).ToList();
            foreach(var categ in categories)
            {
                if(categ.Name == txtCategoryName.Text)
                {
                    MessageBox.Show("Категория с таким именем уже существует!");
                    return;
                }
            }

            Category category = new Category()
            {
                Userid = CurrentUser.userId,
                Name = txtCategoryName.Text
            };
            _db.Categories.Add(category);
            _db.SaveChanges();
            UpdateInterface.UpdateCategory(mainForm);
            txtCategoryName.Clear();
        }
    }
}
