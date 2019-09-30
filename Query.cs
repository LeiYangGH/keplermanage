using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 管理系统
{
    public partial class Query : Form
    {
        public Query()
        {
            InitializeComponent();
        }
        private void Query_Load(object sender,EventArgs e)
        {

        }

        private void ToolCancel_Click(object sender,EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if ((control as GroupBox) != null)
                {
                    foreach (Control tempcontrol in control.Controls)
                    {
                        if (tempcontrol is TextBox)
                        {

                            tempcontrol.Text = "";
                        }
                    }
                }
            }
        }

        private void ToolExit_Click(object sender,EventArgs e)
        {
            this.Close();
        }
        private void ToolClear_Click(object sender,EventArgs e)
        {
            this.RefreshDisPlay();
        }
        
        private void ToolExport_Click(object sender,EventArgs e)
        {
            this.DataGridViewExportToExcel(DgvQuery,this.Text);
        }
        private void ToolQuery_Click(object sender,EventArgs e)
        {

        }
        private void DgvQuery_DataError(object sender,DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        private void RefreshDisPlay()
        {
            using(var entities=new ManagementEntities())
            {
                try
                {
                    this.DgvQuery.DataSource = entities.TiDans.ToList();

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
        private void DataGridViewExportToExcel(DataGridView dgv,string strTitle)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files(*.xls)|*.xls";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = false;
            saveFileDialog.FileName = strTitle + ".xls";
            if(saveFileDialog.ShowDialog()==DialogResult.Cancel)
            {
                return;
            }
            Stream myStream = saveFileDialog.OpenFile();
            StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.GetEncoding(-0));
            string strHeaderText = "";

            try
            {
                for(int i=0;i<dgv.ColumnCount;i++)
                {
                    if(i>0)
                    {
                        strHeaderText += "\t";
                    }
                    strHeaderText += dgv.Columns[i].HeaderText;
                }
                sw.WriteLine(strHeaderText);

                string strItemValue = "";
                for(int j=0;j<dgv.RowCount;j++)
                {
                    strItemValue = "";
                    for(int k=0;k<dgv.ColumnCount;k++)
                    {
                        if(k>0)
                        {
                            strItemValue += "\t";
                        }
                        strItemValue += dgv.Rows[j].Cells[k].Value.ToString();
                    }
                    sw.WriteLine(strItemValue);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "提示");
                throw ex;
            }
            finally
            {
                sw.Close();
                myStream.Close();
            }
        }
    }
}
