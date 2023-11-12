namespace ExpenseTracker.Forms
{
    partial class UC_Category
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
            pnlNotes = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            siticoneCustomGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            btnDeleteCategory = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            btnCreate = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            txtPrice = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            txtText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneCustomGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlNotes
            // 
            pnlNotes.AutoScroll = true;
            pnlNotes.Dock = DockStyle.Fill;
            pnlNotes.FillColor = Color.Transparent;
            pnlNotes.FillColor2 = Color.Transparent;
            pnlNotes.FillColor3 = Color.Transparent;
            pnlNotes.FillColor4 = Color.Transparent;
            pnlNotes.Location = new Point(0, 0);
            pnlNotes.Name = "pnlNotes";
            pnlNotes.Size = new Size(466, 617);
            pnlNotes.TabIndex = 9;
            // 
            // siticoneCustomGradientPanel1
            // 
            siticoneCustomGradientPanel1.Controls.Add(btnDeleteCategory);
            siticoneCustomGradientPanel1.Controls.Add(btnCreate);
            siticoneCustomGradientPanel1.Controls.Add(siticoneHtmlLabel2);
            siticoneCustomGradientPanel1.Controls.Add(txtPrice);
            siticoneCustomGradientPanel1.Controls.Add(txtText);
            siticoneCustomGradientPanel1.Dock = DockStyle.Right;
            siticoneCustomGradientPanel1.FillColor = Color.Transparent;
            siticoneCustomGradientPanel1.FillColor2 = Color.Transparent;
            siticoneCustomGradientPanel1.FillColor3 = Color.Transparent;
            siticoneCustomGradientPanel1.FillColor4 = Color.Transparent;
            siticoneCustomGradientPanel1.Location = new Point(466, 0);
            siticoneCustomGradientPanel1.Name = "siticoneCustomGradientPanel1";
            siticoneCustomGradientPanel1.Size = new Size(384, 617);
            siticoneCustomGradientPanel1.TabIndex = 8;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.BackColor = Color.Transparent;
            btnDeleteCategory.BorderRadius = 30;
            btnDeleteCategory.DisabledState.BorderColor = Color.DarkGray;
            btnDeleteCategory.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDeleteCategory.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDeleteCategory.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnDeleteCategory.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDeleteCategory.FillColor2 = Color.FromArgb(94, 148, 255);
            btnDeleteCategory.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteCategory.ForeColor = Color.White;
            btnDeleteCategory.Location = new Point(67, 27);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.ShadowDecoration.BorderRadius = 30;
            btnDeleteCategory.ShadowDecoration.Depth = 5;
            btnDeleteCategory.ShadowDecoration.Enabled = true;
            btnDeleteCategory.Size = new Size(250, 61);
            btnDeleteCategory.TabIndex = 7;
            btnDeleteCategory.Text = "Удалить категорию";
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.Transparent;
            btnCreate.BorderRadius = 30;
            btnCreate.DisabledState.BorderColor = Color.DarkGray;
            btnCreate.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCreate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCreate.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnCreate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCreate.FillColor2 = Color.FromArgb(94, 148, 255);
            btnCreate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(67, 372);
            btnCreate.Name = "btnCreate";
            btnCreate.ShadowDecoration.BorderRadius = 30;
            btnCreate.ShadowDecoration.Depth = 5;
            btnCreate.ShadowDecoration.Enabled = true;
            btnCreate.Size = new Size(250, 87);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Добавить";
            btnCreate.Click += btnCreate_Click;
            // 
            // siticoneHtmlLabel2
            // 
            siticoneHtmlLabel2.BackColor = Color.Transparent;
            siticoneHtmlLabel2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel2.Location = new Point(102, 145);
            siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            siticoneHtmlLabel2.Size = new Size(180, 33);
            siticoneHtmlLabel2.TabIndex = 5;
            siticoneHtmlLabel2.Text = "Добавить запись";
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.Transparent;
            txtPrice.BorderRadius = 20;
            txtPrice.DefaultText = "";
            txtPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrice.Location = new Point(67, 286);
            txtPrice.Name = "txtPrice";
            txtPrice.PasswordChar = '\0';
            txtPrice.PlaceholderText = "price";
            txtPrice.SelectedText = "";
            txtPrice.ShadowDecoration.BorderRadius = 20;
            txtPrice.ShadowDecoration.Depth = 5;
            txtPrice.ShadowDecoration.Enabled = true;
            txtPrice.Size = new Size(250, 45);
            txtPrice.TabIndex = 1;
            // 
            // txtText
            // 
            txtText.BackColor = Color.Transparent;
            txtText.BorderRadius = 20;
            txtText.DefaultText = "";
            txtText.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtText.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtText.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtText.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtText.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtText.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtText.Location = new Point(67, 207);
            txtText.Name = "txtText";
            txtText.PasswordChar = '\0';
            txtText.PlaceholderText = "text";
            txtText.SelectedText = "";
            txtText.ShadowDecoration.BorderRadius = 20;
            txtText.ShadowDecoration.Depth = 5;
            txtText.ShadowDecoration.Enabled = true;
            txtText.Size = new Size(250, 45);
            txtText.TabIndex = 0;
            // 
            // UC_Category
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlNotes);
            Controls.Add(siticoneCustomGradientPanel1);
            Name = "UC_Category";
            Size = new Size(850, 617);
            siticoneCustomGradientPanel1.ResumeLayout(false);
            siticoneCustomGradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnCreate;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtPrice;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtText;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnDeleteCategory;
        public Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel pnlNotes;
    }
}
