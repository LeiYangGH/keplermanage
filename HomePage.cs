﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 管理系统
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private void HomePage_Load(object sender,EventArgs e)
        {

        }
        
        private void 修改密码ToolStripMenuItem_Click(object sender,EventArgs e)
        {
            ModPwd newform = new ModPwd();
            newform.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender,EventArgs e)
        {
            Application.Exit();
        }

        private void 退出ToolStripMenuItem1_Click(object sender,EventArgs e)
        {
            Application.Exit();
        }

        private void 添加管理员ToolStripMenuItem_Click(object sender,EventArgs e)
        {
            Admin_add newform = new Admin_add();
            newform.Show();
        }

        private void 重新登录ToolStripMenuItem_Click(object sender,EventArgs e)
        {
            Application.Restart();
        }

        private void 提单系统ToolStripMenuItem_Click(object sender,EventArgs e)
        {
            TiDan newform = new TiDan();
            newform.Show();
        }






    }
}
