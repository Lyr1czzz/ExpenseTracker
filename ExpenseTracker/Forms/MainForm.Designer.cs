namespace ExpenseTracker.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            siticoneShadowForm1 = new Siticone.Desktop.UI.WinForms.SiticoneShadowForm(components);
            pnlLeft = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            pnlCategory = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            pnlProfil = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            lblBalance = new Label();
            ComboCurrency = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(components);
            pnlHeader = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            btnExit = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            btnAddCategory = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            btnStatistics = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            btnAddBalance = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(components);
            pnlMain = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            siticoneControlBox3 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            pnlLeft.SuspendLayout();
            pnlProfil.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // siticoneShadowForm1
            // 
            siticoneShadowForm1.TargetForm = this;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.White;
            pnlLeft.Controls.Add(pnlCategory);
            pnlLeft.Controls.Add(pnlProfil);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.FillColor = Color.Gainsboro;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.ShadowDecoration.Depth = 5;
            pnlLeft.ShadowDecoration.Shadow = new Padding(3, 3, 5, 3);
            pnlLeft.Size = new Size(250, 759);
            pnlLeft.TabIndex = 0;
            // 
            // pnlCategory
            // 
            pnlCategory.AutoScroll = true;
            pnlCategory.BackColor = Color.Gainsboro;
            pnlCategory.BorderColor = Color.Transparent;
            pnlCategory.CustomBorderColor = Color.Transparent;
            pnlCategory.Dock = DockStyle.Fill;
            pnlCategory.FillColor = Color.White;
            pnlCategory.Location = new Point(0, 73);
            pnlCategory.Name = "pnlCategory";
            pnlCategory.Size = new Size(250, 686);
            pnlCategory.TabIndex = 1;
            // 
            // pnlProfil
            // 
            pnlProfil.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            pnlProfil.Controls.Add(lblBalance);
            pnlProfil.Controls.Add(ComboCurrency);
            pnlProfil.Dock = DockStyle.Top;
            pnlProfil.Location = new Point(0, 0);
            pnlProfil.Name = "pnlProfil";
            pnlProfil.Size = new Size(250, 73);
            pnlProfil.TabIndex = 0;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblBalance.Location = new Point(12, 25);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(108, 23);
            lblBalance.TabIndex = 0;
            lblBalance.Text = "your balance";
            // 
            // ComboCurrency
            // 
            ComboCurrency.BackColor = Color.Transparent;
            ComboCurrency.BorderRadius = 15;
            ComboCurrency.DrawMode = DrawMode.OwnerDrawFixed;
            ComboCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboCurrency.FocusedColor = Color.FromArgb(94, 148, 255);
            ComboCurrency.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            ComboCurrency.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ComboCurrency.ForeColor = Color.FromArgb(68, 88, 112);
            ComboCurrency.ItemHeight = 30;
            ComboCurrency.Items.AddRange(new object[] { "Ru", "Br", "Usd" });
            ComboCurrency.Location = new Point(147, 19);
            ComboCurrency.Name = "ComboCurrency";
            ComboCurrency.Size = new Size(83, 36);
            ComboCurrency.TabIndex = 10;
            ComboCurrency.SelectedIndexChanged += siticoneComboBox1_SelectedIndexChanged;
            // 
            // siticoneDragControl1
            // 
            siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            siticoneDragControl1.DragStartTransparencyValue = 1D;
            siticoneDragControl1.TargetControl = pnlHeader;
            siticoneDragControl1.UseTransparentDrag = true;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(siticoneControlBox3);
            pnlHeader.Controls.Add(btnExit);
            pnlHeader.Controls.Add(btnAddCategory);
            pnlHeader.Controls.Add(siticoneControlBox2);
            pnlHeader.Controls.Add(siticoneControlBox1);
            pnlHeader.Controls.Add(btnStatistics);
            pnlHeader.Controls.Add(btnAddBalance);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.FillColor = Color.White;
            pnlHeader.Location = new Point(250, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.ShadowDecoration.Depth = 5;
            pnlHeader.ShadowDecoration.Shadow = new Padding(3, 3, 3, 5);
            pnlHeader.Size = new Size(978, 73);
            pnlHeader.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.CheckedState.CustomBorderColor = Color.FromArgb(8, 83, 255);
            btnExit.CheckedState.FillColor = Color.White;
            btnExit.CustomBorderThickness = new Padding(0, 0, 0, 5);
            btnExit.DisabledState.BorderColor = Color.DarkGray;
            btnExit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExit.Dock = DockStyle.Left;
            btnExit.FillColor = Color.White;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = Color.FromArgb(28, 28, 28);
            btnExit.Location = new Point(603, 0);
            btnExit.Name = "btnExit";
            btnExit.PressedDepth = 0;
            btnExit.Size = new Size(126, 73);
            btnExit.TabIndex = 7;
            btnExit.Text = "Выйти";
            btnExit.Click += btnExit_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.CheckedState.CustomBorderColor = Color.FromArgb(8, 83, 255);
            btnAddCategory.CheckedState.FillColor = Color.White;
            btnAddCategory.CustomBorderThickness = new Padding(0, 0, 0, 5);
            btnAddCategory.DisabledState.BorderColor = Color.DarkGray;
            btnAddCategory.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddCategory.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddCategory.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddCategory.Dock = DockStyle.Left;
            btnAddCategory.FillColor = Color.White;
            btnAddCategory.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddCategory.ForeColor = Color.FromArgb(28, 28, 28);
            btnAddCategory.Location = new Point(402, 0);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.PressedDepth = 0;
            btnAddCategory.Size = new Size(201, 73);
            btnAddCategory.TabIndex = 6;
            btnAddCategory.Text = "Добавить категорию";
            // 
            // siticoneControlBox2
            // 
            siticoneControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            siticoneControlBox2.BackColor = Color.Transparent;
            siticoneControlBox2.BorderRadius = 15;
            siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MaximizeBox;
            siticoneControlBox2.FillColor = Color.FromArgb(94, 148, 255);
            siticoneControlBox2.IconColor = Color.White;
            siticoneControlBox2.Location = new Point(888, 12);
            siticoneControlBox2.Name = "siticoneControlBox2";
            siticoneControlBox2.ShadowDecoration.BorderRadius = 20;
            siticoneControlBox2.ShadowDecoration.Depth = 5;
            siticoneControlBox2.ShadowDecoration.Enabled = true;
            siticoneControlBox2.Size = new Size(36, 36);
            siticoneControlBox2.TabIndex = 5;
            // 
            // siticoneControlBox1
            // 
            siticoneControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            siticoneControlBox1.BackColor = Color.Transparent;
            siticoneControlBox1.BorderRadius = 15;
            siticoneControlBox1.FillColor = Color.FromArgb(94, 148, 255);
            siticoneControlBox1.IconColor = Color.White;
            siticoneControlBox1.Location = new Point(930, 12);
            siticoneControlBox1.Name = "siticoneControlBox1";
            siticoneControlBox1.ShadowDecoration.BorderRadius = 20;
            siticoneControlBox1.ShadowDecoration.Depth = 5;
            siticoneControlBox1.ShadowDecoration.Enabled = true;
            siticoneControlBox1.Size = new Size(36, 36);
            siticoneControlBox1.TabIndex = 4;
            // 
            // btnStatistics
            // 
            btnStatistics.CheckedState.CustomBorderColor = Color.FromArgb(8, 83, 255);
            btnStatistics.CheckedState.FillColor = Color.White;
            btnStatistics.CustomBorderThickness = new Padding(0, 0, 0, 5);
            btnStatistics.DisabledState.BorderColor = Color.DarkGray;
            btnStatistics.DisabledState.CustomBorderColor = Color.DarkGray;
            btnStatistics.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnStatistics.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnStatistics.Dock = DockStyle.Left;
            btnStatistics.FillColor = Color.White;
            btnStatistics.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnStatistics.ForeColor = Color.FromArgb(28, 28, 28);
            btnStatistics.Location = new Point(201, 0);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.PressedDepth = 0;
            btnStatistics.Size = new Size(201, 73);
            btnStatistics.TabIndex = 2;
            btnStatistics.Text = "Статистика";
            // 
            // btnAddBalance
            // 
            btnAddBalance.CheckedState.CustomBorderColor = Color.FromArgb(8, 83, 255);
            btnAddBalance.CheckedState.FillColor = Color.White;
            btnAddBalance.CustomBorderThickness = new Padding(0, 0, 0, 5);
            btnAddBalance.DisabledState.BorderColor = Color.DarkGray;
            btnAddBalance.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddBalance.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddBalance.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddBalance.Dock = DockStyle.Left;
            btnAddBalance.FillColor = Color.White;
            btnAddBalance.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddBalance.ForeColor = Color.FromArgb(28, 28, 28);
            btnAddBalance.Location = new Point(0, 0);
            btnAddBalance.Name = "btnAddBalance";
            btnAddBalance.PressedDepth = 0;
            btnAddBalance.Size = new Size(201, 73);
            btnAddBalance.TabIndex = 1;
            btnAddBalance.Text = "Пополнить баланс";
            // 
            // siticoneBorderlessForm1
            // 
            siticoneBorderlessForm1.BorderRadius = 25;
            siticoneBorderlessForm1.ContainerControl = this;
            siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.Gainsboro;
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(250, 73);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(978, 686);
            pnlMain.TabIndex = 2;
            // 
            // siticoneControlBox3
            // 
            siticoneControlBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            siticoneControlBox3.BackColor = Color.Transparent;
            siticoneControlBox3.BorderRadius = 15;
            siticoneControlBox3.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            siticoneControlBox3.FillColor = Color.FromArgb(94, 148, 255);
            siticoneControlBox3.IconColor = Color.White;
            siticoneControlBox3.Location = new Point(846, 12);
            siticoneControlBox3.Name = "siticoneControlBox3";
            siticoneControlBox3.ShadowDecoration.BorderRadius = 20;
            siticoneControlBox3.ShadowDecoration.Depth = 5;
            siticoneControlBox3.ShadowDecoration.Enabled = true;
            siticoneControlBox3.Size = new Size(36, 36);
            siticoneControlBox3.TabIndex = 8;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 759);
            Controls.Add(pnlMain);
            Controls.Add(pnlHeader);
            Controls.Add(pnlLeft);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ExpenseTraker";
            FormClosing += MainForm_FormClosing;
            pnlLeft.ResumeLayout(false);
            pnlProfil.ResumeLayout(false);
            pnlProfil.PerformLayout();
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public Siticone.Desktop.UI.WinForms.SiticoneShadowForm siticoneShadowForm1;
        public Siticone.Desktop.UI.WinForms.SiticonePanel pnlLeft;
        public Siticone.Desktop.UI.WinForms.SiticonePanel pnlProfil;
        public Siticone.Desktop.UI.WinForms.SiticonePanel pnlCategory;
        public Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        public Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        public Label lblBalance;
        public Siticone.Desktop.UI.WinForms.SiticonePanel pnlHeader;
        public Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        public Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        public Siticone.Desktop.UI.WinForms.SiticoneButton btnStatistics;
        public Siticone.Desktop.UI.WinForms.SiticonePanel pnlMain;
        public Siticone.Desktop.UI.WinForms.SiticoneButton btnAddBalance;
        public Siticone.Desktop.UI.WinForms.SiticoneComboBox ComboCurrency;
        public Siticone.Desktop.UI.WinForms.SiticoneButton btnAddCategory;
        public Siticone.Desktop.UI.WinForms.SiticoneButton btnExit;
        public Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox3;
    }
}