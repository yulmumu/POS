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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = IDtbox.Text;
            string password = pwdTbox.Text;

            // 사용자 이름과 비밀번호를 서버 또는 데이터베이스에서 가져와 비교합니다.
            if (username == "test" && password == "1234")
            {
                // 인증에 성공한 경우
                MessageBox.Show("로그인에 성공했습니다.");

                // 재고관리 메인 폼을 열거나 다음 동작을 수행합니다.
                Form1 inventoryForm = new Form1(); // InventoryManagementForm 대신 Form1로 변경
                inventoryForm.Show();
                this.Hide();

            }
            else
            {
                // 인증에 실패한 경우
                MessageBox.Show("로그인에 실패했습니다. 올바른 사용자 이름과 비밀번호를 입력하세요.");
            }
        }

        private void IDtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
