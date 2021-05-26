namespace Accounting
{
    partial class DocumentListFRM
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
            this.btnInsertDocument = new System.Windows.Forms.Button();
            this.DocumentListGv = new System.Windows.Forms.DataGridView();
            this.SelectorUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SelectorDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentListGv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertDocument
            // 
            this.btnInsertDocument.Location = new System.Drawing.Point(443, 329);
            this.btnInsertDocument.Name = "btnInsertDocument";
            this.btnInsertDocument.Size = new System.Drawing.Size(111, 39);
            this.btnInsertDocument.TabIndex = 0;
            this.btnInsertDocument.Text = "افزودن سند";
            this.btnInsertDocument.UseVisualStyleBackColor = true;
            this.btnInsertDocument.Click += new System.EventHandler(this.btnInsertDocument_Click);
            // 
            // DocumentListGv
            // 
            this.DocumentListGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DocumentListGv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectorUpdate,
            this.SelectorDelete});
            this.DocumentListGv.Location = new System.Drawing.Point(41, 12);
            this.DocumentListGv.Name = "DocumentListGv";
            this.DocumentListGv.Size = new System.Drawing.Size(900, 286);
            this.DocumentListGv.TabIndex = 1;
            this.DocumentListGv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DocumentListGv_CellClick);
            this.DocumentListGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DocumentListGv_CellContentClick);
            // 
            // SelectorUpdate
            // 
            this.SelectorUpdate.HeaderText = "ویرایش";
            this.SelectorUpdate.Name = "SelectorUpdate";
            this.SelectorUpdate.Text = "ویرایش";
            this.SelectorUpdate.UseColumnTextForButtonValue = true;
            // 
            // SelectorDelete
            // 
            this.SelectorDelete.HeaderText = "حذف";
            this.SelectorDelete.Name = "SelectorDelete";
            this.SelectorDelete.Text = "حذف";
            this.SelectorDelete.UseColumnTextForButtonValue = true;
            // 
            // DocumentListFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 417);
            this.Controls.Add(this.DocumentListGv);
            this.Controls.Add(this.btnInsertDocument);
            this.Name = "DocumentListFRM";
            this.Text = "فرم مدیریت سند";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DocumentListFRM_FormClosed);
            this.Load += new System.EventHandler(this.DocumentListFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DocumentListGv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertDocument;
        private System.Windows.Forms.DataGridView DocumentListGv;
        private System.Windows.Forms.DataGridViewButtonColumn SelectorUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn SelectorDelete;
    }
}