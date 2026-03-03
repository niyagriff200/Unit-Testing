namespace Unit_Testing
{
    partial class frmUnitTesting
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb_ConfirmPassword = new TextBox();
            tb_NewPassword = new TextBox();
            lbl_AgeTitle = new Label();
            lbl_NewPassword = new Label();
            lbl_ConfirmPassword = new Label();
            btn_AgeConfirm = new Button();
            btn_PasswordConfirm = new Button();
            num_AgeValue = new NumericUpDown();
            lbl_IsAdult = new Label();
            lbl_PasswordConfirmed = new Label();
            ((System.ComponentModel.ISupportInitialize)num_AgeValue).BeginInit();
            SuspendLayout();
            // 
            // tb_ConfirmPassword
            // 
            tb_ConfirmPassword.Location = new Point(460, 508);
            tb_ConfirmPassword.Name = "tb_ConfirmPassword";
            tb_ConfirmPassword.Size = new Size(250, 47);
            tb_ConfirmPassword.TabIndex = 1;
            // 
            // tb_NewPassword
            // 
            tb_NewPassword.Location = new Point(132, 508);
            tb_NewPassword.Name = "tb_NewPassword";
            tb_NewPassword.Size = new Size(250, 47);
            tb_NewPassword.TabIndex = 2;
            // 
            // lbl_AgeTitle
            // 
            lbl_AgeTitle.AutoSize = true;
            lbl_AgeTitle.Location = new Point(132, 94);
            lbl_AgeTitle.Name = "lbl_AgeTitle";
            lbl_AgeTitle.Size = new Size(257, 41);
            lbl_AgeTitle.TabIndex = 3;
            lbl_AgeTitle.Text = "What is Your Age?";
            // 
            // lbl_NewPassword
            // 
            lbl_NewPassword.AutoSize = true;
            lbl_NewPassword.Location = new Point(132, 431);
            lbl_NewPassword.Name = "lbl_NewPassword";
            lbl_NewPassword.Size = new Size(211, 41);
            lbl_NewPassword.TabIndex = 4;
            lbl_NewPassword.Text = "New Password";
            // 
            // lbl_ConfirmPassword
            // 
            lbl_ConfirmPassword.AutoSize = true;
            lbl_ConfirmPassword.Location = new Point(460, 431);
            lbl_ConfirmPassword.Name = "lbl_ConfirmPassword";
            lbl_ConfirmPassword.Size = new Size(257, 41);
            lbl_ConfirmPassword.TabIndex = 5;
            lbl_ConfirmPassword.Text = "Confirm Password";
            // 
            // btn_AgeConfirm
            // 
            btn_AgeConfirm.Location = new Point(411, 167);
            btn_AgeConfirm.Name = "btn_AgeConfirm";
            btn_AgeConfirm.Size = new Size(188, 58);
            btn_AgeConfirm.TabIndex = 6;
            btn_AgeConfirm.Text = "Confirm";
            btn_AgeConfirm.UseVisualStyleBackColor = true;
            btn_AgeConfirm.Click += btn_AgeConfirm_Click;
            // 
            // btn_PasswordConfirm
            // 
            btn_PasswordConfirm.Location = new Point(781, 502);
            btn_PasswordConfirm.Name = "btn_PasswordConfirm";
            btn_PasswordConfirm.Size = new Size(188, 58);
            btn_PasswordConfirm.TabIndex = 7;
            btn_PasswordConfirm.Text = "Confirm";
            btn_PasswordConfirm.UseVisualStyleBackColor = true;
            btn_PasswordConfirm.Click += btn_PasswordConfirm_Click;
            // 
            // num_AgeValue
            // 
            num_AgeValue.Location = new Point(89, 174);
            num_AgeValue.Name = "num_AgeValue";
            num_AgeValue.Size = new Size(300, 47);
            num_AgeValue.TabIndex = 8;
            // 
            // lbl_IsAdult
            // 
            lbl_IsAdult.AutoSize = true;
            lbl_IsAdult.Location = new Point(89, 280);
            lbl_IsAdult.Name = "lbl_IsAdult";
            lbl_IsAdult.Size = new Size(0, 41);
            lbl_IsAdult.TabIndex = 9;
            // 
            // lbl_PasswordConfirmed
            // 
            lbl_PasswordConfirmed.AutoSize = true;
            lbl_PasswordConfirmed.Location = new Point(132, 617);
            lbl_PasswordConfirmed.Name = "lbl_PasswordConfirmed";
            lbl_PasswordConfirmed.Size = new Size(0, 41);
            lbl_PasswordConfirmed.TabIndex = 10;
            // 
            // frmUnitTesting
            // 
            AccessibleRole = AccessibleRole.MenuBar;
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1326, 815);
            Controls.Add(lbl_PasswordConfirmed);
            Controls.Add(lbl_IsAdult);
            Controls.Add(num_AgeValue);
            Controls.Add(btn_PasswordConfirm);
            Controls.Add(btn_AgeConfirm);
            Controls.Add(lbl_ConfirmPassword);
            Controls.Add(lbl_NewPassword);
            Controls.Add(lbl_AgeTitle);
            Controls.Add(tb_NewPassword);
            Controls.Add(tb_ConfirmPassword);
            Name = "frmUnitTesting";
            Text = "Unit Testing Form";
            ((System.ComponentModel.ISupportInitialize)num_AgeValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tb_ConfirmPassword;
        private TextBox tb_NewPassword;
        private Label lbl_AgeTitle;
        private Label lbl_NewPassword;
        private Label lbl_ConfirmPassword;
        private Button btn_AgeConfirm;
        private Button btn_PasswordConfirm;
        private NumericUpDown num_AgeValue;
        private Label lbl_IsAdult;
        private Label lbl_PasswordConfirmed;
    }
}
