using MySql.Data.MySqlClient;
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
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }

        private DataTable dataTable = new DataTable();

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateExpiryStatusColumn();
        }

        public void UpdateExpiryStatusColumn()
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }

            int expiryDateColumnIndex = 5; // 유통기한이 있는 열의 인덱스
            int expiryStatusColumnIndex = 6; // 유통기한 OX 비교하는 열의 인덱스

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[expiryDateColumnIndex].Value != null)
                {
                    DateTime expiryDate = Convert.ToDateTime(row.Cells[expiryDateColumnIndex].Value);
                    string expiryStatus = expiryDate < DateTime.Now ? "O 폐기대상" : "X";

                    row.Cells[expiryStatusColumnIndex].Value = expiryStatus;
                }
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            //LoadDataToDataGridView();
            UpdateExpiryStatusColumn();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //LoadDataToDataGridView();
            UpdateExpiryStatusColumn();
        }

        

// ...

private void LoadDataToDataGridView()
    {
        string connectionString = "server=cs-dept.esm.kr;port=23306;database=lwy1214;user=lwy1214;password=1214;";
            MySqlConnection connection = new MySqlConnection(connectionString);

        string query = "SELECT * FROM shopkeeper";
        MySqlCommand command = new MySqlCommand(query, connection);

        try
        {
            connection.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }
        catch (Exception ex)
        {
            // 에러 처리
        }
        finally
        {
            connection.Close();
        }
    }

}
}
