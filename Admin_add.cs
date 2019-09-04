using System;
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
    public partial class Admin_add : Form
    {
        public Admin_add()
        {
            InitializeComponent();
        }

        private void Admin_add_Load(object sender,EventArgs e)
        {
            //判断是否有权限
            if (denglu.ncx.ToString().Trim() != "超级管理员")
            {
                MessageBox.Show("对不起，没有权限");
                this.Close();
            }
            string sql;
            //读取数据库中所有用户数据
            sql = "select*from admin order by id desc";
            DataSet result = new DataSet();
            result = new Class1().hsggetdata(sql);
            //绑定数据
            dataGridView1.DataSource = result.Tables[0];
            dataGridView1.Columns[0].HeaderCell.Value = "序号";
            dataGridView1.Columns[1].HeaderCell.Value = "用户名";
            dataGridView1.Columns[2].HeaderCell.Value = "密码";
            dataGridView1.Columns[3].HeaderCell.Value = "权限";


   
        }

        private void button1_Click(object sender,EventArgs e)
        {
            string sql;
            if(TextBox1.Text.ToString().Trim()==""||TextBox2.Text.ToString().Trim()=="")
            {
                MessageBox.Show("对不起，用户名和密码不能为空");
            }
            else
            {
                sql = "select*from admin where Name='" + TextBox1.Text.ToString().Trim() + "'";
                DataSet result = new DataSet();
                result = new Class1().hsggetdata(sql);
                if(result!=null)
                {
                    if(result.Tables[0].Rows.Count>0)
                    {
                        MessageBox.Show("对不起，该用户名已经存在，请更换用户名");

                    }
                    else
                    {
                        sql = "insert into admin(Name,Pwd) values('" + TextBox1.Text.ToString().Trim() + "','" + TextBox2.Text.ToString().Trim() + "')";
                        int dd = 0;
                        dd = new Class1().hsgexucute(sql);
                        if(dd==1)
                        {
                            //如插入成功，再次查询即可刷新
                            sql = "select*from admin order by id desc";
                            DataSet result2 = new DataSet();
                            result2 = new Class1().hsggetdata(sql);
                            dataGridView1.DataSource = result2.Tables[0];
                            MessageBox.Show("添加成功");
                        }
                        else
                        {
                            MessageBox.Show("对不起，系统错误");
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender,EventArgs e)
        {
            this.Close();  
        }

        private void button3_Click(object sender,EventArgs e)
        {
            string sql;
            if(dataGridView1.CurrentRow.Cells[3].Value.ToString().Trim()=="超级管理员")
            {
                MessageBox.Show("对不起，超级管理员不能删除");

            }
            else
            {
                sql = "delete from admin where id=" + dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
                int dd = 0;
                dd = new Class1().hsgexucute(sql);
                if(dd==1)
                {
                    sql = "select*from admin order by id desc";
                    DataSet result = new DataSet();
                    result = new Class1().hsggetdata(sql);
                    dataGridView1.DataSource = result.Tables[0];
                    MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("对不起，系统错误");
                }
            }
        }
    }
}
