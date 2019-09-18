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
    public partial class frmBill : Form
    {
        public frmBill()
        {
            InitializeComponent();
        }
        string strid = "";

        public void TiDan_Load(object sender, EventArgs e)
        {
            string sql;
            sql = "select*from TiDan";
            //result = new SqlHelper().hsggetdata(sql);
            //this.tiDanTableAdapter.Fill(this.管理系统DataSet.TiDan);
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
            this.HWH1.Text = "";
            this.PZ1.Text = "";
            this.MZ1.Text = "";
            this.JZ1.Text = "";
            this.WLMC1.Text = "";
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
            this.cboFHFS1.SelectedValue = this.dgvRecords[0, this.dgvRecords.CurrentCell.RowIndex].Value;
            this.CPH1.Text = this.dgvRecords[1, this.dgvRecords.CurrentCell.RowIndex].Value.ToString();
            this.LSH1.Text = this.dgvRecords[2, this.dgvRecords.CurrentCell.RowIndex].Value.ToString();
            this.QFH1.Text = this.dgvRecords[3, this.dgvRecords.CurrentCell.RowIndex].Value.ToString();
            this.TDH1.Text = this.dgvRecords[4, this.dgvRecords.CurrentCell.RowIndex].Value.ToString();
            this.YFL1.Text = this.dgvRecords[5, this.dgvRecords.CurrentCell.RowIndex].Value.ToString();
            this.SFL1.Text = this.dgvRecords[6, this.dgvRecords.CurrentCell.RowIndex].Value.ToString();
            this.CZY1.Text = this.dgvRecords[7, this.dgvRecords.CurrentCell.RowIndex].Value.ToString();
            this.HTH1.Text = this.dgvRecords[8, this.dgvRecords.CurrentCell.RowIndex].Value.ToString();
            this.CPGH1.Text = this.dgvRecords[9, this.dgvRecords.CurrentCell.RowIndex].Value.ToString();
            this.PCH1.Text = this.dgvRecords[10, this.dgvRecords.CurrentCell.RowIndex].Value.ToString();
            this.HWH1.Text = this.dgvRecords[11, this.dgvRecords.CurrentCell.RowIndex].Value.ToString();
            this.PZ1.Text = this.dgvRecords[12, this.dgvRecords.CurrentCell.RowIndex].Value.ToString();
            this.MZ1.Text = this.dgvRecords[13, this.dgvRecords.CurrentCell.RowIndex].Value.ToString();
            this.JZ1.Text = this.dgvRecords[14, this.dgvRecords.CurrentCell.RowIndex].Value.ToString();
            this.WLMC1.Text = this.dgvRecords[15, this.dgvRecords.CurrentCell.RowIndex].Value.ToString();
            this.HC1.Text = this.dgvRecords[16, this.dgvRecords.CurrentCell.RowIndex].Value.ToString();
            this.FHDW1.Text = this.dgvRecords[17, this.dgvRecords.CurrentCell.RowIndex].Value.ToString();
            this.SHDW1.Text = this.dgvRecords[18, this.dgvRecords.CurrentCell.RowIndex].Value.ToString();
            this.LX1.Text = this.dgvRecords[19, this.dgvRecords.CurrentCell.RowIndex].Value.ToString();
            this.KSSJ1.Value = Convert.ToDateTime(this.dgvRecords[20, this.dgvRecords.CurrentCell.RowIndex].Value);
            this.JSSJ1.Value = Convert.ToDateTime(this.dgvRecords[21, this.dgvRecords.CurrentCell.RowIndex].Value);
            this.JSSJ1.Value = Convert.ToDateTime(this.dgvRecords[21, this.dgvRecords.CurrentCell.RowIndex].Value);
            this.JSSJ1.Value = Convert.ToDateTime(this.dgvRecords[21, this.dgvRecords.CurrentCell.RowIndex].Value);
            this.BZ1.Text = this.dgvRecords[22, this.dgvRecords.CurrentCell.RowIndex].Value.ToString();
        }
        private void dgvRecords_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void RefreshDisplay()
        {
            using (var entities = new ManagementEntities())
            {
                try
                {
                    this.dgvRecords.DataSource = entities.TiDans.ToList();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    foreach (var err in entities.GetValidationErrors())
                        MessageBox.Show(String.Join(",",
                            err.ValidationErrors.Select(x => x.ErrorMessage)));

                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var entities = new ManagementEntities())
            {
                try
                {
                    string selectedFHFS = this.cboFHFS1.Text;
                    string selectedCPH = this.CPH1.Text;
                    string selectedLSH = this.LSH1.Text;
                    string selectedQFH = this.QFH1.Text;
                    string selectedYFL = this.YFL1.Text;
                    string selectedSFL = this.SFL1.Text;
                    string selectedCZY = this.CZY1.Text;
                    string selectedHTH = this.HTH1.Text;
                    string selectedCPGH = this.CPGH1.Text;
                    string selectedPCH = this.PCH1.Text;
                    string selectedHWH = this.HWH1.Text;
                    string selectedJZ = this.JZ1.Text;
                    string selectedPZ = this.PZ1.Text;
                    string selectedMZ = this.MZ1.Text;
                    string selectedWLMC = this.WLMC1.Text;
                    string selectedHC = this.HC1.Text;
                    string selectedFHDW = this.FHDW1.Text;
                    string selectedSHDW = this.SHDW1.Text;
                    string selectedLX = this.LX1.Text;
                    string selectedBZ = this.BZ1.Text;
                    
                    
                    
                    
                    
                    
                    MessageBox.Show($"选择的发货方式是{selectedFHFS}准备添加.");
                    TiDan ti = new TiDan();
                    ti.FHFS = selectedFHFS;
                    //为了避免重复单号，违法主键约束，暂时用guid
                    ti.TDH = System.Guid.NewGuid().ToString();

                    //这里你先把各种值写死，暂时不管界面填的什么
                    ti.CZY = selectedCPH;
                    ti.LSH = selectedLSH;
                    ti.QFH = selectedQFH;
                    ti.YFL = int.Parse(selectedYFL);
                    ti.SFL = int.Parse(selectedSFL);
                    ti.CZY = selectedCZY;
                    ti.HTH = selectedHTH;
                    ti.CPGH = selectedCPGH;
                    ti.PCH = selectedPCH;
                    ti.HWH = selectedHWH;
                    ti.PZ = int.Parse(selectedPZ);
                    ti.MZ = int.Parse(selectedMZ);
                    ti.JZ = int.Parse(selectedJZ);
                    ti.WLMC = selectedWLMC;
                    ti.HC = selectedHC;
                    ti.FHDW = selectedFHDW;
                    ti.SHDW = selectedSHDW;
                    ti.LX = selectedLX;
                    ti.KSSJ = DateTime.Now;
                    ti.JSSJ = DateTime.Now;
                    ti.BZ = selectedBZ;
                    


                    entities.TiDans.Add(ti);

                    entities.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
                    entities.SaveChanges();
                    this.RefreshDisplay();
                    //MessageBox.Show("已添加！");

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    foreach (var err in entities.GetValidationErrors())
                        MessageBox.Show(String.Join(",",
                            err.ValidationErrors.Select(x => x.ErrorMessage)));

                }
            }


        }


        private void btnRemove_Click(object sender,EventArgs e)
        {
            using (var entities = new ManagementEntities())
            {
                TiDan ti = entities.TiDans.Where(W => W.TDH == strid).FirstOrDefault();
                if (ti != null)
                {
                    entities.TiDans.Remove(ti);
                    entities.SaveChanges();
                    dgvRecords.DataSource = entities.TiDans.ToList();
                    MessageBox.Show("记录删除成功");
                }
                else
                    MessageBox.Show("请选择要删除的记录");
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.RefreshDisplay();

        }
    }




}
