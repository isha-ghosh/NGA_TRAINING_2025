namespace BankAccountsApp
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.OwnerTxt = new System.Windows.Forms.TextBox();
            this.BankAccountGrid = new System.Windows.Forms.DataGridView();
            this.CreateAccountBtn = new System.Windows.Forms.Button();
            this.DepositBtn = new System.Windows.Forms.Button();
            this.WithdrawBtn = new System.Windows.Forms.Button();
            this.AmountNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.BankAccountGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Owner";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            this.label2.Click += new System.EventHandler(this.Amount_Click);
            // 
            // OwnerTxt
            // 
            this.OwnerTxt.Location = new System.Drawing.Point(135, 58);
            this.OwnerTxt.Multiline = true;
            this.OwnerTxt.Name = "OwnerTxt";
            this.OwnerTxt.Size = new System.Drawing.Size(124, 23);
            this.OwnerTxt.TabIndex = 2;
            this.OwnerTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BankAccountGrid
            // 
            this.BankAccountGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BankAccountGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BankAccountGrid.Location = new System.Drawing.Point(312, 57);
            this.BankAccountGrid.Name = "BankAccountGrid";
            this.BankAccountGrid.RowHeadersWidth = 51;
            this.BankAccountGrid.RowTemplate.Height = 24;
            this.BankAccountGrid.Size = new System.Drawing.Size(505, 233);
            this.BankAccountGrid.TabIndex = 4;
            // 
            // CreateAccountBtn
            // 
            this.CreateAccountBtn.Location = new System.Drawing.Point(122, 103);
            this.CreateAccountBtn.Name = "CreateAccountBtn";
            this.CreateAccountBtn.Size = new System.Drawing.Size(126, 30);
            this.CreateAccountBtn.TabIndex = 5;
            this.CreateAccountBtn.Text = "Create Account";
            this.CreateAccountBtn.UseVisualStyleBackColor = true;
            // 
            // DepositBtn
            // 
            this.DepositBtn.Location = new System.Drawing.Point(391, 310);
            this.DepositBtn.Name = "DepositBtn";
            this.DepositBtn.Size = new System.Drawing.Size(96, 30);
            this.DepositBtn.TabIndex = 6;
            this.DepositBtn.Text = "Deposit";
            this.DepositBtn.UseVisualStyleBackColor = true;
            // 
            // WithdrawBtn
            // 
            this.WithdrawBtn.Location = new System.Drawing.Point(648, 310);
            this.WithdrawBtn.Name = "WithdrawBtn";
            this.WithdrawBtn.Size = new System.Drawing.Size(96, 30);
            this.WithdrawBtn.TabIndex = 7;
            this.WithdrawBtn.Text = "Withdraw";
            this.WithdrawBtn.UseVisualStyleBackColor = true;
            // 
            // AmountNum
            // 
            this.AmountNum.Location = new System.Drawing.Point(142, 253);
            this.AmountNum.Name = "AmountNum";
            this.AmountNum.Size = new System.Drawing.Size(117, 22);
            this.AmountNum.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 362);
            this.Controls.Add(this.AmountNum);
            this.Controls.Add(this.WithdrawBtn);
            this.Controls.Add(this.DepositBtn);
            this.Controls.Add(this.CreateAccountBtn);
            this.Controls.Add(this.BankAccountGrid);
            this.Controls.Add(this.OwnerTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BankAccountGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OwnerTxt;
        private System.Windows.Forms.DataGridView BankAccountGrid;
        private System.Windows.Forms.Button CreateAccountBtn;
        private System.Windows.Forms.Button DepositBtn;
        private System.Windows.Forms.Button WithdrawBtn;
        private System.Windows.Forms.NumericUpDown AmountNum;
    }
}

