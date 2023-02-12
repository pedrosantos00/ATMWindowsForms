namespace ATMWindowsForms
{
    partial class Consult
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
            this.balanceData = new System.Windows.Forms.Label();
            this.InitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // balanceData
            // 
            this.balanceData.AutoSize = true;
            this.balanceData.Location = new System.Drawing.Point(13, 46);
            this.balanceData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.balanceData.Name = "balanceData";
            this.balanceData.Size = new System.Drawing.Size(77, 18);
            this.balanceData.TabIndex = 0;
            this.balanceData.Text = "Balance : ";
            // 
            // InitLabel
            // 
            this.InitLabel.AutoSize = true;
            this.InitLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InitLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InitLabel.Location = new System.Drawing.Point(13, 9);
            this.InitLabel.Name = "InitLabel";
            this.InitLabel.Size = new System.Drawing.Size(132, 24);
            this.InitLabel.TabIndex = 2;
            this.InitLabel.Text = "Olá, ******** !";
            // 
            // Consult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 299);
            this.Controls.Add(this.InitLabel);
            this.Controls.Add(this.balanceData);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Consult";
            this.Text = "Consult";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label balanceData;
        private Label InitLabel;
    }
}