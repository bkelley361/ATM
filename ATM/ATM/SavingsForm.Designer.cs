
namespace ATM
{
    partial class SavingsForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_withdraw = new System.Windows.Forms.Button();
            this.btn_transfer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.btn_deposit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.customernumber = new System.Windows.Forms.Label();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(337, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Will deposit the amount of money entered";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Will withdraw the amount of money entered";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(436, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Transfers the amount entered from savings to checking\r\n";
            // 
            // btn_withdraw
            // 
            this.btn_withdraw.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_withdraw.Location = new System.Drawing.Point(82, 237);
            this.btn_withdraw.Name = "btn_withdraw";
            this.btn_withdraw.Size = new System.Drawing.Size(132, 54);
            this.btn_withdraw.TabIndex = 16;
            this.btn_withdraw.Text = "Withdraw";
            this.btn_withdraw.UseVisualStyleBackColor = true;
            this.btn_withdraw.Click += new System.EventHandler(this.btn_withdraw_Click);
            // 
            // btn_transfer
            // 
            this.btn_transfer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transfer.Location = new System.Drawing.Point(82, 348);
            this.btn_transfer.Name = "btn_transfer";
            this.btn_transfer.Size = new System.Drawing.Size(132, 54);
            this.btn_transfer.TabIndex = 15;
            this.btn_transfer.Text = "Transfer";
            this.btn_transfer.UseVisualStyleBackColor = true;
            this.btn_transfer.Click += new System.EventHandler(this.btn_transfer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(568, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enter the amount of money";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(572, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(196, 228);
            this.listBox1.TabIndex = 13;
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(624, 380);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(100, 22);
            this.txt_amount.TabIndex = 12;
            // 
            // btn_deposit
            // 
            this.btn_deposit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deposit.Location = new System.Drawing.Point(82, 127);
            this.btn_deposit.Name = "btn_deposit";
            this.btn_deposit.Size = new System.Drawing.Size(132, 54);
            this.btn_deposit.TabIndex = 11;
            this.btn_deposit.Text = "Deposit";
            this.btn_deposit.UseVisualStyleBackColor = true;
            this.btn_deposit.Click += new System.EventHandler(this.btn_deposit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 33);
            this.label5.TabIndex = 20;
            this.label5.Text = "Savings Account";
            // 
            // customernumber
            // 
            this.customernumber.AutoSize = true;
            this.customernumber.Location = new System.Drawing.Point(19, 46);
            this.customernumber.Name = "customernumber";
            this.customernumber.Size = new System.Drawing.Size(46, 17);
            this.customernumber.TabIndex = 21;
            this.customernumber.Text = "label6";
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoBack.Location = new System.Drawing.Point(658, 13);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(110, 50);
            this.btn_GoBack.TabIndex = 25;
            this.btn_GoBack.Text = "Back";
            this.btn_GoBack.UseVisualStyleBackColor = true;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // SavingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_GoBack);
            this.Controls.Add(this.customernumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_withdraw);
            this.Controls.Add(this.btn_transfer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.btn_deposit);
            this.Name = "SavingsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SavingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_withdraw;
        private System.Windows.Forms.Button btn_transfer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Button btn_deposit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label customernumber;
        private System.Windows.Forms.Button btn_GoBack;
    }
}