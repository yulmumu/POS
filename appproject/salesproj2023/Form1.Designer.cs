namespace salesproj2023
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.분류 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.제품명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.판매가격 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.재고갯수 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.유통기한 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.유통기한만료여부 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.prodsearch = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.prodsearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.prodsearch);
            this.tabControl1.Location = new System.Drawing.Point(3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(956, 505);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(948, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "재고관리 메인";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(761, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "재고 추가";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.분류,
            this.제품명,
            this.판매가격,
            this.재고갯수,
            this.유통기한,
            this.유통기한만료여부});
            this.dataGridView1.Location = new System.Drawing.Point(-4, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(937, 358);
            this.dataGridView1.TabIndex = 3;
            // 
            // Num
            // 
            this.Num.HeaderText = "번호";
            this.Num.MinimumWidth = 8;
            this.Num.Name = "Num";
            this.Num.Width = 150;
            // 
            // 분류
            // 
            this.분류.HeaderText = "분류";
            this.분류.MinimumWidth = 8;
            this.분류.Name = "분류";
            this.분류.Width = 150;
            // 
            // 제품명
            // 
            this.제품명.HeaderText = "제품명";
            this.제품명.MinimumWidth = 8;
            this.제품명.Name = "제품명";
            this.제품명.Width = 150;
            // 
            // 판매가격
            // 
            this.판매가격.HeaderText = "판매가격(단위:원)";
            this.판매가격.MinimumWidth = 8;
            this.판매가격.Name = "판매가격";
            this.판매가격.Width = 150;
            // 
            // 재고갯수
            // 
            this.재고갯수.HeaderText = "재고갯수";
            this.재고갯수.MinimumWidth = 8;
            this.재고갯수.Name = "재고갯수";
            this.재고갯수.Width = 150;
            // 
            // 유통기한
            // 
            this.유통기한.HeaderText = "유통기한";
            this.유통기한.MinimumWidth = 8;
            this.유통기한.Name = "유통기한";
            this.유통기한.Width = 150;
            // 
            // 유통기한만료여부
            // 
            this.유통기한만료여부.HeaderText = "유통기한만료여부";
            this.유통기한만료여부.MinimumWidth = 8;
            this.유통기한만료여부.Name = "유통기한만료여부";
            this.유통기한만료여부.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20F);
            this.label1.Location = new System.Drawing.Point(354, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "재고관리";
            // 
            // prodsearch
            // 
            this.prodsearch.Controls.Add(this.comboBox1);
            this.prodsearch.Location = new System.Drawing.Point(4, 28);
            this.prodsearch.Name = "prodsearch";
            this.prodsearch.Padding = new System.Windows.Forms.Padding(3);
            this.prodsearch.Size = new System.Drawing.Size(948, 473);
            this.prodsearch.TabIndex = 1;
            this.prodsearch.Text = "재고검색";
            this.prodsearch.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 26);
            this.comboBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 505);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "재고관리";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.prodsearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage prodsearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn 분류;
        private System.Windows.Forms.DataGridViewTextBoxColumn 제품명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 판매가격;
        private System.Windows.Forms.DataGridViewTextBoxColumn 재고갯수;
        private System.Windows.Forms.DataGridViewTextBoxColumn 유통기한;
        private System.Windows.Forms.DataGridViewTextBoxColumn 유통기한만료여부;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}