namespace ATMWindowsForms
{
    partial class HomePage
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InitLabel = new System.Windows.Forms.Label();
            this.Deposit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Withdraw = new System.Windows.Forms.Button();
            this.Transfer = new System.Windows.Forms.Button();
            this.Payments = new System.Windows.Forms.Button();
            this.Consult = new System.Windows.Forms.Button();
            this.Mbway = new System.Windows.Forms.Button();
            this.editUserData = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ATMWindowsForms.Properties.Resources.novobanco;
            this.pictureBox1.Location = new System.Drawing.Point(88, 352);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // InitLabel
            // 
            this.InitLabel.AutoSize = true;
            this.InitLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InitLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InitLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InitLabel.Location = new System.Drawing.Point(199, 9);
            this.InitLabel.Name = "InitLabel";
            this.InitLabel.Size = new System.Drawing.Size(132, 24);
            this.InitLabel.TabIndex = 1;
            this.InitLabel.Text = "Olá, ******** !";
            // 
            // Deposit
            // 
            this.Deposit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Deposit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Deposit.ForeColor = System.Drawing.Color.White;
            this.Deposit.Location = new System.Drawing.Point(12, 89);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(256, 46);
            this.Deposit.TabIndex = 5;
            this.Deposit.Text = "Depositar";
            this.Deposit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Deposit.UseVisualStyleBackColor = false;
            this.Deposit.Click += new System.EventHandler(this.Deposit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(199, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "O que deseja fazer?";
            // 
            // Withdraw
            // 
            this.Withdraw.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Withdraw.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Withdraw.ForeColor = System.Drawing.Color.White;
            this.Withdraw.Location = new System.Drawing.Point(12, 229);
            this.Withdraw.Name = "Withdraw";
            this.Withdraw.Size = new System.Drawing.Size(256, 46);
            this.Withdraw.TabIndex = 7;
            this.Withdraw.Text = "Levantar";
            this.Withdraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Withdraw.UseVisualStyleBackColor = false;
            this.Withdraw.Click += new System.EventHandler(this.Withdraw_Click);
            // 
            // Transfer
            // 
            this.Transfer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Transfer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Transfer.ForeColor = System.Drawing.Color.White;
            this.Transfer.Location = new System.Drawing.Point(12, 165);
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(256, 46);
            this.Transfer.TabIndex = 8;
            this.Transfer.Text = "Transferir";
            this.Transfer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Transfer.UseVisualStyleBackColor = false;
            this.Transfer.Click += new System.EventHandler(this.Transfer_Click);
            // 
            // Payments
            // 
            this.Payments.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Payments.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Payments.ForeColor = System.Drawing.Color.White;
            this.Payments.Location = new System.Drawing.Point(289, 165);
            this.Payments.Name = "Payments";
            this.Payments.Size = new System.Drawing.Size(249, 46);
            this.Payments.TabIndex = 9;
            this.Payments.Text = "Pagar";
            this.Payments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Payments.UseVisualStyleBackColor = false;
            this.Payments.Click += new System.EventHandler(this.Payments_Click);
            // 
            // Consult
            // 
            this.Consult.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Consult.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Consult.ForeColor = System.Drawing.Color.White;
            this.Consult.Location = new System.Drawing.Point(289, 89);
            this.Consult.Name = "Consult";
            this.Consult.Size = new System.Drawing.Size(249, 46);
            this.Consult.TabIndex = 10;
            this.Consult.Text = "Consultas";
            this.Consult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Consult.UseVisualStyleBackColor = false;
            this.Consult.Click += new System.EventHandler(this.Consult_Click);
            // 
            // Mbway
            // 
            this.Mbway.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Mbway.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Mbway.ForeColor = System.Drawing.Color.White;
            this.Mbway.Location = new System.Drawing.Point(12, 300);
            this.Mbway.Name = "Mbway";
            this.Mbway.Size = new System.Drawing.Size(256, 46);
            this.Mbway.TabIndex = 11;
            this.Mbway.Text = "MB WAY";
            this.Mbway.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Mbway.UseVisualStyleBackColor = false;
            this.Mbway.Click += new System.EventHandler(this.Mbway_Click);
            // 
            // editUserData
            // 
            this.editUserData.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editUserData.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editUserData.ForeColor = System.Drawing.Color.White;
            this.editUserData.Location = new System.Drawing.Point(289, 229);
            this.editUserData.Name = "editUserData";
            this.editUserData.Size = new System.Drawing.Size(249, 46);
            this.editUserData.TabIndex = 12;
            this.editUserData.Text = "Editar Dados  da Conta";
            this.editUserData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editUserData.UseVisualStyleBackColor = false;
            this.editUserData.Click += new System.EventHandler(this.editUserData_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logout.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(289, 300);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(249, 46);
            this.logout.TabIndex = 13;
            this.logout.Text = "Sair";
            this.logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(550, 420);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.editUserData);
            this.Controls.Add(this.Mbway);
            this.Controls.Add(this.Consult);
            this.Controls.Add(this.Payments);
            this.Controls.Add(this.Transfer);
            this.Controls.Add(this.Withdraw);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Deposit);
            this.Controls.Add(this.InitLabel);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "HomePage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label InitLabel;
        private Button Deposit;
        private Label label4;
        private Button Withdraw;
        private Button Transfer;
        private Button Payments;
        private Button Consult;
        private Button Mbway;
        private Button editUserData;
        private Button logout;
    }
}