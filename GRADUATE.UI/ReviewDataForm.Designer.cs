namespace GRADUATE.UI
{
    partial class ReviewDataForm
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
            this.ExampleNameCbo = new System.Windows.Forms.ComboBox();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TissuenCbo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SickTypeCbo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.SuspendLayout();
            // 
            // ExampleNameCbo
            // 
            this.ExampleNameCbo.FormattingEnabled = true;
            this.ExampleNameCbo.Location = new System.Drawing.Point(93, 26);
            this.ExampleNameCbo.Name = "ExampleNameCbo";
            this.ExampleNameCbo.Size = new System.Drawing.Size(121, 20);
            this.ExampleNameCbo.TabIndex = 0;
            // 
            // DataView
            // 
            this.DataView.AllowUserToAddRows = false;
            this.DataView.AllowUserToDeleteRows = false;
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Location = new System.Drawing.Point(20, 60);
            this.DataView.Name = "DataView";
            this.DataView.ReadOnly = true;
            this.DataView.RowTemplate.Height = 23;
            this.DataView.Size = new System.Drawing.Size(1156, 667);
            this.DataView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "病例姓名：";
            // 
            // TissuenCbo
            // 
            this.TissuenCbo.FormattingEnabled = true;
            this.TissuenCbo.Location = new System.Drawing.Point(291, 26);
            this.TissuenCbo.Name = "TissuenCbo";
            this.TissuenCbo.Size = new System.Drawing.Size(121, 20);
            this.TissuenCbo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "组织名称：";
            // 
            // SickTypeCbo
            // 
            this.SickTypeCbo.FormattingEnabled = true;
            this.SickTypeCbo.Location = new System.Drawing.Point(489, 26);
            this.SickTypeCbo.Name = "SickTypeCbo";
            this.SickTypeCbo.Size = new System.Drawing.Size(121, 20);
            this.SickTypeCbo.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "病变类型：";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(640, 23);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 3;
            this.SearchBtn.Text = "查询";
            this.SearchBtn.UseVisualStyleBackColor = true;
            // 
            // ReviewDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 741);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.SickTypeCbo);
            this.Controls.Add(this.TissuenCbo);
            this.Controls.Add(this.ExampleNameCbo);
            this.Name = "ReviewDataForm";
            this.Text = "ReviewDataForm";
            this.Load += new System.EventHandler(this.ReviewDataForm_Load);
            this.SizeChanged += new System.EventHandler(this.ReviewDataForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ExampleNameCbo;
        private System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TissuenCbo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SickTypeCbo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SearchBtn;
    }
}