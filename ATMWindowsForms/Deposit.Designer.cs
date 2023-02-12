namespace ATMWindowsForms
{
    partial class Deposit
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
            this.balanceInput = new System.Windows.Forms.TextBox();
            this.depo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quanto para depositar?";
            // 
            // balanceInput
            // 
            this.balanceInput.Location = new System.Drawing.Point(14, 40);
            this.balanceInput.Name = "balanceInput";
            this.balanceInput.Size = new System.Drawing.Size(136, 25);
            this.balanceInput.TabIndex = 1;
            // 
            // depo
            // 
            this.depo.Location = new System.Drawing.Point(156, 42);
            this.depo.Name = "depo";
            this.depo.Size = new System.Drawing.Size(102, 23);
            this.depo.TabIndex = 2;
            this.depo.Text = "Depositar";
            this.depo.UseVisualStyleBackColor = true;
            this.depo.Click += new System.EventHandler(this.depo_Click);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 92);
            this.Controls.Add(this.depo);
            this.Controls.Add(this.balanceInput);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Deposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox balanceInput;
        private Button depo;
    }
}