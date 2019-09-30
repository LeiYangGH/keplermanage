namespace 管理系统
{
    partial class frmQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuery));
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolQuery = new System.Windows.Forms.ToolStripButton();
            this.ToolCancel = new System.Windows.Forms.ToolStripButton();
            this.ToolExport = new System.Windows.Forms.ToolStripButton();
            this.ToolClear = new System.Windows.Forms.ToolStripButton();
            this.ToolExit = new System.Windows.Forms.ToolStripButton();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Textbox1 = new System.Windows.Forms.TextBox();
            this.Cbb1 = new System.Windows.Forms.ComboBox();
            this.Cbb2 = new System.Windows.Forms.ComboBox();
            this.Textbox2 = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.DgvQuery = new System.Windows.Forms.DataGridView();
            this.ToolStrip1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripSeparator1,
            this.ToolStripSeparator2,
            this.ToolQuery,
            this.ToolCancel,
            this.ToolExport,
            this.ToolClear,
            this.ToolExit});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStrip1.Size = new System.Drawing.Size(687, 25);
            this.ToolStrip1.TabIndex = 2;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolQuery
            // 
            this.ToolQuery.Name = "ToolQuery";
            this.ToolQuery.Size = new System.Drawing.Size(36, 22);
            this.ToolQuery.Text = "查询";
            this.ToolQuery.Click += new System.EventHandler(this.ToolQuery_Click);
            // 
            // ToolCancel
            // 
            this.ToolCancel.Image = ((System.Drawing.Image)(resources.GetObject("ToolCancel.Image")));
            this.ToolCancel.Name = "ToolCancel";
            this.ToolCancel.Size = new System.Drawing.Size(52, 22);
            this.ToolCancel.Text = "取消";
            this.ToolCancel.Click += new System.EventHandler(this.ToolCancel_Click);
            // 
            // ToolExport
            // 
            this.ToolExport.Image = ((System.Drawing.Image)(resources.GetObject("ToolExport.Image")));
            this.ToolExport.Name = "ToolExport";
            this.ToolExport.Size = new System.Drawing.Size(52, 22);
            this.ToolExport.Text = "导出";
            this.ToolExport.Click += new System.EventHandler(this.ToolExport_Click);
            // 
            // ToolClear
            // 
            this.ToolClear.Image = ((System.Drawing.Image)(resources.GetObject("ToolClear.Image")));
            this.ToolClear.Name = "ToolClear";
            this.ToolClear.Size = new System.Drawing.Size(52, 22);
            this.ToolClear.Text = "刷新";
            this.ToolClear.Click += new System.EventHandler(this.ToolClear_Click);
            // 
            // ToolExit
            // 
            this.ToolExit.Image = ((System.Drawing.Image)(resources.GetObject("ToolExit.Image")));
            this.ToolExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolExit.Name = "ToolExit";
            this.ToolExit.Size = new System.Drawing.Size(52, 22);
            this.ToolExit.Text = "退出";
            this.ToolExit.Click += new System.EventHandler(this.ToolExit_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Textbox1);
            this.GroupBox1.Controls.Add(this.Cbb1);
            this.GroupBox1.Controls.Add(this.Cbb2);
            this.GroupBox1.Controls.Add(this.Textbox2);
            this.GroupBox1.Location = new System.Drawing.Point(8, 29);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(671, 71);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "查询条件";
            // 
            // Textbox1
            // 
            this.Textbox1.Location = new System.Drawing.Point(529, 32);
            this.Textbox1.Name = "Textbox1";
            this.Textbox1.Size = new System.Drawing.Size(126, 21);
            this.Textbox1.TabIndex = 0;
            // 
            // Cbb1
            // 
            this.Cbb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbb1.Location = new System.Drawing.Point(15, 33);
            this.Cbb1.Name = "Cbb1";
            this.Cbb1.Size = new System.Drawing.Size(126, 20);
            this.Cbb1.TabIndex = 1;
            this.Cbb1.SelectedIndexChanged += new System.EventHandler(this.Cbb1_SelectedIndexChanged);
            // 
            // Cbb2
            // 
            this.Cbb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbb2.Location = new System.Drawing.Point(362, 32);
            this.Cbb2.Name = "Cbb2";
            this.Cbb2.Size = new System.Drawing.Size(126, 20);
            this.Cbb2.TabIndex = 2;
            this.Cbb2.SelectedIndexChanged += new System.EventHandler(this.Cbb2_SelectedIndexChanged);
            // 
            // Textbox2
            // 
            this.Textbox2.Location = new System.Drawing.Point(176, 32);
            this.Textbox2.Name = "Textbox2";
            this.Textbox2.Size = new System.Drawing.Size(126, 21);
            this.Textbox2.TabIndex = 3;
            this.Textbox2.TextChanged += new System.EventHandler(this.Textbox2_TextChanged);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.DgvQuery);
            this.GroupBox2.Location = new System.Drawing.Point(8, 104);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(671, 301);
            this.GroupBox2.TabIndex = 1;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "查询结果";
            // 
            // DgvQuery
            // 
            this.DgvQuery.AllowUserToAddRows = false;
            this.DgvQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvQuery.Location = new System.Drawing.Point(6, 20);
            this.DgvQuery.Name = "DgvQuery";
            this.DgvQuery.RowTemplate.Height = 23;
            this.DgvQuery.Size = new System.Drawing.Size(655, 278);
            this.DgvQuery.TabIndex = 0;
            this.DgvQuery.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DgvQuery_DataError);
            // 
            // frmQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 416);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.ToolStrip1);
            this.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximizeBox = false;
            this.Name = "frmQuery";
            this.Text = "交易记录";
            this.Load += new System.EventHandler(this.Query_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvQuery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.ToolStrip ToolStrip1;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ToolExport;
        private System.Windows.Forms.ToolStripButton ToolQuery;
        private System.Windows.Forms.ToolStripButton ToolCancel;
        private System.Windows.Forms.ToolStripButton ToolClear;
        private System.Windows.Forms.ToolStripButton ToolExit;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.TextBox Textbox1;
        private System.Windows.Forms.TextBox Textbox2;
        private System.Windows.Forms.DataGridView DgvQuery;
        private System.Windows.Forms.ComboBox Cbb1;
        private System.Windows.Forms.ComboBox Cbb2;
        
    }
}