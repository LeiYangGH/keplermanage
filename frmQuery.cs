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
using System.Data.Entity.Core.Objects.DataClasses;

namespace 管理系统
{
    struct FieldList
    {
        public string FieldName;
        public Type FieldType;
        public bool FieldPK;
    }
    public partial class frmQuery : Form
    {
        public frmQuery()
        {
            InitializeComponent();
        }
        private void Query_Load(object sender, EventArgs e)
        {
            this.GetColumns();
        }

        private void ToolCancel_Click(object sender, EventArgs e)
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

        private void ToolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ToolClear_Click(object sender, EventArgs e)
        {
            this.RefreshDisPlay();
        }

        private void ToolExport_Click(object sender, EventArgs e)
        {
            this.DataGridViewExportToExcel(DgvQuery, this.Text);
        }

        private void GetColumns()
        {
            using (var entities = new ManagementEntities())
            {
                try
                {
                    //https://stackoverflow.com/questions/6056597/entity-framework-how-do-i-get-the-columns
                    IEnumerable<FieldList> properties = from p in typeof(TiDan).GetProperties()

                                                        select new FieldList
                                                        {
                                                            FieldName = p.Name,
                                                            FieldType = p.PropertyType,
                                                            FieldPK = p.GetCustomAttributes(false).Where(a => a is EdmScalarPropertyAttribute && ((EdmScalarPropertyAttribute)a).EntityKeyProperty).Count() > 0
                                                        };
                    //properties.ToList().ForEach(x => { MessageBox.Show(x.FieldType.ToString()); }); 用来调试，显示各个字段的类型
                    //筛选字符串类型的字段
                    var lst = properties.Where(x => !x.FieldPK).Where(x => x.FieldType == typeof(string)).Select(x => x.FieldName).ToList();
                    this.Cbb1.DataSource = lst;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void ToolQuery_Click(object sender, EventArgs e)
        {
            using (var entities = new ManagementEntities())
            {
                try
                {
                    string selectedColumn = this.Cbb1.Text.Trim();
                    string inputText = this.Textbox2.Text.Trim();
                    if (string.IsNullOrWhiteSpace(selectedColumn))
                        return;
                    var query = entities.TiDans.AsQueryable();
                    if (selectedColumn == "FHFS")
                        query = query.Where(x => x.FHFS.Contains(inputText));
                    if (selectedColumn == "TDH")
                        query = query.Where(x => x.TDH.Contains(inputText));
                    //...其他字段你自己加
                    this.DgvQuery.DataSource = query.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void DgvQuery_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        private void RefreshDisPlay()
        {
            using (var entities = new ManagementEntities())
            {
                try
                {
                    this.DgvQuery.DataSource = entities.TiDans.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void DataGridViewExportToExcel(DataGridView dgv, string strTitle)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files(*.xls)|*.xls";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = false;
            saveFileDialog.FileName = strTitle + ".xls";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            Stream myStream = saveFileDialog.OpenFile();
            StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.GetEncoding(-0));
            string strHeaderText = "";

            try
            {
                for (int i = 0; i < dgv.ColumnCount; i++)
                {
                    if (i > 0)
                    {
                        strHeaderText += "\t";
                    }
                    strHeaderText += dgv.Columns[i].HeaderText;
                }
                sw.WriteLine(strHeaderText);

                string strItemValue = "";
                for (int j = 0; j < dgv.RowCount; j++)
                {
                    strItemValue = "";
                    for (int k = 0; k < dgv.ColumnCount; k++)
                    {
                        if (k > 0)
                        {
                            strItemValue += "\t";
                        }
                        strItemValue += dgv.Rows[j].Cells[k].Value.ToString();
                    }
                    sw.WriteLine(strItemValue);
                }
            }
            catch (Exception ex)
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

        private void Textbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cbb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cbb2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}
