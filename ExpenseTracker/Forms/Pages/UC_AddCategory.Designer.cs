namespace ExpenseTracker.Forms
{
    partial class UC_AddCategory
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
            siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            btnAddCategory = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            txtCategoryName = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            codeeloDateTimePicker1 = new CodeeloUI.Controls.CodeeloDateTimePicker();
            SuspendLayout();
            // 
            // siticoneHtmlLabel1
            // 
            siticoneHtmlLabel1.BackColor = Color.Transparent;
            siticoneHtmlLabel1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel1.Location = new Point(20, 20);
            siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            siticoneHtmlLabel1.Size = new Size(144, 33);
            siticoneHtmlLabel1.TabIndex = 1;
            siticoneHtmlLabel1.Text = "Add Category";
            // 
            // btnAddCategory
            // 
            btnAddCategory.BackColor = Color.Transparent;
            btnAddCategory.BorderRadius = 30;
            btnAddCategory.DisabledState.BorderColor = Color.DarkGray;
            btnAddCategory.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddCategory.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddCategory.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnAddCategory.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddCategory.FillColor2 = Color.FromArgb(94, 148, 255);
            btnAddCategory.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddCategory.ForeColor = Color.White;
            btnAddCategory.Location = new Point(300, 346);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.ShadowDecoration.BorderRadius = 30;
            btnAddCategory.ShadowDecoration.Depth = 5;
            btnAddCategory.ShadowDecoration.Enabled = true;
            btnAddCategory.Size = new Size(250, 87);
            btnAddCategory.TabIndex = 9;
            btnAddCategory.Text = "Создать";
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // siticoneHtmlLabel2
            // 
            siticoneHtmlLabel2.BackColor = Color.Transparent;
            siticoneHtmlLabel2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel2.Location = new Point(316, 182);
            siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            siticoneHtmlLabel2.Size = new Size(221, 33);
            siticoneHtmlLabel2.TabIndex = 8;
            siticoneHtmlLabel2.Text = "Добавить категорию";
            // 
            // txtCategoryName
            // 
            txtCategoryName.BackColor = Color.Transparent;
            txtCategoryName.BorderRadius = 20;
            txtCategoryName.DefaultText = "";
            txtCategoryName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCategoryName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCategoryName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCategoryName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCategoryName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCategoryName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategoryName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCategoryName.Location = new Point(300, 260);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.PasswordChar = '\0';
            txtCategoryName.PlaceholderText = "category name";
            txtCategoryName.SelectedText = "";
            txtCategoryName.ShadowDecoration.BorderRadius = 20;
            txtCategoryName.ShadowDecoration.Depth = 5;
            txtCategoryName.ShadowDecoration.Enabled = true;
            txtCategoryName.Size = new Size(250, 45);
            txtCategoryName.TabIndex = 7;
            // 
            // codeeloDateTimePicker1
            // 
            codeeloDateTimePicker1.BorderColor = Color.Black;
            codeeloDateTimePicker1.BorderSize = 1;
            codeeloDateTimePicker1.CalendarFont = null;
            codeeloDateTimePicker1.CalendarForeColor = Color.Empty;
            codeeloDateTimePicker1.CalendarMonthBackground = Color.Empty;
            codeeloDateTimePicker1.CalendarTitleBackColor = Color.Empty;
            codeeloDateTimePicker1.CalendarTitleForeColor = Color.Empty;
            codeeloDateTimePicker1.CalendarTrailingForeColor = Color.Empty;
            codeeloDateTimePicker1.Checked = false;
            codeeloDateTimePicker1.FillColor = Color.White;
            codeeloDateTimePicker1.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            codeeloDateTimePicker1.Location = new Point(339, 35);
            codeeloDateTimePicker1.MinimumSize = new Size(0, 35);
            codeeloDateTimePicker1.Name = "codeeloDateTimePicker1";
            codeeloDateTimePicker1.Size = new Size(250, 35);
            codeeloDateTimePicker1.TabIndex = 10;
            codeeloDateTimePicker1.TextColor = Color.Black;
            // 
            // UC_AddCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(codeeloDateTimePicker1);
            Controls.Add(btnAddCategory);
            Controls.Add(siticoneHtmlLabel2);
            Controls.Add(txtCategoryName);
            Controls.Add(siticoneHtmlLabel1);
            Name = "UC_AddCategory";
            Size = new Size(850, 617);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnAddCategory;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtCategoryName;
        private CodeeloUI.Controls.CodeeloDateTimePicker codeeloDateTimePicker1;
    }
}
