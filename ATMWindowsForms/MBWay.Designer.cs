namespace ATMWindowsForms
{
    partial class MBWay
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
            this.TransferBtn = new System.Windows.Forms.Button();
            this.balanceInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idToTransfer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TransferBtn
            // 
            this.TransferBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TransferBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TransferBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TransferBtn.Location = new System.Drawing.Point(647, 14);
            this.TransferBtn.Name = "TransferBtn";
            this.TransferBtn.Size = new System.Drawing.Size(146, 28);
            this.TransferBtn.TabIndex = 9;
            this.TransferBtn.Text = "Transferir";
            this.TransferBtn.UseVisualStyleBackColor = false;
            this.TransferBtn.Click += new System.EventHandler(this.TransferBtn_Click);
            // 
            // balanceInput
            // 
            this.balanceInput.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.balanceInput.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.balanceInput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.balanceInput.Location = new System.Drawing.Point(415, 17);
            this.balanceInput.Name = "balanceInput";
            this.balanceInput.Size = new System.Drawing.Size(145, 29);
            this.balanceInput.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(305, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Montante:";
            // 
            // idToTransfer
            // 
            this.idToTransfer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.idToTransfer.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.idToTransfer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.idToTransfer.Location = new System.Drawing.Point(130, 17);
            this.idToTransfer.Name = "idToTransfer";
            this.idToTransfer.Size = new System.Drawing.Size(169, 29);
            this.idToTransfer.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nº Telefone: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(566, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "EURO";
            // 
            // MBWay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(845, 63);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TransferBtn);
            this.Controls.Add(this.balanceInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idToTransfer);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MBWay";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MBWay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button TransferBtn;
        private TextBox balanceInput;
        private Label label2;
        private TextBox idToTransfer;
        private Label label1;
        private Label label3;
    }
}