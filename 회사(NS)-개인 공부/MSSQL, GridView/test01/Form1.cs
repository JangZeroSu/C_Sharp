using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbtest01
{
    public partial class Form1 : Form
    {
        /*
        public static string uid = "icdi8";
        public static string password = "";
        public static string database = "code";
        public static string server = "localhost";
        */

        public Form1()
        {
            InitializeComponent();
        }

        public string LoginCode
        {
            get;
            private set;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool loginOF = false; //code 여부(초기는 부정)
            //string connStr = "server=" + server + ";DATABASE=" + database + ";UID=" + uid + ";PASSWORD=" + password + ";";//위에서 선언한 변수값 적용
            string connStr = "Data Source = DESKTOP-HORR2C3;Initial Catalog=code;Integrated Security=true";
            SqlConnection conn = new SqlConnection(connStr);//connStr값을 conn으로 반환하여 넣어줌
            conn.Open();//DB연결
            if (textBox1.Text != "")//텍스트가 공백이 아닐때
            {
                string sql = "SELECT * FROM CODE"; //쿼리문
                SqlCommand cmd = new SqlCommand(sql, conn);//new Sqlcommand(쿼리문, 연결문(Sqlconnection에서 선언한 conn))
                SqlDataReader reader = cmd.ExecuteReader();//데이터 읽기

                while (reader.Read())//while 문으로 일치하는 데이터 탐색
                {
                    if (textBox1.Text == (string)reader["code"]) //텍스트 박스와 db가 일치하면 form2가 켜짐
                    {
                        loginOF = true;//code 여부 (긍정)
                        MessageBox.Show("인증 완료");
                        Form2 f2 = new Form2();
                        f2.Show();
                    }
                }
                reader.Close();

                if (textBox1.Text == "Create")//textBox1.Text가 Create 라고 적혔을 때
                {
                    Create cr = new Create();
                    cr.Show();
                }
                else if (loginOF)//로그인 성공 시
                {
                    this.LoginCode = this.textBox1.Text;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("코드를 입력");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds = GetData();

            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
        private DataSet GetData()
        {
            string connStr = "Data Source = DESKTOP-HORR2C3;Initial Catalog=code;Integrated Security=true";
            SqlConnection conn = new SqlConnection(connStr);//connStr값을 conn으로 반환하여 넣어줌
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM CODE", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }
    }
}
