namespace System
{
    partial class Form2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btFind = new System.Windows.Forms.Button();
            this.btShowAll = new System.Windows.Forms.Button();
            this.ComboType = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCode = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelManager = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.labelBuildTime = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btDelate = new System.Windows.Forms.Button();
            this.BTOK = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(815, 466);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btDelate);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.ComboType);
            this.tabPage1.Controls.Add(this.btShowAll);
            this.tabPage1.Controls.Add(this.btFind);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(807, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "人员信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(807, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "数据维护";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(8, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(602, 317);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "部门编码";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "部门名称";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "负责人";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "电话";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "成立时间";
            this.Column5.Name = "Column5";
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(319, 54);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(93, 29);
            this.btFind.TabIndex = 1;
            this.btFind.Text = "查询";
            this.btFind.UseVisualStyleBackColor = true;
            // 
            // btShowAll
            // 
            this.btShowAll.Location = new System.Drawing.Point(517, 54);
            this.btShowAll.Name = "btShowAll";
            this.btShowAll.Size = new System.Drawing.Size(93, 29);
            this.btShowAll.TabIndex = 2;
            this.btShowAll.Text = "显示全部";
            this.btShowAll.UseVisualStyleBackColor = true;
            // 
            // ComboType
            // 
            this.ComboType.FormattingEnabled = true;
            this.ComboType.Location = new System.Drawing.Point(96, 60);
            this.ComboType.Name = "ComboType";
            this.ComboType.Size = new System.Drawing.Size(121, 23);
            this.ComboType.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(227, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 25);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "查询部门：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTOK);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.labelBuildTime);
            this.groupBox1.Controls.Add(this.labelTel);
            this.groupBox1.Controls.Add(this.labelManager);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.labelCode);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加部门";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(6, 49);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(67, 15);
            this.labelCode.TabIndex = 1;
            this.labelCode.Text = "部门编码";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 98);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(67, 15);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "部门名称";
            // 
            // labelManager
            // 
            this.labelManager.AutoSize = true;
            this.labelManager.Location = new System.Drawing.Point(306, 49);
            this.labelManager.Name = "labelManager";
            this.labelManager.Size = new System.Drawing.Size(52, 15);
            this.labelManager.TabIndex = 3;
            this.labelManager.Text = "负责人";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(6, 147);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(37, 15);
            this.labelTel.TabIndex = 4;
            this.labelTel.Text = "电话";
            // 
            // labelBuildTime
            // 
            this.labelBuildTime.AutoSize = true;
            this.labelBuildTime.Location = new System.Drawing.Point(306, 98);
            this.labelBuildTime.Name = "labelBuildTime";
            this.labelBuildTime.Size = new System.Drawing.Size(67, 15);
            this.labelBuildTime.TabIndex = 5;
            this.labelBuildTime.Text = "成立时间";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(79, 95);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 25);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(79, 144);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 25);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(379, 46);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 25);
            this.textBox5.TabIndex = 9;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(379, 95);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 25);
            this.textBox6.TabIndex = 10;
            // 
            // btDelate
            // 
            this.btDelate.Location = new System.Drawing.Point(418, 54);
            this.btDelate.Name = "btDelate";
            this.btDelate.Size = new System.Drawing.Size(93, 29);
            this.btDelate.TabIndex = 6;
            this.btDelate.Text = "删除";
            this.btDelate.UseVisualStyleBackColor = true;
            // 
            // BTOK
            // 
            this.BTOK.Location = new System.Drawing.Point(309, 144);
            this.BTOK.Name = "BTOK";
            this.BTOK.Size = new System.Drawing.Size(64, 25);
            this.BTOK.TabIndex = 11;
            this.BTOK.Text = "确定";
            this.BTOK.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 475);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "部门信息管理系统";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Windows.Forms.TabControl tabControl1;
        private Windows.Forms.TabPage tabPage1;
        private Windows.Forms.TabPage tabPage2;
        private Windows.Forms.DataGridView dataGridView1;
        private Windows.Forms.DataGridViewTextBoxColumn Column1;
        private Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Windows.Forms.TextBox textBox1;
        private Windows.Forms.ComboBox ComboType;
        private Windows.Forms.Button btShowAll;
        private Windows.Forms.Button btFind;
        private Windows.Forms.Button btDelate;
        private Windows.Forms.Label label1;
        private Windows.Forms.GroupBox groupBox1;
        private Windows.Forms.TextBox textBox6;
        private Windows.Forms.TextBox textBox5;
        private Windows.Forms.TextBox textBox4;
        private Windows.Forms.TextBox textBox3;
        private Windows.Forms.TextBox textBox2;
        private Windows.Forms.Label labelBuildTime;
        private Windows.Forms.Label labelTel;
        private Windows.Forms.Label labelManager;
        private Windows.Forms.Label labelName;
        private Windows.Forms.Label labelCode;
        private Windows.Forms.Button BTOK;
    }
}