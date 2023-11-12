namespace ExpenseTracker.Forms
{
    partial class UC_AddBalance
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
            siticoneCustomGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            btnAddBalance = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            txtPrice = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneCustomGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // siticoneHtmlLabel1
            // 
            siticoneHtmlLabel1.BackColor = Color.Transparent;
            siticoneHtmlLabel1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel1.Location = new Point(23, 18);
            siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            siticoneHtmlLabel1.Size = new Size(131, 33);
            siticoneHtmlLabel1.TabIndex = 4;
            siticoneHtmlLabel1.Text = "Add Balance";
            // 
            // siticoneCustomGradientPanel1
            // 
            siticoneCustomGradientPanel1.Controls.Add(siticoneHtmlLabel1);
            siticoneCustomGradientPanel1.Controls.Add(btnAddBalance);
            siticoneCustomGradientPanel1.Controls.Add(siticoneHtmlLabel2);
            siticoneCustomGradientPanel1.Controls.Add(txtPrice);
            siticoneCustomGradientPanel1.Dock = DockStyle.Fill;
            siticoneCustomGradientPanel1.FillColor = Color.Transparent;
            siticoneCustomGradientPanel1.FillColor2 = Color.Transparent;
            siticoneCustomGradientPanel1.FillColor3 = Color.Transparent;
            siticoneCustomGradientPanel1.FillColor4 = Color.Transparent;
            siticoneCustomGradientPanel1.Location = new Point(0, 0);
            siticoneCustomGradientPanel1.Name = "siticoneCustomGradientPanel1";
            siticoneCustomGradientPanel1.Size = new Size(850, 617);
            siticoneCustomGradientPanel1.TabIndex = 5;
            // 
            // btnAddBalance
            // 
            btnAddBalance.BackColor = Color.Transparent;
            btnAddBalance.BorderRadius = 30;
            btnAddBalance.DisabledState.BorderColor = Color.DarkGray;
            btnAddBalance.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddBalance.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddBalance.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnAddBalance.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddBalance.FillColor2 = Color.FromArgb(94, 148, 255);
            btnAddBalance.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddBalance.ForeColor = Color.White;
            btnAddBalance.Location = new Point(298, 319);
            btnAddBalance.Name = "btnAddBalance";
            btnAddBalance.ShadowDecoration.BorderRadius = 30;
            btnAddBalance.ShadowDecoration.Depth = 5;
            btnAddBalance.ShadowDecoration.Enabled = true;
            btnAddBalance.Size = new Size(250, 87);
            btnAddBalance.TabIndex = 6;
            btnAddBalance.Text = "Пололнить";
            btnAddBalance.Click += btnAddBalance_Click;
            // 
            // siticoneHtmlLabel2
            // 
            siticoneHtmlLabel2.BackColor = Color.Transparent;
            siticoneHtmlLabel2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel2.Location = new Point(329, 157);
            siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            siticoneHtmlLabel2.Size = new Size(196, 33);
            siticoneHtmlLabel2.TabIndex = 5;
            siticoneHtmlLabel2.Text = "Пополнить баланс";
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
            txtPrice.Location = new Point(298, 233);
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
            // UC_AddBalance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(siticoneCustomGradientPanel1);
            Name = "UC_AddBalance";
            Size = new Size(850, 617);
            siticoneCustomGradientPanel1.ResumeLayout(false);
            siticoneCustomGradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtPrice;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtText;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel2;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel3;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnAddBalance;
    }
}
