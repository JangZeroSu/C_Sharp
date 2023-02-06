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
    public partial class Create : Form
    {
        /*
        public static string uid = "icdi8";
        public static string password = "";
        public static string database = "code";
        public static string server = "localhost";
        */
        public Create()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string connStr = "SERVER=" + server + ";DATABASE=" + database + ";UID=" + uid + ";PASSWORD=" + password + ";";//위 변수값 적용
            string connStr = "Data Source = DESKTOP-HORR2C3;Initial Catalog=code;Integrated Security=true";
            SqlConnection conn = new SqlConnection(connStr);//DB커넥터
            conn.Open();//DB연결
            string strSql = "INSERT INTO code(code) VALUES(@code)";//DB 값 insert 문으로 넣기
            SqlCommand cmd = new SqlCommand(strSql, conn);//DB 커멘드 실행
            cmd.Parameters.AddWithValue("@code", textBox1.Text); //파라미터로 @code로 textBox1.Text의 값을 전달
            cmd.ExecuteNonQuery();//명령실행
            conn.Close(); //DB담기
            MessageBox.Show("코드가 저장되었습니다.");
            this.Close();
        }

        private void Create_Load(object sender, EventArgs e)
        {

        }
    }
}
