using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salesproj2023
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Form1의 인스턴스를 참조로 전달받음
            Form1 form1 = (Form1)Application.OpenForms["Form1"];

            // DataGridView에 값들을 추가
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(form1.dataGridView1);
            row.Cells[0].Value = prodID.Text;
            row.Cells[1].Value = type.Text;
            row.Cells[2].Value = prodname.Text;
            row.Cells[3].Value = price.Value;
            row.Cells[4].Value = jaegoamount.Value;
            row.Cells[5].Value = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            form1.dataGridView1.Rows.Add(row);

            this.Close(); // Form3 닫기
        }

        private void price_ValueChanged(object sender, EventArgs e)
        {

        }

        private void jaegoamount_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
