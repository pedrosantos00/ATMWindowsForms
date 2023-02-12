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
            this.components = new System.ComponentModel.Container();
            this.balanceData = new System.Windows.Forms.Label();
            this.InitLabel = new System.Windows.Forms.Label();
            this.ConsultBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.transactionServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionServiceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionServiceBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // balanceData
            // 
            this.balanceData.AutoSize = true;
            this.balanceData.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.balanceData.ForeColor = System.Drawing.SystemColors.Control;
            this.balanceData.Location = new System.Drawing.Point(676, 13);
            this.balanceData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.balanceData.Name = "balanceData";
            this.balanceData.Size = new System.Drawing.Size(85, 19);
            this.balanceData.TabIndex = 0;
            this.balanceData.Text = "Balance : ";
            // 
            // InitLabel
            // 
            this.InitLabel.AutoSize = true;
            this.InitLabel.BackColor = System.Drawing.Color.Transparent;
            this.InitLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InitLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.InitLabel.Location = new System.Drawing.Point(13, 13);
            this.InitLabel.Name = "InitLabel";
            this.InitLabel.Size = new System.Drawing.Size(98, 19);
            this.InitLabel.TabIndex = 2;
            this.InitLabel.Text = "Olá, ******** !";
            // 
            // ConsultBtn
            // 
            this.ConsultBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ConsultBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConsultBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.ConsultBtn.Location = new System.Drawing.Point(793, 50);
            this.ConsultBtn.Name = "ConsultBtn";
            this.ConsultBtn.Size = new System.Drawing.Size(148, 26);
            this.ConsultBtn.TabIndex = 3;
            this.ConsultBtn.Text = "Consultar";
            this.ConsultBtn.UseVisualStyleBackColor = false;
            this.ConsultBtn.Click += new System.EventHandler(this.ConsultBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Consulta Ultimos Logins",
            "Consulta Ultimos Depósitos",
            "Consulta Ultimos Levantamentos",
            "Consulta Ultimas Transferencias",
            "Consulta Ultimas Transferencias MBWAY",
            "Consulta Ultimos Movimentos",
            "Consulta Todos"});
            this.comboBox1.Location = new System.Drawing.Point(13, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(748, 27);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Consultas...";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(13, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(928, 486);
            this.dataGridView1.TabIndex = 5;
            // 
            // transactionServiceBindingSource
            // 
            this.transactionServiceBindingSource.DataSource = typeof(ATM.Logic.TransactionService);
            // 
            // transactionServiceBindingSource1
            // 
            this.transactionServiceBindingSource1.DataSource = typeof(ATM.Logic.TransactionService);
            // 
            // Consult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(953, 583);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ConsultBtn);
            this.Controls.Add(this.InitLabel);
            this.Controls.Add(this.balanceData);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Consult";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Consult";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionServiceBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label balanceData;
        private Label InitLabel;
        private Button ConsultBtn;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private BindingSource transactionServiceBindingSource;
        private BindingSource transactionServiceBindingSource1;
    }
}