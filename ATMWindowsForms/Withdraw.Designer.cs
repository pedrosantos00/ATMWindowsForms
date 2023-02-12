namespace ATMWindowsForms
{
    partial class Withdraw
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
            this.with = new System.Windows.Forms.Button();
            this.balanceInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // with
            // 
            this.with.Location = new System.Drawing.Point(156, 42);
            this.with.Name = "with";
            this.with.Size = new System.Drawing.Size(102, 23);
            this.with.TabIndex = 5;
            this.with.Text = "Levantar";
            this.with.UseVisualStyleBackColor = true;
            this.with.Click += new System.EventHandler(this.with_Click);
            // 
            // balanceInput
            // 
            this.balanceInput.Location = new System.Drawing.Point(14, 40);
            this.balanceInput.Name = "balanceInput";
            this.balanceInput.Size = new System.Drawing.Size(136, 23);
            this.balanceInput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quanto para levantar?";
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 83);
            this.Controls.Add(this.with);
            this.Controls.Add(this.balanceInput);
            this.Controls.Add(this.label1);
            this.Name = "Withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button with;
        private TextBox balanceInput;
        private Label label1;
    }
}