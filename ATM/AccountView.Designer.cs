
namespace ATM
{
    partial class AccountView
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
            this.btn_checking = new System.Windows.Forms.Button();
            this.btn_savings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_checking
            // 
            this.btn_checking.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checking.Location = new System.Drawing.Point(127, 91);
            this.btn_checking.Name = "btn_checking";
            this.btn_checking.Size = new System.Drawing.Size(139, 54);
            this.btn_checking.TabIndex = 0;
            this.btn_checking.Text = "Checking";
            this.btn_checking.UseVisualStyleBackColor = true;
            this.btn_checking.Click += new System.EventHandler(this.btn_checking_Click);
            // 
            // btn_savings
            // 
            this.btn_savings.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_savings.Location = new System.Drawing.Point(127, 297);
            this.btn_savings.Name = "btn_savings";
            this.btn_savings.Size = new System.Drawing.Size(139, 54);
            this.btn_savings.TabIndex = 1;
            this.btn_savings.Text = "Savings";
            this.btn_savings.UseVisualStyleBackColor = true;
            this.btn_savings.Click += new System.EventHandler(this.btn_savings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Click whether you want go to your checking or savings account.";
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Location = new System.Drawing.Point(13, 13);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(46, 17);
            this.CustomerLabel.TabIndex = 8;
            this.CustomerLabel.Text = "label2";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(410, 91);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(196, 260);
            this.listBox1.TabIndex = 9;
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.Location = new System.Drawing.Point(666, 13);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(122, 67);
            this.btn_LogOut.TabIndex = 10;
            this.btn_LogOut.Text = "Log Out";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // AccountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.CustomerLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_savings);
            this.Controls.Add(this.btn_checking);
            this.Name = "AccountView";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.AccountView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_checking;
        private System.Windows.Forms.Button btn_savings;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_LogOut;
    }
}