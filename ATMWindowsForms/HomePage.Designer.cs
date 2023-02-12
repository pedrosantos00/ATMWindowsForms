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
            this.pictureBox1.Location = new System.Drawing.Point(2, 342);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // InitLabel
            // 
            this.InitLabel.AutoSize = true;
            this.InitLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InitLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InitLabel.Location = new System.Drawing.Point(164, 9);
            this.InitLabel.Name = "InitLabel";
            this.InitLabel.Size = new System.Drawing.Size(132, 24);
            this.InitLabel.TabIndex = 1;
            this.InitLabel.Text = "Olá, ******** !";
            // 
            // Deposit
            // 
            this.Deposit.Location = new System.Drawing.Point(23, 91);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(135, 74);
            this.Deposit.TabIndex = 5;
            this.Deposit.Text = "Depositar";
            this.Deposit.UseVisualStyleBackColor = true;
            this.Deposit.Click += new System.EventHandler(this.Deposit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(164, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "O que deseja fazer?";
            // 
            // Withdraw
            // 
            this.Withdraw.Location = new System.Drawing.Point(23, 182);
            this.Withdraw.Name = "Withdraw";
            this.Withdraw.Size = new System.Drawing.Size(135, 74);
            this.Withdraw.TabIndex = 7;
            this.Withdraw.Text = "Levantar";
            this.Withdraw.UseVisualStyleBackColor = true;
            this.Withdraw.Click += new System.EventHandler(this.Withdraw_Click);
            // 
            // Transfer
            // 
            this.Transfer.Location = new System.Drawing.Point(305, 182);
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(135, 74);
            this.Transfer.TabIndex = 8;
            this.Transfer.Text = "Transferir";
            this.Transfer.UseVisualStyleBackColor = true;
            this.Transfer.Click += new System.EventHandler(this.Transfer_Click);
            // 
            // Payments
            // 
            this.Payments.Location = new System.Drawing.Point(305, 91);
            this.Payments.Name = "Payments";
            this.Payments.Size = new System.Drawing.Size(135, 74);
            this.Payments.TabIndex = 9;
            this.Payments.Text = "Pagar";
            this.Payments.UseVisualStyleBackColor = true;
            this.Payments.Click += new System.EventHandler(this.Payments_Click);
            // 
            // Consult
            // 
            this.Consult.Location = new System.Drawing.Point(164, 182);
            this.Consult.Name = "Consult";
            this.Consult.Size = new System.Drawing.Size(135, 74);
            this.Consult.TabIndex = 10;
            this.Consult.Text = "Consultas";
            this.Consult.UseVisualStyleBackColor = true;
            this.Consult.Click += new System.EventHandler(this.Consult_Click);
            // 
            // Mbway
            // 
            this.Mbway.Location = new System.Drawing.Point(164, 262);
            this.Mbway.Name = "Mbway";
            this.Mbway.Size = new System.Drawing.Size(135, 74);
            this.Mbway.TabIndex = 11;
            this.Mbway.Text = "MB WAY";
            this.Mbway.UseVisualStyleBackColor = true;
            this.Mbway.Click += new System.EventHandler(this.Mbway_Click);
            // 
            // editUserData
            // 
            this.editUserData.Location = new System.Drawing.Point(164, 91);
            this.editUserData.Name = "editUserData";
            this.editUserData.Size = new System.Drawing.Size(135, 74);
            this.editUserData.TabIndex = 12;
            this.editUserData.Text = "Editar Dados  da Conta";
            this.editUserData.UseVisualStyleBackColor = true;
            this.editUserData.Click += new System.EventHandler(this.editUserData_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(377, 312);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(63, 24);
            this.logout.TabIndex = 13;
            this.logout.Text = "Sair";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 424);
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
            this.Name = "HomePage";
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