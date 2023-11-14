using ExpenseTracker.Forms;
using ExpenseTracker.Models;
using Microsoft.VisualBasic.Logging;
using Siticone.Desktop.UI.WinForms;
using Siticone.Desktop.UI.WinForms.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace ExpenseTracker.Service
{
    static public class UpdateInterface
    {
        public static void UpdateBalance(MainForm mainForm)
        {
            ExpenseTrakerDbContext dbContext = new ExpenseTrakerDbContext();
            var user = dbContext.Users.FirstOrDefault(u => u.Login == CurrentUser.userLogin);
            if (user != null)
            {
                if (mainForm.ComboCurrency.SelectedIndex == 0)
                {
                    mainForm.lblBalance.Text = user.Rubalance.ToString() + " Ru";
                }
                else if (mainForm.ComboCurrency.SelectedIndex == 1)
                {
                    mainForm.lblBalance.Text = user.Brbalance.ToString() + " Br";
                }
                else if (mainForm.ComboCurrency.SelectedIndex == 2)
                {
                    mainForm.lblBalance.Text = user.Usdbalance.ToString() + " $";
                }
            }
        }

        public static void CreateInterfacePages(MainForm mainForm)
        {
            UC_AddCategory uC_AddCategory = new(mainForm);
            mainForm.pnlMain.Controls.Add(uC_AddCategory);
            uC_AddCategory.Dock = DockStyle.Fill;
            mainForm.btnAddCategory.Click += (sender, e) =>
            {
                uC_AddCategory.BringToFront();
            };

            UC_AddBalance uC_AddBalance = new(mainForm);
            mainForm.pnlMain.Controls.Add(uC_AddBalance);
            uC_AddBalance.Dock = DockStyle.Fill;
            mainForm.btnAddBalance.Click += (sender, e) =>
            {
                uC_AddBalance.BringToFront();
            };

            var element = mainForm.pnlMain.Controls.Find("uC_Statistics", true).ToList();
            foreach (var item in element)
            {
                if (item != null)
                    mainForm.pnlMain.Controls.Remove(item);
            }

            UC_Statistics uC_Statistics = new(mainForm);
            uC_Statistics.Name = "uC_Statistics";
            mainForm.pnlMain.Controls.Add(uC_Statistics);
            uC_Statistics.Dock = DockStyle.Fill;
            mainForm.btnStatistics.Click += (sender, e) =>
            {
                uC_Statistics.BringToFront();
            };
            mainForm.uC_Statistics = uC_Statistics;
        }

        public static void UpdateCategory(MainForm mainForm)
        {
            mainForm.pnlCategory.Controls.Clear();
            mainForm.pnlMain.Controls.Clear();

            ExpenseTrakerDbContext dbContext = new ExpenseTrakerDbContext();
            var categories = dbContext.Categories
                .Where(c => c.Userid == CurrentUser.userId).ToList();
            if (categories != null)
            {
                foreach (var category in categories)
                {
                    SiticoneButton siticoneButton = new SiticoneButton();
                    mainForm.pnlCategory.Controls.Add(siticoneButton);
                    siticoneButton.Text = category.Name;
                    siticoneButton.Name = "btn" + category.Name;
                    siticoneButton.ButtonMode = ButtonMode.RadioButton;
                    siticoneButton.Size = new(250, 80);
                    siticoneButton.CustomBorderThickness = new(5, 0, 0, 0);
                    siticoneButton.CheckedState.CustomBorderColor = Color.FromArgb(8, 83, 255);
                    siticoneButton.ForeColor = Color.FromArgb(28, 28, 28);
                    siticoneButton.FillColor = Color.White;
                    siticoneButton.TextOffset = new(0, 0);
                    siticoneButton.CheckedState.FillColor = Color.White;

                    UC_Category uC_Category = new(mainForm);
                    uC_Category.CategoryId = category.Id;
                    uC_Category.Name = category.Name;
                    mainForm.pnlMain.Controls.Add(uC_Category);
                    uC_Category.Dock = DockStyle.Fill;

                    siticoneButton.CheckedChanged += (sender, e) =>
                    {
                        if (siticoneButton.Checked) uC_Category.BringToFront();
                        uC_Category.Name = category.Name;
                        UpdateInterface.UpdateNotes(mainForm, uC_Category);
                    };
                    siticoneButton.Dock = DockStyle.Top;
                }
            }
            CreateInterfacePages(mainForm);
        }

        public static void UpdateDiagram(MainForm mainForm, UC_Statistics uC_Statistics, DateTime dateTime1, DateTime dateTime2)
        {
            uC_Statistics.pnlDiagram.Controls.Clear();
            ExpenseTrakerDbContext dbContext = new ExpenseTrakerDbContext();
            var categories = dbContext.Categories
                .Where(c => c.Userid == CurrentUser.userId).ToList();
            Chart chart = new Chart();
            Series series = new Series("Расходы по категориям");
            foreach (var category in categories)
            {
                decimal notesSum = 0;
                var notes = dbContext.Notes
                .Where(n => n.Categoryid == category.Id 
                && n.Date.ToUniversalTime() > dateTime1.ToUniversalTime() 
                && n.Date.ToUniversalTime() < dateTime2.ToUniversalTime())
                .ToList();
                foreach (var note in notes)
                {
                    if (mainForm.ComboCurrency.SelectedIndex == 0)
                    {
                        notesSum += (decimal)note.Ruprice;
                    }
                    else if (mainForm.ComboCurrency.SelectedIndex == 1)
                    {
                        notesSum += (decimal)note.Brprice;
                    }
                    else if (mainForm.ComboCurrency.SelectedIndex == 2)
                    {
                        notesSum += (decimal)note.Usdprice;
                    }
                }
                if (mainForm.ComboCurrency.SelectedIndex == 0)
                {
                    series.Points.AddXY(category.Name + " | " + Math.Round(notesSum, 2) + "Ru", Math.Round(notesSum, 2));
                }
                else if (mainForm.ComboCurrency.SelectedIndex == 1)
                {
                    series.Points.AddXY(category.Name + " | " + Math.Round(notesSum, 2) + "Br", Math.Round(notesSum, 2));
                }
                else if (mainForm.ComboCurrency.SelectedIndex == 2)
                {
                    series.Points.AddXY(category.Name + " | " + Math.Round(notesSum, 2) + "Usd", Math.Round(notesSum, 2));
                }
                
            }
            series.ChartType = SeriesChartType.Pie;

            chart.Series.Add(series);
            chart.BackColor = Color.Gainsboro;
            chart.ChartAreas.Add("ChartArea2");
            chart.Legends.Add("Legend1");
            chart.Location = new System.Drawing.Point(0, 0);
            chart.Size = new Size(530, 700);
            uC_Statistics.pnlDiagram.Controls.Add(chart);
            chart.Dock = DockStyle.Top;
        }

        public static void UpdateDiagram(MainForm mainForm, UC_Statistics uC_Statistics)
        {
            uC_Statistics.pnlDiagram.Controls.Clear();
            ExpenseTrakerDbContext dbContext = new ExpenseTrakerDbContext();
            var categories = dbContext.Categories
                .Where(c => c.Userid == CurrentUser.userId).ToList();
            Chart chart = new Chart();
            Series series = new Series("Расходы по категориям");
            foreach (var category in categories)
            {
                decimal notesSum = 0;
                var notes = dbContext.Notes
                .Where(n => n.Categoryid == category.Id).ToList();
                foreach (var note in notes)
                {
                    if (mainForm.ComboCurrency.SelectedIndex == 0)
                    {
                        notesSum += (decimal)note.Ruprice;
                    }
                    else if (mainForm.ComboCurrency.SelectedIndex == 1)
                    {
                        notesSum += (decimal)note.Brprice;
                    }
                    else if (mainForm.ComboCurrency.SelectedIndex == 2)
                    {
                        notesSum += (decimal)note.Usdprice;
                    }
                }
                if (mainForm.ComboCurrency.SelectedIndex == 0)
                {
                    series.Points.AddXY(category.Name + " | " + Math.Round(notesSum, 2) + "Ru", Math.Round(notesSum, 2));
                }
                else if (mainForm.ComboCurrency.SelectedIndex == 1)
                {
                    series.Points.AddXY(category.Name + " | " + Math.Round(notesSum, 2) + "Br", Math.Round(notesSum, 2));
                }
                else if (mainForm.ComboCurrency.SelectedIndex == 2)
                {
                    series.Points.AddXY(category.Name + " | " + Math.Round(notesSum, 2) + "Usd", Math.Round(notesSum, 2));
                }

            }
            series.ChartType = SeriesChartType.Pie;

            chart.Series.Add(series);
            chart.BackColor = Color.Gainsboro;
            chart.ChartAreas.Add("ChartArea2");
            chart.Legends.Add("Legend1");
            chart.Location = new System.Drawing.Point(0, 0);
            chart.Size = new Size(530, 700);
            uC_Statistics.pnlDiagram.Controls.Add(chart);
            chart.Dock = DockStyle.Top;
        }

        public static bool CheckPincode(PinForm pinForm, int pincode)
        {
            ExpenseTrakerDbContext dbContext = new ExpenseTrakerDbContext();
            var user = dbContext.Users
                .FirstOrDefault(u => u.Login == pinForm.login
                && u.Pincode == pincode);
            return user != null;
        }

        public static void UpdateNotes(MainForm mainForm, UC_Category uC_Category)
        {
            ExpenseTrakerDbContext dbContext = new ExpenseTrakerDbContext();
            var notes = dbContext.Notes
                .Where(c => c.Categoryid == uC_Category.CategoryId).ToList();
            if (notes != null)
            {
                uC_Category.pnlNotes.Controls.Clear();
                foreach (var note in notes)
                {
                    SiticoneButton siticoneButton = new SiticoneButton();
                    siticoneButton.Name = "note" + note.Text;

                    if (mainForm.ComboCurrency.SelectedIndex == 0)
                    {
                        siticoneButton.Text = "Название: " + note.Text + " | Дата: " + note.Date +  " | Цена: " + Math.Round((decimal)note.Ruprice, 2) + "Ru";
                    }
                    else if (mainForm.ComboCurrency.SelectedIndex == 1)
                    {
                        siticoneButton.Text = "Название: " + note.Text + " | Дата: " + note.Date + " | Цена: " + Math.Round((decimal)note.Brprice, 2) + "Br";
                    }
                    else if (mainForm.ComboCurrency.SelectedIndex == 2)
                    {
                        siticoneButton.Text = "Название: " + note.Text + " | Дата: " + note.Date + " | Цена: " + Math.Round((decimal)note.Usdprice, 2) + "Usd";
                    }

                    siticoneButton.TextAlign = HorizontalAlignment.Left;
                    uC_Category.pnlNotes.Controls.Add(siticoneButton);
                    siticoneButton.Dock = DockStyle.Top;
                }

            }
        }
    }
}
