using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        OracleCommand cmd = new OracleCommand();
        OracleConnection conn = new OracleConnection(strConn);
        static string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
                                "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=hr ;Password=hr;";

        private void button1_Click(object sender, EventArgs e)
        {
            //string A = "select PD.PMName as 재고명, SUM(s.StQty) as 수량, PD.PMUnit as 단위 from PdMaster PD join Stock S on PD.PMid = S.PMId " +
            //"GROUP BY PD.PMName, PD.PMUnit order by PMUnit desc";

            string A = "select PMNAME as 종류, SUM(PMUPH) as 량, PMUNIT as 단위 from PdMaster group by PMNAME, PMUNIT";

            OracleDataAdapter adapt = new OracleDataAdapter();
            adapt.SelectCommand = new OracleCommand(A, conn);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
