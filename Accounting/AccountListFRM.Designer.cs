namespace Accounting
{
    partial class AccountListFRM
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
            this.AccountInsertbtn = new System.Windows.Forms.Button();
            this.AccountListGv = new System.Windows.Forms.DataGridView();
            this.UpdateSelector = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AccountListGv)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountInsertbtn
            // 
            this.AccountInsertbtn.Location = new System.Drawing.Point(279, 200);
            this.AccountInsertbtn.Name = "AccountInsertbtn";
            this.AccountInsertbtn.Size = new System.Drawing.Size(102, 39);
            this.AccountInsertbtn.TabIndex = 3;
            this.AccountInsertbtn.Text = "تعریف حساب";
            this.AccountInsertbtn.UseVisualStyleBackColor = true;
            this.AccountInsertbtn.Click += new System.EventHandler(this.AccountInsertbtn_Click);
            // 
            // AccountListGv
            // 
            this.AccountListGv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AccountListGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountListGv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UpdateSelector});
            this.AccountListGv.Location = new System.Drawing.Point(33, 12);
            this.AccountListGv.Name = "AccountListGv";
            this.AccountListGv.Size = new System.Drawing.Size(559, 172);
            this.AccountListGv.TabIndex = 2;
            this.AccountListGv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountListGv_CellClick);
            this.AccountListGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountListGv_CellContentClick);
            // 
            // UpdateSelector
            // 
            this.UpdateSelector.HeaderText = "ویرایش";
            this.UpdateSelector.Name = "UpdateSelector";
            this.UpdateSelector.Text = "ویرایش";
            this.UpdateSelector.UseColumnTextForButtonValue = true;
            // 
            // AccountListFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 260);
            this.Controls.Add(this.AccountInsertbtn);
            this.Controls.Add(this.AccountListGv);
            this.Name = "AccountListFRM";
            this.Text = "فرم تعریف حساب";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AccountListFRM_FormClosed);
            this.Load += new System.EventHandler(this.AccountListFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AccountListGv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AccountInsertbtn;
        private System.Windows.Forms.DataGridView AccountListGv;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateSelector;
    }
}