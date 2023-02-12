namespace ATMWindowsForms
{
    partial class Transfer
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
            this.label1 = new System.Windows.Forms.Label();
            this.idToTransfer = new System.Windows.Forms.TextBox();
            this.balanceInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TransferBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID da pessoa a transferir";
            // 
            // idToTransfer
            // 
            this.idToTransfer.Location = new System.Drawing.Point(187, 6);
            this.idToTransfer.Name = "idToTransfer";
            this.idToTransfer.Size = new System.Drawing.Size(44, 25);
            this.idToTransfer.TabIndex = 1;
            // 
            // balanceInput
            // 
            this.balanceInput.Location = new System.Drawing.Point(316, 6);
            this.balanceInput.Name = "balanceInput";
            this.balanceInput.Size = new System.Drawing.Size(145, 25);
            this.balanceInput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Montante:";
            // 
            // TransferBtn
            // 
            this.TransferBtn.Location = new System.Drawing.Point(467, 6);
            this.TransferBtn.Name = "TransferBtn";
            this.TransferBtn.Size = new System.Drawing.Size(118, 23);
            this.TransferBtn.TabIndex = 4;
            this.TransferBtn.Text = "Transferir";
            this.TransferBtn.UseVisualStyleBackColor = true;
            this.TransferBtn.Click += new System.EventHandler(this.TransferBtn_Click);
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 48);
            this.Controls.Add(this.TransferBtn);
            this.Controls.Add(this.balanceInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idToTransfer);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Transfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox idToTransfer;
        private TextBox balanceInput;
        private Label label2;
        private Button TransferBtn;
    }
}