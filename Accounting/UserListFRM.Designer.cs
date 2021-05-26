namespace Accounting
{
    partial class UserListFRM
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
            this.UserInsertbtn = new System.Windows.Forms.Button();
            this.UserListGv = new System.Windows.Forms.DataGridView();
            this.UpdateSelector = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteSelector = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UserListGv)).BeginInit();
            this.SuspendLayout();
            // 
            // UserInsertbtn
            // 
            this.UserInsertbtn.Location = new System.Drawing.Point(225, 210);
            this.UserInsertbtn.Name = "UserInsertbtn";
            this.UserInsertbtn.Size = new System.Drawing.Size(102, 39);
            this.UserInsertbtn.TabIndex = 1;
            this.UserInsertbtn.Text = "افزودن کاربر";
            this.UserInsertbtn.UseVisualStyleBackColor = true;
            this.UserInsertbtn.Click += new System.EventHandler(this.UserInsertbtn_Click);
            // 
            // UserListGv
            // 
            this.UserListGv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserListGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserListGv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UpdateSelector,
            this.DeleteSelector});
            this.UserListGv.Location = new System.Drawing.Point(12, 12);
            this.UserListGv.Name = "UserListGv";
            this.UserListGv.Size = new System.Drawing.Size(559, 172);
            this.UserListGv.TabIndex = 0;
            this.UserListGv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserListGv_CellClick);
            this.UserListGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserListGv_CellContentClick);
            // 
            // UpdateSelector
            // 
            this.UpdateSelector.HeaderText = "ویرایش";
            this.UpdateSelector.Name = "UpdateSelector";
            this.UpdateSelector.Text = "ویرایش";
            this.UpdateSelector.UseColumnTextForButtonValue = true;
            // 
            // DeleteSelector
            // 
            this.DeleteSelector.HeaderText = "حذف";
            this.DeleteSelector.Name = "DeleteSelector";
            this.DeleteSelector.Text = "حذف";
            this.DeleteSelector.UseColumnTextForButtonValue = true;
            // 
            // UserListFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 279);
            this.Controls.Add(this.UserInsertbtn);
            this.Controls.Add(this.UserListGv);
            this.Name = "UserListFRM";
            this.Text = "فرم مدیریت کاربران";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserListFRM_FormClosed);
            this.Load += new System.EventHandler(this.UserListFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserListGv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button UserInsertbtn;
        private System.Windows.Forms.DataGridView UserListGv;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateSelector;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteSelector;
    }
}