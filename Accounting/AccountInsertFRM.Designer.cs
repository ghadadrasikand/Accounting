namespace Accounting
{
    partial class AccountInsertFRM
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
            this.btnaccountinsert = new System.Windows.Forms.Button();
            this.txtTarafHesab = new System.Windows.Forms.TextBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnaccountinsert
            // 
            this.btnaccountinsert.Location = new System.Drawing.Point(96, 140);
            this.btnaccountinsert.Name = "btnaccountinsert";
            this.btnaccountinsert.Size = new System.Drawing.Size(75, 29);
            this.btnaccountinsert.TabIndex = 0;
            this.btnaccountinsert.Text = "ثبت";
            this.btnaccountinsert.UseVisualStyleBackColor = true;
            this.btnaccountinsert.Click += new System.EventHandler(this.btnaccountinsert_Click);
            // 
            // txtTarafHesab
            // 
            this.txtTarafHesab.Location = new System.Drawing.Point(51, 33);
            this.txtTarafHesab.Multiline = true;
            this.txtTarafHesab.Name = "txtTarafHesab";
            this.txtTarafHesab.Size = new System.Drawing.Size(145, 33);
            this.txtTarafHesab.TabIndex = 1;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(51, 81);
            this.txtAccountName.Multiline = true;
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(145, 34);
            this.txtAccountName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = ":نام طرف حساب";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = ":نام حساب";
            // 
            // AccountInsertFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 254);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.txtTarafHesab);
            this.Controls.Add(this.btnaccountinsert);
            this.Name = "AccountInsertFRM";
            this.Text = "صدور حساب";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AccountInsertFRM_FormClosed);
            this.Load += new System.EventHandler(this.AccountInsertFRM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaccountinsert;
        private System.Windows.Forms.TextBox txtTarafHesab;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}