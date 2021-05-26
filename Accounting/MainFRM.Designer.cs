namespace Accounting
{
    partial class MainFRM
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DocumentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TarazMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.GozareshMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUser = new System.Windows.Forms.Label();
            this.lbllogin = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUser,
            this.AccountMenu,
            this.DocumentMenu,
            this.TarazMenu,
            this.GozareshMenu,
            this.ExitMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(808, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuUser
            // 
            this.MenuUser.Name = "MenuUser";
            this.MenuUser.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.MenuUser.Size = new System.Drawing.Size(98, 27);
            this.MenuUser.Text = "مدیریت کاربران";
            this.MenuUser.Click += new System.EventHandler(this.MenuUser_Click);
            // 
            // AccountMenu
            // 
            this.AccountMenu.Name = "AccountMenu";
            this.AccountMenu.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.AccountMenu.Size = new System.Drawing.Size(86, 27);
            this.AccountMenu.Text = "تعریف حساب";
            this.AccountMenu.Click += new System.EventHandler(this.AccountMenu_Click);
            // 
            // DocumentMenu
            // 
            this.DocumentMenu.Name = "DocumentMenu";
            this.DocumentMenu.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.DocumentMenu.Size = new System.Drawing.Size(139, 27);
            this.DocumentMenu.Text = "صدور سند و مانده حساب";
            this.DocumentMenu.Click += new System.EventHandler(this.DocumentMenu_Click);
            // 
            // TarazMenu
            // 
            this.TarazMenu.Name = "TarazMenu";
            this.TarazMenu.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.TarazMenu.Size = new System.Drawing.Size(106, 27);
            this.TarazMenu.Text = "تراز چهار ستونی";
            this.TarazMenu.Click += new System.EventHandler(this.TarazMenu_Click);
            // 
            // GozareshMenu
            // 
            this.GozareshMenu.Name = "GozareshMenu";
            this.GozareshMenu.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.GozareshMenu.Size = new System.Drawing.Size(114, 27);
            this.GozareshMenu.Text = "گزارش مانده حساب";
            this.GozareshMenu.Click += new System.EventHandler(this.GozareshMenu_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(44, 27);
            this.ExitMenuItem.Text = "خروج";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblUser.Location = new System.Drawing.Point(86, 9);
            this.lblUser.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(65, 13);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "کاربر گرامی";
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbllogin.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbllogin.Location = new System.Drawing.Point(36, 9);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(44, 13);
            this.lbllogin.TabIndex = 2;
            this.lbllogin.Text = "دادرسی";
            // 
            // MainFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Accounting.Properties.Resources.Basic_accounting_training;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(808, 291);
            this.Controls.Add(this.lbllogin);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFRM";
            this.Text = "صفحه اصلی";
            this.Load += new System.EventHandler(this.MainFRM_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuUser;
        private System.Windows.Forms.ToolStripMenuItem AccountMenu;
        private System.Windows.Forms.ToolStripMenuItem DocumentMenu;
        private System.Windows.Forms.ToolStripMenuItem TarazMenu;
        private System.Windows.Forms.ToolStripMenuItem GozareshMenu;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
    }
}