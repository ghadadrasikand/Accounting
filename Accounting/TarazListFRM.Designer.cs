namespace Accounting
{
    partial class TarazListFRM
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
            this.btnInsertTaraz = new System.Windows.Forms.Button();
            this.TarazListGv = new System.Windows.Forms.DataGridView();
            this.SelectorUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SelectorDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TarazListGv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertTaraz
            // 
            this.btnInsertTaraz.Location = new System.Drawing.Point(283, 200);
            this.btnInsertTaraz.Name = "btnInsertTaraz";
            this.btnInsertTaraz.Size = new System.Drawing.Size(96, 38);
            this.btnInsertTaraz.TabIndex = 0;
            this.btnInsertTaraz.Text = "افزودن تراز";
            this.btnInsertTaraz.UseVisualStyleBackColor = true;
            this.btnInsertTaraz.Click += new System.EventHandler(this.btnInsertTaraz_Click);
            // 
            // TarazListGv
            // 
            this.TarazListGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TarazListGv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectorUpdate,
            this.SelectorDelete});
            this.TarazListGv.Location = new System.Drawing.Point(12, 12);
            this.TarazListGv.Name = "TarazListGv";
            this.TarazListGv.Size = new System.Drawing.Size(692, 166);
            this.TarazListGv.TabIndex = 1;
            this.TarazListGv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TarazListGv_CellClick);
            this.TarazListGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TarazListGv_CellContentClick);
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
            // TarazListFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(744, 280);
            this.Controls.Add(this.TarazListGv);
            this.Controls.Add(this.btnInsertTaraz);
            this.Name = "TarazListFRM";
            this.Text = "TarazListFRM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TarazListFRM_FormClosed);
            this.Load += new System.EventHandler(this.TarazListFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TarazListGv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertTaraz;
        private System.Windows.Forms.DataGridView TarazListGv;
        private System.Windows.Forms.DataGridViewButtonColumn SelectorUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn SelectorDelete;
    }
}