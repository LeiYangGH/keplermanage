namespace 管理系统
{
    partial class frmBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BiaoTi = new System.Windows.Forms.Label();
            this.dgvRecords = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cboFHFS1 = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.FHFS = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SHDW1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.CPH = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.FHDW1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.CPH1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.LSH = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.LSH1 = new System.Windows.Forms.TextBox();
            this.QFH = new System.Windows.Forms.Label();
            this.QFH1 = new System.Windows.Forms.TextBox();
            this.TDH = new System.Windows.Forms.Label();
            this.TDH1 = new System.Windows.Forms.TextBox();
            this.YFL = new System.Windows.Forms.Label();
            this.YFL1 = new System.Windows.Forms.TextBox();
            this.SFL = new System.Windows.Forms.Label();
            this.SFL1 = new System.Windows.Forms.TextBox();
            this.CZY = new System.Windows.Forms.Label();
            this.CZY1 = new System.Windows.Forms.TextBox();
            this.HTH = new System.Windows.Forms.Label();
            this.HTH1 = new System.Windows.Forms.TextBox();
            this.FHDW = new System.Windows.Forms.Label();
            this.SHDW = new System.Windows.Forms.Label();
            this.CPGH = new System.Windows.Forms.Label();
            this.CPGH1 = new System.Windows.Forms.TextBox();
            this.PCH = new System.Windows.Forms.Label();
            this.PCH1 = new System.Windows.Forms.TextBox();
            this.WLMC = new System.Windows.Forms.Label();
            this.WLMC1 = new System.Windows.Forms.TextBox();
            this.PZ = new System.Windows.Forms.Label();
            this.PZ1 = new System.Windows.Forms.TextBox();
            this.MZ = new System.Windows.Forms.Label();
            this.MZ1 = new System.Windows.Forms.TextBox();
            this.JZ = new System.Windows.Forms.Label();
            this.JZ1 = new System.Windows.Forms.TextBox();
            this.HC = new System.Windows.Forms.Label();
            this.HC1 = new System.Windows.Forms.TextBox();
            this.BZ = new System.Windows.Forms.Label();
            this.BZ1 = new System.Windows.Forms.TextBox();
            this.HWH = new System.Windows.Forms.Label();
            this.HWH1 = new System.Windows.Forms.TextBox();
            this.LX = new System.Windows.Forms.Label();
            this.LX1 = new System.Windows.Forms.TextBox();
            this.KSSJ = new System.Windows.Forms.Label();
            this.KSSJ1 = new System.Windows.Forms.DateTimePicker();
            this.JSSJ = new System.Windows.Forms.Label();
            this.JSSJ1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BiaoTi
            // 
            this.BiaoTi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BiaoTi.Font = new System.Drawing.Font("宋体", 40F);
            this.BiaoTi.Location = new System.Drawing.Point(479, 49);
            this.BiaoTi.Name = "BiaoTi";
            this.BiaoTi.Size = new System.Drawing.Size(620, 50);
            this.BiaoTi.TabIndex = 1;
            this.BiaoTi.Text = "云悦欣定量罐装监控系统";
            this.BiaoTi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvRecords
            // 
            this.dgvRecords.AllowUserToAddRows = false;
            this.dgvRecords.AllowUserToDeleteRows = false;
            this.dgvRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecords.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvRecords.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecords.Location = new System.Drawing.Point(40, 467);
            this.dgvRecords.Name = "dgvRecords";
            this.dgvRecords.ReadOnly = true;
            this.dgvRecords.RowTemplate.Height = 23;
            this.dgvRecords.Size = new System.Drawing.Size(1232, 194);
            this.dgvRecords.TabIndex = 3;
            this.dgvRecords.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvRecords_DataError);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.cboFHFS1);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.FHFS);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.SHDW1);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.CPH);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.FHDW1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.CPH1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.LSH);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.LSH1);
            this.groupBox1.Controls.Add(this.QFH);
            this.groupBox1.Controls.Add(this.QFH1);
            this.groupBox1.Controls.Add(this.TDH);
            this.groupBox1.Controls.Add(this.TDH1);
            this.groupBox1.Controls.Add(this.YFL);
            this.groupBox1.Controls.Add(this.YFL1);
            this.groupBox1.Controls.Add(this.SFL);
            this.groupBox1.Controls.Add(this.SFL1);
            this.groupBox1.Controls.Add(this.CZY);
            this.groupBox1.Controls.Add(this.CZY1);
            this.groupBox1.Controls.Add(this.HTH);
            this.groupBox1.Controls.Add(this.HTH1);
            this.groupBox1.Controls.Add(this.FHDW);
            this.groupBox1.Controls.Add(this.SHDW);
            this.groupBox1.Controls.Add(this.CPGH);
            this.groupBox1.Controls.Add(this.CPGH1);
            this.groupBox1.Controls.Add(this.PCH);
            this.groupBox1.Controls.Add(this.PCH1);
            this.groupBox1.Controls.Add(this.WLMC);
            this.groupBox1.Controls.Add(this.WLMC1);
            this.groupBox1.Controls.Add(this.PZ);
            this.groupBox1.Controls.Add(this.PZ1);
            this.groupBox1.Controls.Add(this.MZ);
            this.groupBox1.Controls.Add(this.MZ1);
            this.groupBox1.Controls.Add(this.JZ);
            this.groupBox1.Controls.Add(this.JZ1);
            this.groupBox1.Controls.Add(this.HC);
            this.groupBox1.Controls.Add(this.HC1);
            this.groupBox1.Controls.Add(this.BZ);
            this.groupBox1.Controls.Add(this.BZ1);
            this.groupBox1.Controls.Add(this.HWH);
            this.groupBox1.Controls.Add(this.HWH1);
            this.groupBox1.Controls.Add(this.LX);
            this.groupBox1.Controls.Add(this.LX1);
            this.groupBox1.Controls.Add(this.KSSJ);
            this.groupBox1.Controls.Add(this.KSSJ1);
            this.groupBox1.Controls.Add(this.JSSJ);
            this.groupBox1.Controls.Add(this.JSSJ1);
            this.groupBox1.Location = new System.Drawing.Point(40, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1478, 323);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(1378, 254);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 45);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "删除交易记录";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // cboFHFS1
            // 
            this.cboFHFS1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFHFS1.Items.AddRange(new object[] {
            "IC卡发货",
            "提单号发货"});
            this.cboFHFS1.Location = new System.Drawing.Point(83, 32);
            this.cboFHFS1.MaxLength = 9;
            this.cboFHFS1.Name = "cboFHFS1";
            this.cboFHFS1.Size = new System.Drawing.Size(121, 20);
            this.cboFHFS1.TabIndex = 4;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1147, 254);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 45);
            this.button7.TabIndex = 10;
            this.button7.Text = "删除待发单";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // FHFS
            // 
            this.FHFS.AutoSize = true;
            this.FHFS.Location = new System.Drawing.Point(20, 37);
            this.FHFS.Name = "FHFS";
            this.FHFS.Size = new System.Drawing.Size(53, 12);
            this.FHFS.TabIndex = 0;
            this.FHFS.Text = "发货方式";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1378, 182);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 45);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // SHDW1
            // 
            this.SHDW1.Location = new System.Drawing.Point(640, 221);
            this.SHDW1.Name = "SHDW1";
            this.SHDW1.Size = new System.Drawing.Size(121, 21);
            this.SHDW1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1147, 182);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 45);
            this.button5.TabIndex = 8;
            this.button5.Text = "刷新";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // CPH
            // 
            this.CPH.AutoSize = true;
            this.CPH.Location = new System.Drawing.Point(213, 37);
            this.CPH.Name = "CPH";
            this.CPH.Size = new System.Drawing.Size(41, 12);
            this.CPH.TabIndex = 0;
            this.CPH.Text = "车牌号";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1378, 95);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 45);
            this.button4.TabIndex = 7;
            this.button4.Text = "查询";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FHDW1
            // 
            this.FHDW1.Location = new System.Drawing.Point(450, 221);
            this.FHDW1.Name = "FHDW1";
            this.FHDW1.Size = new System.Drawing.Size(121, 21);
            this.FHDW1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1147, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 45);
            this.button3.TabIndex = 6;
            this.button3.Text = "打印";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // CPH1
            // 
            this.CPH1.Location = new System.Drawing.Point(260, 32);
            this.CPH1.MaxLength = 9;
            this.CPH1.Name = "CPH1";
            this.CPH1.Size = new System.Drawing.Size(121, 21);
            this.CPH1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1378, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "结算业务";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // LSH
            // 
            this.LSH.AutoSize = true;
            this.LSH.Location = new System.Drawing.Point(403, 37);
            this.LSH.Name = "LSH";
            this.LSH.Size = new System.Drawing.Size(41, 12);
            this.LSH.TabIndex = 0;
            this.LSH.Text = "流水号";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1147, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 45);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "生成提货单";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // LSH1
            // 
            this.LSH1.Location = new System.Drawing.Point(450, 32);
            this.LSH1.MaxLength = 9;
            this.LSH1.Name = "LSH1";
            this.LSH1.Size = new System.Drawing.Size(121, 21);
            this.LSH1.TabIndex = 0;
            // 
            // QFH
            // 
            this.QFH.AutoSize = true;
            this.QFH.Location = new System.Drawing.Point(593, 37);
            this.QFH.Name = "QFH";
            this.QFH.Size = new System.Drawing.Size(41, 12);
            this.QFH.TabIndex = 0;
            this.QFH.Text = "铅封号";
            // 
            // QFH1
            // 
            this.QFH1.Location = new System.Drawing.Point(640, 32);
            this.QFH1.MaxLength = 9;
            this.QFH1.Name = "QFH1";
            this.QFH1.Size = new System.Drawing.Size(121, 21);
            this.QFH1.TabIndex = 0;
            // 
            // TDH
            // 
            this.TDH.AutoSize = true;
            this.TDH.Location = new System.Drawing.Point(783, 37);
            this.TDH.Name = "TDH";
            this.TDH.Size = new System.Drawing.Size(41, 12);
            this.TDH.TabIndex = 0;
            this.TDH.Text = "提单号";
            // 
            // TDH1
            // 
            this.TDH1.Location = new System.Drawing.Point(830, 32);
            this.TDH1.MaxLength = 9;
            this.TDH1.Name = "TDH1";
            this.TDH1.Size = new System.Drawing.Size(121, 21);
            this.TDH1.TabIndex = 3;
            // 
            // YFL
            // 
            this.YFL.AutoSize = true;
            this.YFL.Location = new System.Drawing.Point(36, 100);
            this.YFL.Name = "YFL";
            this.YFL.Size = new System.Drawing.Size(41, 12);
            this.YFL.TabIndex = 0;
            this.YFL.Text = "应发量";
            // 
            // YFL1
            // 
            this.YFL1.Location = new System.Drawing.Point(83, 95);
            this.YFL1.MaxLength = 9;
            this.YFL1.Name = "YFL1";
            this.YFL1.Size = new System.Drawing.Size(121, 21);
            this.YFL1.TabIndex = 0;
            // 
            // SFL
            // 
            this.SFL.Location = new System.Drawing.Point(213, 100);
            this.SFL.Name = "SFL";
            this.SFL.Size = new System.Drawing.Size(41, 12);
            this.SFL.TabIndex = 0;
            this.SFL.Text = "实发量";
            // 
            // SFL1
            // 
            this.SFL1.Location = new System.Drawing.Point(260, 95);
            this.SFL1.MaxLength = 9;
            this.SFL1.Name = "SFL1";
            this.SFL1.Size = new System.Drawing.Size(121, 21);
            this.SFL1.TabIndex = 0;
            // 
            // CZY
            // 
            this.CZY.AutoSize = true;
            this.CZY.Location = new System.Drawing.Point(403, 100);
            this.CZY.Name = "CZY";
            this.CZY.Size = new System.Drawing.Size(41, 12);
            this.CZY.TabIndex = 0;
            this.CZY.Text = "操作员";
            // 
            // CZY1
            // 
            this.CZY1.Location = new System.Drawing.Point(450, 95);
            this.CZY1.MaxLength = 9;
            this.CZY1.Name = "CZY1";
            this.CZY1.Size = new System.Drawing.Size(121, 21);
            this.CZY1.TabIndex = 0;
            // 
            // HTH
            // 
            this.HTH.AutoSize = true;
            this.HTH.Location = new System.Drawing.Point(593, 100);
            this.HTH.Name = "HTH";
            this.HTH.Size = new System.Drawing.Size(41, 12);
            this.HTH.TabIndex = 0;
            this.HTH.Text = "合同号";
            // 
            // HTH1
            // 
            this.HTH1.Location = new System.Drawing.Point(640, 95);
            this.HTH1.Name = "HTH1";
            this.HTH1.Size = new System.Drawing.Size(121, 21);
            this.HTH1.TabIndex = 0;
            // 
            // FHDW
            // 
            this.FHDW.AutoSize = true;
            this.FHDW.Location = new System.Drawing.Point(391, 224);
            this.FHDW.Name = "FHDW";
            this.FHDW.Size = new System.Drawing.Size(53, 12);
            this.FHDW.TabIndex = 0;
            this.FHDW.Text = "发货单位";
            // 
            // SHDW
            // 
            this.SHDW.AutoSize = true;
            this.SHDW.Location = new System.Drawing.Point(581, 224);
            this.SHDW.Name = "SHDW";
            this.SHDW.Size = new System.Drawing.Size(53, 12);
            this.SHDW.TabIndex = 0;
            this.SHDW.Text = "收货单位";
            // 
            // CPGH
            // 
            this.CPGH.AutoSize = true;
            this.CPGH.Location = new System.Drawing.Point(772, 100);
            this.CPGH.Name = "CPGH";
            this.CPGH.Size = new System.Drawing.Size(53, 12);
            this.CPGH.TabIndex = 0;
            this.CPGH.Text = "产品罐号";
            // 
            // CPGH1
            // 
            this.CPGH1.Location = new System.Drawing.Point(830, 95);
            this.CPGH1.Name = "CPGH1";
            this.CPGH1.Size = new System.Drawing.Size(121, 21);
            this.CPGH1.TabIndex = 0;
            // 
            // PCH
            // 
            this.PCH.AutoSize = true;
            this.PCH.Location = new System.Drawing.Point(36, 163);
            this.PCH.Name = "PCH";
            this.PCH.Size = new System.Drawing.Size(41, 12);
            this.PCH.TabIndex = 0;
            this.PCH.Text = "批次号";
            // 
            // PCH1
            // 
            this.PCH1.Location = new System.Drawing.Point(83, 158);
            this.PCH1.MaxLength = 9;
            this.PCH1.Name = "PCH1";
            this.PCH1.Size = new System.Drawing.Size(121, 21);
            this.PCH1.TabIndex = 0;
            // 
            // WLMC
            // 
            this.WLMC.AutoSize = true;
            this.WLMC.Location = new System.Drawing.Point(24, 229);
            this.WLMC.Name = "WLMC";
            this.WLMC.Size = new System.Drawing.Size(53, 12);
            this.WLMC.TabIndex = 0;
            this.WLMC.Text = "物料名称";
            // 
            // WLMC1
            // 
            this.WLMC1.Location = new System.Drawing.Point(83, 222);
            this.WLMC1.Name = "WLMC1";
            this.WLMC1.Size = new System.Drawing.Size(121, 21);
            this.WLMC1.TabIndex = 0;
            // 
            // PZ
            // 
            this.PZ.AutoSize = true;
            this.PZ.Location = new System.Drawing.Point(391, 163);
            this.PZ.Name = "PZ";
            this.PZ.Size = new System.Drawing.Size(53, 12);
            this.PZ.TabIndex = 0;
            this.PZ.Text = "皮重(KG)";
            // 
            // PZ1
            // 
            this.PZ1.Location = new System.Drawing.Point(450, 158);
            this.PZ1.MaxLength = 9;
            this.PZ1.Name = "PZ1";
            this.PZ1.Size = new System.Drawing.Size(121, 21);
            this.PZ1.TabIndex = 0;
            // 
            // MZ
            // 
            this.MZ.AutoSize = true;
            this.MZ.Location = new System.Drawing.Point(581, 163);
            this.MZ.Name = "MZ";
            this.MZ.Size = new System.Drawing.Size(53, 12);
            this.MZ.TabIndex = 0;
            this.MZ.Text = "毛重(KG)";
            // 
            // MZ1
            // 
            this.MZ1.Location = new System.Drawing.Point(640, 158);
            this.MZ1.MaxLength = 9;
            this.MZ1.Name = "MZ1";
            this.MZ1.Size = new System.Drawing.Size(121, 21);
            this.MZ1.TabIndex = 0;
            // 
            // JZ
            // 
            this.JZ.AutoSize = true;
            this.JZ.Location = new System.Drawing.Point(770, 163);
            this.JZ.Name = "JZ";
            this.JZ.Size = new System.Drawing.Size(53, 12);
            this.JZ.TabIndex = 0;
            this.JZ.Text = "净重(KG)";
            // 
            // JZ1
            // 
            this.JZ1.Location = new System.Drawing.Point(830, 158);
            this.JZ1.MaxLength = 9;
            this.JZ1.Name = "JZ1";
            this.JZ1.Size = new System.Drawing.Size(121, 21);
            this.JZ1.TabIndex = 0;
            // 
            // HC
            // 
            this.HC.AutoSize = true;
            this.HC.Location = new System.Drawing.Point(225, 224);
            this.HC.Name = "HC";
            this.HC.Size = new System.Drawing.Size(29, 12);
            this.HC.TabIndex = 0;
            this.HC.Text = "航次";
            // 
            // HC1
            // 
            this.HC1.Location = new System.Drawing.Point(260, 221);
            this.HC1.Name = "HC1";
            this.HC1.Size = new System.Drawing.Size(121, 21);
            this.HC1.TabIndex = 0;
            // 
            // BZ
            // 
            this.BZ.AutoSize = true;
            this.BZ.Location = new System.Drawing.Point(638, 287);
            this.BZ.Name = "BZ";
            this.BZ.Size = new System.Drawing.Size(29, 12);
            this.BZ.TabIndex = 0;
            this.BZ.Text = "备注";
            // 
            // BZ1
            // 
            this.BZ1.Location = new System.Drawing.Point(673, 282);
            this.BZ1.Name = "BZ1";
            this.BZ1.Size = new System.Drawing.Size(278, 21);
            this.BZ1.TabIndex = 0;
            // 
            // HWH
            // 
            this.HWH.AutoSize = true;
            this.HWH.Location = new System.Drawing.Point(213, 163);
            this.HWH.Name = "HWH";
            this.HWH.Size = new System.Drawing.Size(41, 12);
            this.HWH.TabIndex = 0;
            this.HWH.Text = "货位号";
            // 
            // HWH1
            // 
            this.HWH1.Location = new System.Drawing.Point(260, 158);
            this.HWH1.MaxLength = 9;
            this.HWH1.Name = "HWH1";
            this.HWH1.Size = new System.Drawing.Size(121, 21);
            this.HWH1.TabIndex = 0;
            // 
            // LX
            // 
            this.LX.AutoSize = true;
            this.LX.Location = new System.Drawing.Point(794, 224);
            this.LX.Name = "LX";
            this.LX.Size = new System.Drawing.Size(29, 12);
            this.LX.TabIndex = 0;
            this.LX.Text = "流向";
            // 
            // LX1
            // 
            this.LX1.Location = new System.Drawing.Point(830, 221);
            this.LX1.MaxLength = 9;
            this.LX1.Name = "LX1";
            this.LX1.Size = new System.Drawing.Size(121, 21);
            this.LX1.TabIndex = 0;
            // 
            // KSSJ
            // 
            this.KSSJ.AutoSize = true;
            this.KSSJ.Location = new System.Drawing.Point(24, 287);
            this.KSSJ.Name = "KSSJ";
            this.KSSJ.Size = new System.Drawing.Size(53, 12);
            this.KSSJ.TabIndex = 0;
            this.KSSJ.Text = "开始时间";
            // 
            // KSSJ1
            // 
            this.KSSJ1.CustomFormat = "yyyy-MM-dd HH:mm";
            this.KSSJ1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.KSSJ1.Location = new System.Drawing.Point(82, 282);
            this.KSSJ1.Name = "KSSJ1";
            this.KSSJ1.Size = new System.Drawing.Size(200, 21);
            this.KSSJ1.TabIndex = 0;
            // 
            // JSSJ
            // 
            this.JSSJ.AutoSize = true;
            this.JSSJ.Location = new System.Drawing.Point(328, 287);
            this.JSSJ.Name = "JSSJ";
            this.JSSJ.Size = new System.Drawing.Size(53, 12);
            this.JSSJ.TabIndex = 0;
            this.JSSJ.Text = "结束时间";
            // 
            // JSSJ1
            // 
            this.JSSJ1.CustomFormat = "yyyy-MM-dd HH:mm";
            this.JSSJ1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.JSSJ1.Location = new System.Drawing.Point(387, 282);
            this.JSSJ1.Name = "JSSJ1";
            this.JSSJ1.Size = new System.Drawing.Size(200, 21);
            this.JSSJ1.TabIndex = 0;
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 757);
            this.Controls.Add(this.dgvRecords);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BiaoTi);
            this.Name = "frmBill";
            this.Text = "TiDan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BiaoTi;
        private System.Windows.Forms.DataGridView dgvRecords;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label FHFS;
        private System.Windows.Forms.Label CPH;
        private System.Windows.Forms.Label LSH;
        private System.Windows.Forms.Label QFH;
        private System.Windows.Forms.Label TDH;
        private System.Windows.Forms.Label YFL;
        private System.Windows.Forms.Label SFL;
        private System.Windows.Forms.Label CZY;
        private System.Windows.Forms.Label HTH;
        private System.Windows.Forms.Label SHDW;
        private System.Windows.Forms.Label FHDW;
        private System.Windows.Forms.Label CPGH;
        private System.Windows.Forms.Label PCH;
        private System.Windows.Forms.Label WLMC;
        private System.Windows.Forms.Label PZ;
        private System.Windows.Forms.Label MZ;
        private System.Windows.Forms.Label JZ;
        private System.Windows.Forms.Label HC;
        private System.Windows.Forms.Label BZ;
        private System.Windows.Forms.Label HWH;
        private System.Windows.Forms.Label LX;
        private System.Windows.Forms.Label KSSJ;
        private System.Windows.Forms.Label JSSJ;
        private System.Windows.Forms.ComboBox cboFHFS1;
        private System.Windows.Forms.TextBox CPH1;
        private System.Windows.Forms.TextBox LSH1;
        private System.Windows.Forms.TextBox QFH1;
        private System.Windows.Forms.TextBox TDH1;
        private System.Windows.Forms.TextBox SFL1;
        private System.Windows.Forms.TextBox YFL1;
        private System.Windows.Forms.TextBox CZY1;
        private System.Windows.Forms.TextBox HTH1;
        private System.Windows.Forms.TextBox CPGH1;
        private System.Windows.Forms.TextBox PCH1;
        private System.Windows.Forms.TextBox SHDW1;
        private System.Windows.Forms.TextBox FHDW1;
        private System.Windows.Forms.TextBox WLMC1;
        private System.Windows.Forms.TextBox PZ1;
        private System.Windows.Forms.TextBox MZ1;
        private System.Windows.Forms.TextBox JZ1;
        private System.Windows.Forms.TextBox HC1;
        private System.Windows.Forms.TextBox BZ1;
        private System.Windows.Forms.TextBox HWH1;
        private System.Windows.Forms.TextBox LX1;
        private System.Windows.Forms.DateTimePicker KSSJ1;
        private System.Windows.Forms.DateTimePicker JSSJ1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnRemove;
    }
}