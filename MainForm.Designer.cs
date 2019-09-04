namespace 管理系统
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加管理员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.提单管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.提单系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.退出ToolStripMenuItem1,
            this.提单管理ToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(703, 25);
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem,
            this.系统用户管理ToolStripMenuItem});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.系统ToolStripMenuItem.Text = "系统维护管理";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 系统用户管理ToolStripMenuItem
            // 
            this.系统用户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加管理员ToolStripMenuItem,
            this.重新登录ToolStripMenuItem,
            this.修改密码ToolStripMenuItem});
            this.系统用户管理ToolStripMenuItem.Name = "系统用户管理ToolStripMenuItem";
            this.系统用户管理ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.系统用户管理ToolStripMenuItem.Text = "系统用户管理";
            // 
            // 添加管理员ToolStripMenuItem
            // 
            this.添加管理员ToolStripMenuItem.Name = "添加管理员ToolStripMenuItem";
            this.添加管理员ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.添加管理员ToolStripMenuItem.Text = "添加管理员";
            this.添加管理员ToolStripMenuItem.Click += new System.EventHandler(this.添加管理员ToolStripMenuItem_Click);
            // 
            // 重新登录ToolStripMenuItem
            // 
            this.重新登录ToolStripMenuItem.Name = "重新登录ToolStripMenuItem";
            this.重新登录ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.重新登录ToolStripMenuItem.Text = "重新登录";
            this.重新登录ToolStripMenuItem.Click += new System.EventHandler(this.重新登录ToolStripMenuItem_Click);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem1
            // 
            this.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
            this.退出ToolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.退出ToolStripMenuItem1.Text = "退出";
            this.退出ToolStripMenuItem1.Click += new System.EventHandler(this.退出ToolStripMenuItem1_Click);
            // 
            // 提单管理ToolStripMenuItem
            // 
            this.提单管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.提单系统ToolStripMenuItem});
            this.提单管理ToolStripMenuItem.Name = "提单管理ToolStripMenuItem";
            this.提单管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.提单管理ToolStripMenuItem.Text = "提单管理";
            // 
            // 提单系统ToolStripMenuItem
            // 
            this.提单系统ToolStripMenuItem.Name = "提单系统ToolStripMenuItem";
            this.提单系统ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.提单系统ToolStripMenuItem.Text = "提单系统";
            this.提单系统ToolStripMenuItem.Click += new System.EventHandler(this.提单系统ToolStripMenuItem_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(703, 487);
            this.Controls.Add(this.MenuStrip1);
            this.MainMenuStrip = this.MenuStrip1;
            this.Name = "HomePage";
            this.Text = "管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 系统用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加管理员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 提单管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 提单系统ToolStripMenuItem;
    }
}