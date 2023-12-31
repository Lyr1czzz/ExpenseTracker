﻿namespace ExpenseTracker.Forms
{
    partial class NewPasswordForm : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPasswordForm));
            siticoneCustomGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            btnLogin = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            txtPassword2 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            txtPassword1 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            txtLogin = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneCustomGradientPanel2 = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(components);
            siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(components);
            linkLabel1 = new LinkLabel();
            siticoneCustomGradientPanel1.SuspendLayout();
            siticoneCustomGradientPanel2.SuspendLayout();
            siticonePanel1.SuspendLayout();
            SuspendLayout();
            // 
            // siticoneCustomGradientPanel1
            // 
            siticoneCustomGradientPanel1.BackColor = Color.Transparent;
            siticoneCustomGradientPanel1.BorderRadius = 30;
            siticoneCustomGradientPanel1.Controls.Add(linkLabel1);
            siticoneCustomGradientPanel1.Controls.Add(btnLogin);
            siticoneCustomGradientPanel1.Controls.Add(txtPassword2);
            siticoneCustomGradientPanel1.Controls.Add(txtPassword1);
            siticoneCustomGradientPanel1.Controls.Add(txtLogin);
            siticoneCustomGradientPanel1.Controls.Add(siticoneHtmlLabel1);
            siticoneCustomGradientPanel1.Location = new Point(276, 27);
            siticoneCustomGradientPanel1.Name = "siticoneCustomGradientPanel1";
            siticoneCustomGradientPanel1.ShadowDecoration.BorderRadius = 30;
            siticoneCustomGradientPanel1.ShadowDecoration.Depth = 5;
            siticoneCustomGradientPanel1.ShadowDecoration.Enabled = true;
            siticoneCustomGradientPanel1.Size = new Size(420, 487);
            siticoneCustomGradientPanel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BorderRadius = 30;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.FillColor2 = Color.FromArgb(94, 148, 255);
            btnLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(85, 340);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.BorderRadius = 30;
            btnLogin.ShadowDecoration.Depth = 5;
            btnLogin.ShadowDecoration.Enabled = true;
            btnLogin.Size = new Size(250, 87);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Восстановить";
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword2
            // 
            txtPassword2.BackColor = Color.Transparent;
            txtPassword2.BorderRadius = 20;
            txtPassword2.DefaultText = "";
            txtPassword2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword2.Location = new Point(85, 268);
            txtPassword2.Name = "txtPassword2";
            txtPassword2.PasswordChar = '●';
            txtPassword2.PlaceholderText = "new password";
            txtPassword2.SelectedText = "";
            txtPassword2.ShadowDecoration.BorderRadius = 20;
            txtPassword2.ShadowDecoration.Depth = 5;
            txtPassword2.ShadowDecoration.Enabled = true;
            txtPassword2.Size = new Size(250, 45);
            txtPassword2.TabIndex = 3;
            txtPassword2.UseSystemPasswordChar = true;
            // 
            // txtPassword1
            // 
            txtPassword1.BackColor = Color.Transparent;
            txtPassword1.BorderRadius = 20;
            txtPassword1.DefaultText = "";
            txtPassword1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword1.Location = new Point(85, 198);
            txtPassword1.Name = "txtPassword1";
            txtPassword1.PasswordChar = '●';
            txtPassword1.PlaceholderText = "new password";
            txtPassword1.SelectedText = "";
            txtPassword1.ShadowDecoration.BorderRadius = 20;
            txtPassword1.ShadowDecoration.Depth = 5;
            txtPassword1.ShadowDecoration.Enabled = true;
            txtPassword1.Size = new Size(250, 45);
            txtPassword1.TabIndex = 2;
            txtPassword1.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.Transparent;
            txtLogin.BorderRadius = 20;
            txtLogin.DefaultText = "";
            txtLogin.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtLogin.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtLogin.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtLogin.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtLogin.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogin.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLogin.Location = new Point(85, 131);
            txtLogin.Name = "txtLogin";
            txtLogin.PasswordChar = '\0';
            txtLogin.PlaceholderText = "login";
            txtLogin.SelectedText = "";
            txtLogin.ShadowDecoration.BorderRadius = 20;
            txtLogin.ShadowDecoration.Depth = 5;
            txtLogin.ShadowDecoration.Enabled = true;
            txtLogin.Size = new Size(250, 45);
            txtLogin.TabIndex = 1;
            // 
            // siticoneHtmlLabel1
            // 
            siticoneHtmlLabel1.BackColor = Color.Transparent;
            siticoneHtmlLabel1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel1.ForeColor = Color.FromArgb(28, 28, 28);
            siticoneHtmlLabel1.Location = new Point(79, 51);
            siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            siticoneHtmlLabel1.Size = new Size(254, 33);
            siticoneHtmlLabel1.TabIndex = 0;
            siticoneHtmlLabel1.Text = "Восстановление пароля";
            // 
            // siticoneCustomGradientPanel2
            // 
            siticoneCustomGradientPanel2.Controls.Add(siticoneCustomGradientPanel1);
            siticoneCustomGradientPanel2.Controls.Add(siticonePanel1);
            siticoneCustomGradientPanel2.Dock = DockStyle.Fill;
            siticoneCustomGradientPanel2.FillColor2 = Color.FromArgb(219, 233, 246);
            siticoneCustomGradientPanel2.FillColor3 = Color.FromArgb(219, 233, 246);
            siticoneCustomGradientPanel2.Location = new Point(0, 0);
            siticoneCustomGradientPanel2.Name = "siticoneCustomGradientPanel2";
            siticoneCustomGradientPanel2.Size = new Size(962, 553);
            siticoneCustomGradientPanel2.TabIndex = 1;
            // 
            // siticonePanel1
            // 
            siticonePanel1.BackColor = Color.Transparent;
            siticonePanel1.Controls.Add(siticoneControlBox2);
            siticonePanel1.Controls.Add(siticoneControlBox1);
            siticonePanel1.Dock = DockStyle.Fill;
            siticonePanel1.Location = new Point(0, 0);
            siticonePanel1.Name = "siticonePanel1";
            siticonePanel1.Size = new Size(962, 553);
            siticonePanel1.TabIndex = 5;
            // 
            // siticoneControlBox2
            // 
            siticoneControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            siticoneControlBox2.BackColor = Color.Transparent;
            siticoneControlBox2.BorderRadius = 15;
            siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            siticoneControlBox2.FillColor = Color.FromArgb(94, 148, 255);
            siticoneControlBox2.IconColor = Color.White;
            siticoneControlBox2.Location = new Point(872, 12);
            siticoneControlBox2.Name = "siticoneControlBox2";
            siticoneControlBox2.ShadowDecoration.BorderRadius = 20;
            siticoneControlBox2.ShadowDecoration.Depth = 5;
            siticoneControlBox2.ShadowDecoration.Enabled = true;
            siticoneControlBox2.Size = new Size(36, 36);
            siticoneControlBox2.TabIndex = 7;
            // 
            // siticoneControlBox1
            // 
            siticoneControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            siticoneControlBox1.BackColor = Color.Transparent;
            siticoneControlBox1.BorderRadius = 15;
            siticoneControlBox1.FillColor = Color.FromArgb(94, 148, 255);
            siticoneControlBox1.IconColor = Color.White;
            siticoneControlBox1.Location = new Point(914, 12);
            siticoneControlBox1.Name = "siticoneControlBox1";
            siticoneControlBox1.ShadowDecoration.BorderRadius = 20;
            siticoneControlBox1.ShadowDecoration.Depth = 5;
            siticoneControlBox1.ShadowDecoration.Enabled = true;
            siticoneControlBox1.Size = new Size(36, 36);
            siticoneControlBox1.TabIndex = 6;
            // 
            // siticoneBorderlessForm1
            // 
            siticoneBorderlessForm1.BorderRadius = 25;
            siticoneBorderlessForm1.ContainerControl = this;
            siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            siticoneBorderlessForm1.DragStartTransparencyValue = 1D;
            siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // siticoneDragControl1
            // 
            siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            siticoneDragControl1.DragStartTransparencyValue = 1D;
            siticoneDragControl1.TargetControl = siticonePanel1;
            siticoneDragControl1.UseTransparentDrag = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(28, 28, 28);
            linkLabel1.Location = new Point(185, 448);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(51, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Назад";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // NewPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 553);
            Controls.Add(siticoneCustomGradientPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NewPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExpenseTraker";
            FormClosing += NewPasswordForm_FormClosing;
            Load += LoginForm_Load;
            siticoneCustomGradientPanel1.ResumeLayout(false);
            siticoneCustomGradientPanel1.PerformLayout();
            siticoneCustomGradientPanel2.ResumeLayout(false);
            siticonePanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtPassword1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtLogin;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtPassword2;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnLogin;
        private LinkLabel linkLabel1;
    }
}