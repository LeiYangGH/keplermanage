using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 管理系统
{
    public partial class denglu : Form
    {
        public static string nuser, ncx;
        public denglu()
        {
            InitializeComponent();
        }
        private void label3_Click(object sender,EventArgs e)
        {

        }

        private void TextBox1_KeyDown(object sender,KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                TextBox2.Focus();
            }
        }


        private void TextBox2_KeyDown(object sender,KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }




        private void button2_Click(object sender,EventArgs e)
        {
            this.Close();  //关闭窗体
        }

        private void button1_Click(object sender,EventArgs e)
        {
            //定义变量
            string sql;
            //给sql赋值,查询用户表中是否有匹配用户名和密码
            sql = "select * from admin where Name='" + TextBox1.Text.ToString().Trim() + "'and Pwd='" + TextBox2.Text.ToString().Trim()+"'";
            DataSet result = new DataSet();   //定义变量result为数据集型
            result = new Class1().hsggetdata(sql);  //将查询到的结果放入数据集result中
            if(result!=null)
            {
                if(result.Tables[0].Rows.Count>0)  //如果查询结果不为空
                {
                    nuser = result.Tables[0].Rows[0]["Name"].ToString().Trim();  //给全局变量当前用户nuser赋值
                    ncx = result.Tables[0].Rows[0]["cx"].ToString().Trim();  //给全局变量当前权限ncx赋值
                    this.Hide();
                    HomePage newform = new HomePage();
                    newform.Show();
                }
                else
                {
                    //如果查询结果为空
                    MessageBox.Show("用户名或密码不正确");

                }

            }
            else
            {
                //出现异常,给出提示
                MessageBox.Show("数据库连接错误，请检查链接！");
            }
        }

        private void denglu_Load(object sender,EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
        }

    }
}
