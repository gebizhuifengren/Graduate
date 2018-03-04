namespace GRADUATE.UI
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ReadDataMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveDataMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.InputMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.InputFromExcelMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.InputFromTxtMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportToExcelMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportTosrvMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DataMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ReviewDataMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.rightGroupBox = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.rightGroupBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.DataMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(862, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReadDataMenu,
            this.SaveDataMenu,
            this.InputMenu,
            this.ExportMenu,
            this.ExitMenu});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(58, 21);
            this.FileMenu.Text = "文件(F)";
            // 
            // ReadDataMenu
            // 
            this.ReadDataMenu.Name = "ReadDataMenu";
            this.ReadDataMenu.Size = new System.Drawing.Size(152, 22);
            this.ReadDataMenu.Text = "读入数据(R)";
            // 
            // SaveDataMenu
            // 
            this.SaveDataMenu.Name = "SaveDataMenu";
            this.SaveDataMenu.Size = new System.Drawing.Size(152, 22);
            this.SaveDataMenu.Text = "保存数据(S)";
            // 
            // InputMenu
            // 
            this.InputMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InputFromExcelMenu,
            this.InputFromTxtMenu});
            this.InputMenu.Name = "InputMenu";
            this.InputMenu.Size = new System.Drawing.Size(152, 22);
            this.InputMenu.Text = "导入数据(I)";
            // 
            // InputFromExcelMenu
            // 
            this.InputFromExcelMenu.Name = "InputFromExcelMenu";
            this.InputFromExcelMenu.Size = new System.Drawing.Size(148, 22);
            this.InputFromExcelMenu.Text = "Excel导入";
            // 
            // InputFromTxtMenu
            // 
            this.InputFromTxtMenu.Name = "InputFromTxtMenu";
            this.InputFromTxtMenu.Size = new System.Drawing.Size(148, 22);
            this.InputFromTxtMenu.Text = "文本文件导入";
            // 
            // ExportMenu
            // 
            this.ExportMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportToExcelMenu,
            this.ExportTosrvMenu});
            this.ExportMenu.Name = "ExportMenu";
            this.ExportMenu.Size = new System.Drawing.Size(152, 22);
            this.ExportMenu.Text = "导出数据(O)";
            // 
            // ExportToExcelMenu
            // 
            this.ExportToExcelMenu.Name = "ExportToExcelMenu";
            this.ExportToExcelMenu.Size = new System.Drawing.Size(141, 22);
            this.ExportToExcelMenu.Text = "导出到Excel";
            // 
            // ExportTosrvMenu
            // 
            this.ExportTosrvMenu.Name = "ExportTosrvMenu";
            this.ExportTosrvMenu.Size = new System.Drawing.Size(141, 22);
            this.ExportTosrvMenu.Text = "导出到";
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(152, 22);
            this.ExitMenu.Text = "退出(E)";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // DataMenu
            // 
            this.DataMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReviewDataMenu});
            this.DataMenu.Name = "DataMenu";
            this.DataMenu.Size = new System.Drawing.Size(61, 21);
            this.DataMenu.Text = "数据(D)";
            // 
            // ReviewDataMenu
            // 
            this.ReviewDataMenu.Name = "ReviewDataMenu";
            this.ReviewDataMenu.Size = new System.Drawing.Size(139, 22);
            this.ReviewDataMenu.Text = "查看数据(S)";
            this.ReviewDataMenu.Click += new System.EventHandler(this.ReviewDataMenu_Click);
            // 
            // rightGroupBox
            // 
            this.rightGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.rightGroupBox.Controls.Add(this.groupBox1);
            this.rightGroupBox.Controls.Add(this.groupBox4);
            this.rightGroupBox.Controls.Add(this.textBox1);
            this.rightGroupBox.Controls.Add(this.label13);
            this.rightGroupBox.Controls.Add(this.button1);
            this.rightGroupBox.Controls.Add(this.groupBox3);
            this.rightGroupBox.Controls.Add(this.comboBox5);
            this.rightGroupBox.Controls.Add(this.label12);
            this.rightGroupBox.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rightGroupBox.Location = new System.Drawing.Point(75, 42);
            this.rightGroupBox.Name = "rightGroupBox";
            this.rightGroupBox.Size = new System.Drawing.Size(759, 479);
            this.rightGroupBox.TabIndex = 2;
            this.rightGroupBox.TabStop = false;
            this.rightGroupBox.Text = "SVM离线学习";
            this.rightGroupBox.Enter += new System.EventHandler(this.rightGroupBox_Enter);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 799);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(862, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(245, 17);
            this.toolStripStatusLabel1.Text = "样本总数：3，正常个数：1，肿瘤样本数：2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(18, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "组织：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(18, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "频率：";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "胃",
            "结直肠"});
            this.comboBox3.Location = new System.Drawing.Point(94, 25);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(129, 24);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "42.58MHz"});
            this.comboBox4.Location = new System.Drawing.Point(94, 65);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(129, 24);
            this.comboBox4.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(12, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "参数寻优法：";
            // 
            // comboBox5
            // 
            this.comboBox5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "网格搜索法",
            "改进的网格搜索法",
            "遗传算法",
            "粒子群算法"});
            this.comboBox5.Location = new System.Drawing.Point(133, 171);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(156, 24);
            this.comboBox5.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(340, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(399, 429);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "参数寻优结果图";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 404);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(99, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(1, 228);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "k折交叉验证k值：";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(133, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 26);
            this.textBox1.TabIndex = 13;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox8);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.textBox9);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(4, 338);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(285, 128);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "运行结果";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(184, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(78, 26);
            this.textBox2.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "最优组合（C, g）：";
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(184, 18);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(78, 26);
            this.textBox9.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(59, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "正确率：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(43, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 16);
            this.label15.TabIndex = 2;
            this.label15.Text = "运行时间：";
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(184, 50);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(78, 26);
            this.textBox8.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(18, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 128);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "特征值选取";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(60, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 33);
            this.button2.TabIndex = 12;
            this.button2.Text = "导入数据";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 821);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.rightGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.rightGroupBox.ResumeLayout(false);
            this.rightGroupBox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem InputMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveDataMenu;
        private System.Windows.Forms.ToolStripMenuItem InputFromExcelMenu;
        private System.Windows.Forms.ToolStripMenuItem InputFromTxtMenu;
        private System.Windows.Forms.ToolStripMenuItem ExportMenu;
        private System.Windows.Forms.ToolStripMenuItem ExportToExcelMenu;
        private System.Windows.Forms.ToolStripMenuItem ExportTosrvMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem ReadDataMenu;
        private System.Windows.Forms.ToolStripMenuItem DataMenu;
        private System.Windows.Forms.ToolStripMenuItem ReviewDataMenu;
        private System.Windows.Forms.GroupBox rightGroupBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label15;
    }
}