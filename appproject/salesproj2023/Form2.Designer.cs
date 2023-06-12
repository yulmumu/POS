namespace salesproj2023
{
    partial class login
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
            this.IDtbox = new System.Windows.Forms.TextBox();
            this.pwdTbox = new System.Windows.Forms.TextBox();
            this.IDlabel = new System.Windows.Forms.Label();
            this.pwdlabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IDtbox
            // 
            this.IDtbox.Location = new System.Drawing.Point(355, 108);
            this.IDtbox.Name = "IDtbox";
            this.IDtbox.Size = new System.Drawing.Size(126, 28);
            this.IDtbox.TabIndex = 0;
            this.IDtbox.TextChanged += new System.EventHandler(this.IDtbox_TextChanged);
            // 
            // pwdTbox
            // 
            this.pwdTbox.Location = new System.Drawing.Point(355, 169);
            this.pwdTbox.Name = "pwdTbox";
            this.pwdTbox.PasswordChar = '*';
            this.pwdTbox.Size = new System.Drawing.Size(126, 28);
            this.pwdTbox.TabIndex = 1;
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Font = new System.Drawing.Font("굴림", 13F);
            this.IDlabel.Location = new System.Drawing.Point(242, 111);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(90, 26);
            this.IDlabel.TabIndex = 2;
            this.IDlabel.Text = "아이디";
            this.IDlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // pwdlabel
            // 
            this.pwdlabel.AutoSize = true;
            this.pwdlabel.Font = new System.Drawing.Font("굴림", 13F);
            this.pwdlabel.Location = new System.Drawing.Point(242, 169);
            this.pwdlabel.Name = "pwdlabel";
            this.pwdlabel.Size = new System.Drawing.Size(116, 26);
            this.pwdlabel.TabIndex = 2;
            this.pwdlabel.Text = "비밀번호";
            this.pwdlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 86);
            this.button1.TabIndex = 3;
            this.button1.Text = "로그인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pwdlabel);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.pwdTbox);
            this.Controls.Add(this.IDtbox);
            this.Name = "login";
            this.Text = "로그인창";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDtbox;
        private System.Windows.Forms.TextBox pwdTbox;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label pwdlabel;
        private System.Windows.Forms.Button button1;
    }
}