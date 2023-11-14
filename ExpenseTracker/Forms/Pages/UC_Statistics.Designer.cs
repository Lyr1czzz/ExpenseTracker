namespace ExpenseTracker.Forms
{
    partial class UC_Statistics
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            pnlFilters = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            dateTime1 = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            dateTime2 = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            label2 = new Label();
            label1 = new Label();
            btnSetFilter = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            pnlDiagram = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            pnlFilters.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFilters
            // 
            pnlFilters.Controls.Add(dateTime1);
            pnlFilters.Controls.Add(dateTime2);
            pnlFilters.Controls.Add(label2);
            pnlFilters.Controls.Add(label1);
            pnlFilters.Controls.Add(btnSetFilter);
            pnlFilters.Dock = DockStyle.Top;
            pnlFilters.Location = new Point(0, 0);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Size = new Size(850, 99);
            pnlFilters.TabIndex = 0;
            // 
            // dateTime1
            // 
            dateTime1.BorderRadius = 20;
            dateTime1.Checked = true;
            dateTime1.FillColor = Color.FromArgb(94, 148, 255);
            dateTime1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTime1.Format = DateTimePickerFormat.Long;
            dateTime1.Location = new Point(30, 27);
            dateTime1.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dateTime1.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dateTime1.Name = "dateTime1";
            dateTime1.Size = new Size(233, 45);
            dateTime1.TabIndex = 14;
            dateTime1.Value = new DateTime(2023, 11, 14, 19, 1, 23, 230);
            // 
            // dateTime2
            // 
            dateTime2.BorderRadius = 20;
            dateTime2.Checked = true;
            dateTime2.FillColor = Color.FromArgb(94, 148, 255);
            dateTime2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTime2.Format = DateTimePickerFormat.Long;
            dateTime2.Location = new Point(308, 27);
            dateTime2.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dateTime2.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dateTime2.Name = "dateTime2";
            dateTime2.Size = new Size(244, 45);
            dateTime2.TabIndex = 13;
            dateTime2.Value = new DateTime(2023, 11, 13, 16, 51, 23, 936);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(308, 4);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 12;
            label2.Text = "Дата до:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 4);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 11;
            label1.Text = "Дата от:";
            // 
            // btnSetFilter
            // 
            btnSetFilter.BackColor = Color.Transparent;
            btnSetFilter.BorderRadius = 25;
            btnSetFilter.DisabledState.BorderColor = Color.DarkGray;
            btnSetFilter.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSetFilter.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSetFilter.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnSetFilter.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSetFilter.Dock = DockStyle.Right;
            btnSetFilter.FillColor2 = Color.FromArgb(94, 148, 255);
            btnSetFilter.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSetFilter.ForeColor = Color.White;
            btnSetFilter.Location = new Point(586, 0);
            btnSetFilter.Name = "btnSetFilter";
            btnSetFilter.ShadowDecoration.BorderRadius = 30;
            btnSetFilter.ShadowDecoration.Depth = 5;
            btnSetFilter.ShadowDecoration.Enabled = true;
            btnSetFilter.Size = new Size(264, 99);
            btnSetFilter.TabIndex = 10;
            btnSetFilter.Text = "Фильтровать";
            btnSetFilter.Click += btnSetFilter_Click;
            // 
            // pnlDiagram
            // 
            pnlDiagram.Dock = DockStyle.Fill;
            pnlDiagram.Location = new Point(0, 99);
            pnlDiagram.Name = "pnlDiagram";
            pnlDiagram.Size = new Size(850, 518);
            pnlDiagram.TabIndex = 1;
            pnlDiagram.Paint += pnlDiagram_Paint;
            // 
            // UC_Statistics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Transparent;
            Controls.Add(pnlDiagram);
            Controls.Add(pnlFilters);
            Name = "UC_Statistics";
            Size = new Size(850, 617);
            Load += UC_Statistics_Load;
            pnlFilters.ResumeLayout(false);
            pnlFilters.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Siticone.Desktop.UI.WinForms.SiticonePanel pnlFilters;
        public Siticone.Desktop.UI.WinForms.SiticonePanel pnlDiagram;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnSetFilter;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dateTime2;
        private Label label2;
        private Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dateTime1;
    }
}
