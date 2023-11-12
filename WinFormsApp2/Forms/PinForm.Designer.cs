namespace ExpenseTracker.Forms
{
    partial class PinForm
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
            siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(components);
            txtPincode = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            label1 = new Label();
            siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            siticoneBorderlessForm1.BorderRadius = 25;
            siticoneBorderlessForm1.ContainerControl = this;
            siticoneBorderlessForm1.DockIndicatorTransparencyValue = 1D;
            siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // txtPincode
            // 
            txtPincode.BorderRadius = 20;
            txtPincode.DefaultText = "";
            txtPincode.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPincode.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPincode.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPincode.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPincode.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPincode.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPincode.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPincode.Location = new Point(67, 93);
            txtPincode.Name = "txtPincode";
            txtPincode.PasswordChar = '\0';
            txtPincode.PlaceholderText = "";
            txtPincode.SelectedText = "";
            txtPincode.Size = new Size(250, 45);
            txtPincode.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(131, 38);
            label1.Name = "label1";
            label1.Size = new Size(125, 41);
            label1.TabIndex = 1;
            label1.Text = "Pincode";
            // 
            // siticoneButton1
            // 
            siticoneButton1.BorderRadius = 25;
            siticoneButton1.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton1.ForeColor = Color.White;
            siticoneButton1.Location = new Point(79, 174);
            siticoneButton1.Name = "siticoneButton1";
            siticoneButton1.Size = new Size(225, 56);
            siticoneButton1.TabIndex = 2;
            siticoneButton1.Text = "Восстановить";
            siticoneButton1.Click += siticoneButton1_Click;
            // 
            // siticoneControlBox1
            // 
            siticoneControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            siticoneControlBox1.BackColor = Color.Transparent;
            siticoneControlBox1.BorderRadius = 15;
            siticoneControlBox1.FillColor = Color.FromArgb(94, 148, 255);
            siticoneControlBox1.IconColor = Color.White;
            siticoneControlBox1.Location = new Point(338, 12);
            siticoneControlBox1.Name = "siticoneControlBox1";
            siticoneControlBox1.ShadowDecoration.BorderRadius = 20;
            siticoneControlBox1.ShadowDecoration.Depth = 5;
            siticoneControlBox1.ShadowDecoration.Enabled = true;
            siticoneControlBox1.Size = new Size(36, 36);
            siticoneControlBox1.TabIndex = 7;
            // 
            // PinForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 268);
            Controls.Add(siticoneControlBox1);
            Controls.Add(siticoneButton1);
            Controls.Add(label1);
            Controls.Add(txtPincode);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PinForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PinForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtPincode;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
    }
}