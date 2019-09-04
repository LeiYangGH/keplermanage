using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 管理系统
{
    public partial class TiDan : Form
    {
        public TiDan()
        {
            InitializeComponent();
        }

        public void TiDan_Load(object sender,EventArgs e)
        {
            string sql;
            sql = "select*from TiDan";
            DataSet result = new DataSet();
            result = new Class1().hsggetdata(sql);
            this.tiDanTableAdapter.Fill(this.管理系统DataSet.TiDan);
        }

        private void ControlStatus()
        {
            this.CPH1.Text = "";
            this.LSH1.Text = "";
            this.QFH1.Text = "";
            this.TDH1.Text = "";
            this.YFL1.Text = "";
            this.SFL1.Text = "";
            this.CZY1.Text = "";
            this.HTH1.Text = "";
            this.CPGH1.Text = "";
            this.PCH1.Text = "";
            this.HWH1.Text ="";
            this.PZ1.Text = "";
            this.MZ1.Text = "";
            this.JZ1.Text = "";
            this.WLMC1.Text ="";
            this.HC1.Text = "";
            this.FHDW.Text = "";
            this.SHDW1.Text = "";
            this.LX1.Text = "";
            this.KSSJ1.Value = Convert.ToDateTime("2019-01-01");
            this.JSSJ1.Value = Convert.ToDateTime("2019-01-01");
            this.BZ1.Text = "";
        }
        

        private void FillControls()
        {
            this.FHFS1.SelectedValue = this.JiLu[0, this.JiLu.CurrentCell.RowIndex].Value;
            this.CPH1.Text = this.JiLu[1, this.JiLu.CurrentCell.RowIndex].Value.ToString();
            this.LSH1.Text = this.JiLu[2, this.JiLu.CurrentCell.RowIndex].Value.ToString();
            this.QFH1.Text = this.JiLu[3, this.JiLu.CurrentCell.RowIndex].Value.ToString();
            this.TDH1.Text = this.JiLu[4, this.JiLu.CurrentCell.RowIndex].Value.ToString();
            this.YFL1.Text = this.JiLu[5, this.JiLu.CurrentCell.RowIndex].Value.ToString();
            this.SFL1.Text = this.JiLu[6, this.JiLu.CurrentCell.RowIndex].Value.ToString();
            this.CZY1.Text = this.JiLu[7, this.JiLu.CurrentCell.RowIndex].Value.ToString();
            this.HTH1.Text = this.JiLu[8, this.JiLu.CurrentCell.RowIndex].Value.ToString();
            this.CPGH1.Text = this.JiLu[9, this.JiLu.CurrentCell.RowIndex].Value.ToString();
            this.PCH1.Text = this.JiLu[10, this.JiLu.CurrentCell.RowIndex].Value.ToString();
            this.HWH1.Text = this.JiLu[11, this.JiLu.CurrentCell.RowIndex].Value.ToString();
            this.PZ1.Text = this.JiLu[12, this.JiLu.CurrentCell.RowIndex].Value.ToString();
            this.MZ1.Text = this.JiLu[13, this.JiLu.CurrentCell.RowIndex].Value.ToString();
            this.JZ1.Text = this.JiLu[14, this.JiLu.CurrentCell.RowIndex].Value.ToString();
            this.WLMC1.Text = this.JiLu[15, this.JiLu.CurrentCell.RowIndex].Value.ToString();
            this.HC1.Text = this.JiLu[16, this.JiLu.CurrentCell.RowIndex].Value.ToString();
            this.FHDW1.Text= this.JiLu[17, this.JiLu.CurrentCell.RowIndex].Value.ToString();
            this.SHDW1.Text = this.JiLu[18, this.JiLu.CurrentCell.RowIndex].Value.ToString();
            this.LX1.Text = this.JiLu[19, this.JiLu.CurrentCell.RowIndex].Value.ToString();
            this.KSSJ1.Value = Convert.ToDateTime(this.JiLu[20, this.JiLu.CurrentCell.RowIndex].Value);
            this.JSSJ1.Value = Convert.ToDateTime(this.JiLu[21, this.JiLu.CurrentCell.RowIndex].Value);
            this.JSSJ1.Value = Convert.ToDateTime(this.JiLu[21, this.JiLu.CurrentCell.RowIndex].Value);
            this.JSSJ1.Value = Convert.ToDateTime(this.JiLu[21, this.JiLu.CurrentCell.RowIndex].Value);
            this.BZ1.Text = this.JiLu[22, this.JiLu.CurrentCell.RowIndex].Value.ToString();
        }
        private void JiLu_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        private void button1_Click(object sender,EventArgs e)
        {
            string sql;
            if (HWH1.Text.ToString().Trim() == ""||WLMC1.Text.ToString().Trim()=="")
            {
                MessageBox.Show("货位号，物料名称不能为空");
            }
            else
            {
                sql = "insert into TiDan(HWH,WLMC) values('" + HWH1.Text.ToString().Trim() + "','" + WLMC1.Text.ToString().Trim() + "')";
                int dd = 0;
                dd = new Class1().hsgexucute(sql);
                if (dd == 1)
                 {
                   //如插入成功，再次查询即可刷新
                   sql = "select*from TiDan";
                   DataSet result2 = new DataSet();
                   result2 = new Class1().hsggetdata(sql);
                   JiLu.DataSource = result2.Tables[0];
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
