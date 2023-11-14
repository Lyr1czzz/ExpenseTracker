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
using System.Windows.Forms.DataVisualization.Charting;

namespace ExpenseTracker.Forms
{
    public partial class UC_Statistics : UserControl
    {
        MainForm mainForm;
        public UC_Statistics(MainForm mainForm)
        {
            InitializeComponent();
            UpdateInterface.UpdateDiagram(mainForm, this);
            this.mainForm = mainForm;
        }

        private void UC_Statistics_Load(object sender, EventArgs e)
        {

        }

        private void pnlDiagram_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSetFilter_Click(object sender, EventArgs e)
        {
            UpdateInterface.UpdateDiagram(mainForm, this, dateTime1.Value, dateTime2.Value);
        }
    }
}
