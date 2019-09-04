﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 管理系统
{
    public partial class frmModPwd : Form
    {
        public frmModPwd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //单击修改按钮时
        {
            if (TextBox1.Text.ToString().Trim() != "" && TextBox2.Text.ToString().Trim() != "" && TextBox3.Text.ToString().Trim() != "")  //如果三个文本都不为空
            {
                //查找当前用户
                string sql;
                sql = "select * from admin where Name='" + Login.nuser + "'";
                DataSet result = new DataSet();
                result = new SqlHelper().hsggetdata(sql);
                if (result != null)
                {
                    if (result.Tables[0].Rows.Count > 0)
                    {
                        //如果输入密码与数据库老密码相同
                        if (TextBox1.Text.ToString().Trim() == result.Tables[0].Rows[0]["Pwd"].ToString().Trim())
                        {
                            //执行修改操作
                            sql = "update admin set Pwd='" + TextBox2.Text.ToString().Trim() + "' where Name='" + Login.nuser + "'";
                            int dd = 0;
                            dd = new SqlHelper().hsgexucute(sql);
                            if (dd == 1)
                            {
                                //执行成功,给出提示
                                MessageBox.Show("修改成功");
                            }
                            else
                            {
                                MessageBox.Show("对不起，系统错误");
                            }
                        }
                        else
                        {
                            //如果输入密码与数据库老密码不相同
                            MessageBox.Show("对不起，密码不正确");
                        }
                    }
                    else
                    {
                        MessageBox.Show("系统错误，请勿越权操作");
                    }
                }
                else
                {
                    MessageBox.Show("数据库连接错误，请检查连接！");
                }
            }
            else
            {
                //如果没有填写完整,给出提示
                MessageBox.Show("请填写完整");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); //关闭本窗口
        }
    }
}