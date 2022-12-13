using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.OracleClient;

namespace WindowsFormsApp1
{
    public class Conf
    {
        private static OracleConnection conn = null;

        public static OracleConnection  getConnection()
        {
            if (conn == null)
            {
                string oracleSid = ConfigurationManager.AppSettings["oracleSID"];
                string szConnectString = String.Format("Data Source={0};User Id=pcbscust;Password=cust_7pass", oracleSid);
                MessageBox.Show(szConnectString);
                // conn = new OracleConnection("Data Source=NCUSTDEV;User Id=pcbscust;Password=cust_7pass");
                conn = new OracleConnection(szConnectString);
                conn.Open();
            }

            return conn;

        }

        public static void close()
        {
            if(conn != null )
            {
                conn.Close();
            }
        }
    }
}
