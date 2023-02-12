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
            this.SuspendLayout();
            // 
            // TransferBtn
            // 
            this.TransferBtn.Location = new System.Drawing.Point(467, 17);
            this.TransferBtn.Name = "TransferBtn";
            this.TransferBtn.Size = new System.Drawing.Size(118, 23);
            this.TransferBtn.TabIndex = 9;
            this.TransferBtn.Text = "Transferir";
            this.TransferBtn.UseVisualStyleBackColor = true;
            this.TransferBtn.Click += new System.EventHandler(this.TransferBtn_Click);
            // 
            // balanceInput
            // 
            this.balanceInput.Location = new System.Drawing.Point(316, 17);
            this.balanceInput.Name = "balanceInput";
            this.balanceInput.Size = new System.Drawing.Size(145, 25);
            this.balanceInput.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Montante:";
            // 
            // idToTransfer
            // 
            this.idToTransfer.Location = new System.Drawing.Point(99, 17);
            this.idToTransfer.Name = "idToTransfer";
            this.idToTransfer.Size = new System.Drawing.Size(132, 25);
            this.idToTransfer.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nº Telefone";
            // 
            // MBWay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 63);
            this.Controls.Add(this.TransferBtn);
            this.Controls.Add(this.balanceInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idToTransfer);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "MBWay";
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
    }
}