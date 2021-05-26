namespace Accounting
{
    partial class AccountUpdateFRM
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.txtTarafHesab = new System.Windows.Forms.TextBox();
            this.btnaccountUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = ":نام حساب";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = ":نام طرف حساب";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(48, 110);
            this.txtAccountName.Multiline = true;
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(145, 34);
            this.txtAccountName.TabIndex = 7;
            // 
            // txtTarafHesab
            // 
            this.txtTarafHesab.Location = new System.Drawing.Point(48, 62);
            this.txtTarafHesab.Multiline = true;
            this.txtTarafHesab.Name = "txtTarafHesab";
            this.txtTarafHesab.Size = new System.Drawing.Size(145, 33);
            this.txtTarafHesab.TabIndex = 6;
            // 
            // btnaccountUpdate
            // 
            this.btnaccountUpdate.Location = new System.Drawing.Point(93, 169);
            this.btnaccountUpdate.Name = "btnaccountUpdate";
            this.btnaccountUpdate.Size = new System.Drawing.Size(75, 29);
            this.btnaccountUpdate.TabIndex = 5;
            this.btnaccountUpdate.Text = "ذخیره";
            this.btnaccountUpdate.UseVisualStyleBackColor = true;
            this.btnaccountUpdate.Click += new System.EventHandler(this.btnaccountUpdate_Click);
            // 
            // AccountUpdateFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.txtTarafHesab);
            this.Controls.Add(this.btnaccountUpdate);
            this.Name = "AccountUpdateFRM";
            this.Text = "فرم ویرایش حساب";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AccountUpdateFRM_FormClosed);
            this.Load += new System.EventHandler(this.AccountUpdateFRM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.TextBox txtTarafHesab;
        private System.Windows.Forms.Button btnaccountUpdate;
    }
}