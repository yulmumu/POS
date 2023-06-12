namespace salesproj2023
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.type = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prodname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.jaegoamount = new System.Windows.Forms.NumericUpDown();
            this.price = new System.Windows.Forms.NumericUpDown();
            this.prodID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.jaegoamount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10F);
            this.label1.Location = new System.Drawing.Point(168, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "재고코드";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "추가";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // type
            // 
            this.type.Font = new System.Drawing.Font("굴림", 10F);
            this.type.Location = new System.Drawing.Point(340, 62);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(100, 30);
            this.type.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10F);
            this.label2.Location = new System.Drawing.Point(168, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "분류";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // prodname
            // 
            this.prodname.Font = new System.Drawing.Font("굴림", 10F);
            this.prodname.Location = new System.Drawing.Point(340, 98);
            this.prodname.Name = "prodname";
            this.prodname.Size = new System.Drawing.Size(100, 30);
            this.prodname.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10F);
            this.label3.Location = new System.Drawing.Point(168, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "제품명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10F);
            this.label4.Location = new System.Drawing.Point(168, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "판매가격(단위:원)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 10F);
            this.label5.Location = new System.Drawing.Point(168, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "재고갯수";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 10F);
            this.label6.Location = new System.Drawing.Point(168, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "유통기한";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(293, 204);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 28);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // jaegoamount
            // 
            this.jaegoamount.Location = new System.Drawing.Point(340, 170);
            this.jaegoamount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.jaegoamount.Name = "jaegoamount";
            this.jaegoamount.Size = new System.Drawing.Size(120, 28);
            this.jaegoamount.TabIndex = 4;
            this.jaegoamount.ValueChanged += new System.EventHandler(this.jaegoamount_ValueChanged);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(340, 137);
            this.price.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(120, 28);
            this.price.TabIndex = 4;
            this.price.ThousandsSeparator = true;
            this.price.ValueChanged += new System.EventHandler(this.price_ValueChanged);
            // 
            // prodID
            // 
            this.prodID.Font = new System.Drawing.Font("굴림", 10F);
            this.prodID.Location = new System.Drawing.Point(340, 26);
            this.prodID.Name = "prodID";
            this.prodID.Size = new System.Drawing.Size(100, 30);
            this.prodID.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 389);
            this.Controls.Add(this.price);
            this.Controls.Add(this.jaegoamount);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prodname);
            this.Controls.Add(this.prodID);
            this.Controls.Add(this.type);
            this.Name = "Form3";
            this.Text = "재고 추가";
            ((System.ComponentModel.ISupportInitialize)(this.jaegoamount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prodname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown jaegoamount;
        private System.Windows.Forms.NumericUpDown price;
        private System.Windows.Forms.TextBox prodID;
    }
}