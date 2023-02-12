namespace ATMWindowsForms
{
    partial class ATMLogin
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
            this.LoginBtn = new System.Windows.Forms.Button();
            this.idInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.LoginBtn.Location = new System.Drawing.Point(257, 224);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(91, 41);
            this.LoginBtn.TabIndex = 1;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // idInput
            // 
            this.idInput.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.idInput.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.idInput.ForeColor = System.Drawing.Color.White;
            this.idInput.Location = new System.Drawing.Point(3, 230);
            this.idInput.Name = "idInput";
            this.idInput.PlaceholderText = "ID";
            this.idInput.Size = new System.Drawing.Size(85, 29);
            this.idInput.TabIndex = 3;
            // 
            // passwordInput
            // 
            this.passwordInput.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.passwordInput.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordInput.ForeColor = System.Drawing.Color.White;
            this.passwordInput.Location = new System.Drawing.Point(94, 230);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PlaceholderText = "PASSWORD";
            this.passwordInput.Size = new System.Drawing.Size(146, 29);
            this.passwordInput.TabIndex = 5;
            this.passwordInput.UseSystemPasswordChar = true;
            this.passwordInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ATMLogin_KeyPress);
            // 
            // ATMLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATMWindowsForms.Properties.Resources.ecrans_atm_1_700x260;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(349, 264);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.idInput);
            this.Controls.Add(this.LoginBtn);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ATMLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATMLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button LoginBtn;
        private TextBox idInput;
        private TextBox passwordInput;
    }
}