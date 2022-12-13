using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

using MydataClient;

namespace WindowsFormsApp1
{
    public partial class MydataWindow : Form
    {
        public MydataWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String sqlText = " SELECT IPIN_CI AS CI, COUNT(*) SAID_CNT \n" +
                             " FROM   (                                \n" +
                             "        SELECT /*+USE_HASH(A B) */       \n" +
                             "               DISTINCT IPIN_CI, B.SVC_CNTR_NO SVC_CNTR_NO \n" +
                             "        FROM   JUO_CUS_INFO A            \n" +
                             "             , JUO_SUB_INFO B            \n" +
                             "        WHERE  A.CUSTOMER_ID = B.CUSTOMER_ID \n" +
                             "        AND    A.IPIN_CI IS NOT NULL         \n" +
                             "        ) A                              \n" +
                             "      , TB_CSAKTFBAN C                   \n" +
                             "      , TB_CSASASTAT D                   \n" +
                             " WHERE  C.SVC_CNTR_NO = A.SVC_CNTR_NO    \n" +
                             " AND    C.SA_ID = D.SA_ID                \n" +
                             " AND    D.APPLY_EXPIR_DATE = TO_DATE('99991231235959', 'YYYYMMDDHH24MISS') \n" +
                             " AND    CLOSE_DATE IS NULL               \n" +
                             " GROUP  BY IPIN_CI                       \n" +
                             " ORDER  BY COUNT(*) DESC";

            executeQry(sqlText, dataGridView1);

            if (dataGridView1.RowCount > 0)
            {
                setCiText(dataGridView1.Rows[0].Cells[0].Value.ToString());
                dataGridView1.Columns[0].Width = 700;
                dataGridView1.Columns[1].Width = 100;
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Conf.close();
            ClientMsg.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            tb_ci.Text = (String)dataGridView1.Rows[index].Cells[0].Value;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string messageType = comboBox1.SelectedItem.ToString().Substring(0,2);

            switch (messageType)
            {

                case "ID":
                    gb_IL.Visible = false;
                    gb_IB.Visible = false;
                    gb_IT.Visible = false;
                    break;

                case "IB":
                    gb_IL.Visible = false;
                    gb_IB.Visible = true;
                    gb_IT.Visible = false;
                    break;

                case "IL":
                    gb_IL.Visible = true;
                    gb_IB.Visible = false;
                    gb_IT.Visible = false;
                    rtb_reqMsg.Text = getILMsg();
                    break;

                case "IS":
                    gb_IL.Visible = false;
                    gb_IB.Visible = false;
                    gb_IT.Visible = false;
                    break;

                case "IT":
                    gb_IL.Visible = false;
                    gb_IB.Visible = false;
                    gb_IT.Visible = true;
                    break;

                default:
                    break;
            }

            //string.Format("선택한 메시지 길이: {0:00#}",str.Substring(0, 2).Length));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            gb_IB.Location = gb_IL.Location;
            gb_IT.Location = gb_IL.Location;
            string strdate = DateTime.Now.ToString("yyyyMM");
            string oneyearBefore = DateTime.Now.AddYears(-1).AddMonths(1).ToString("yyyyMM");
            tb_fromPmtMonth.Text = tb_toPmtMonth.Text =  tb_toInvMonth.Text = strdate;
            tb_fromInvMonth.Text = oneyearBefore;


        }

        private void bt_reqSaid_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("CI가 조회되지 않았습니다!");
                return;
            }

            tb_said.Text = "";
            int index = dataGridView1.CurrentCell.RowIndex;
            String  ci = (String)dataGridView1.Rows[index].Cells[0].Value;

            string sqlText = new StringBuilder().Append(" SELECT D.SA_ID  \n")
                             .Append(" FROM   (                                \n")
                             .Append("        SELECT              \n")
                             .Append("               DISTINCT IPIN_CI, B.SVC_CNTR_NO SVC_CNTR_NO \n")
                             .Append("        FROM   JUO_CUS_INFO A            \n")
                             .Append("             , JUO_SUB_INFO B            \n")
                             .Append("        WHERE  A.CUSTOMER_ID = B.CUSTOMER_ID \n")
                             .Append("        AND    A.IPIN_CI  =  \'").Append(ci).Append("\' \n")
                             .Append("        ) A                              \n")
                             .Append("      , TB_CSAKTFBAN C                   \n")
                             .Append("      , TB_CSASASTAT D                   \n")
                             .Append(" WHERE  C.SVC_CNTR_NO = A.SVC_CNTR_NO    \n")
                             .Append(" AND    C.SA_ID = D.SA_ID                \n")
                             .Append(" AND    D.APPLY_EXPIR_DATE = TO_DATE('99991231235959', 'YYYYMMDDHH24MISS') \n")
                             .Append(" AND    CLOSE_DATE IS NULL               \n").ToString();


            executeQry(sqlText, dataGridView2);

            if(dataGridView2.RowCount > 0)
            {
                tb_said.Text = dataGridView2.Rows[0].Cells[0].Value.ToString();
                dataGridView2.Columns[0].Width = 200;

            }

        }

        private bool executeQry(string sqlQuery, DataGridView dgView)
        {

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Clipboard.SetText(sqlQuery);
            }
            catch(Exception ex)
            {
            }

            try
            {

                OracleConnection conn = Conf.getConnection();

                OracleDataAdapter adapt = new OracleDataAdapter();

                adapt.SelectCommand = new System.Data.OracleClient.OracleCommand(sqlQuery, conn);

                DataSet ds = new DataSet();
                adapt.Fill(ds);
                dgView.DataSource = ds.Tables[0].DefaultView;

                //dgView.AutoResizeColumns();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

            return true;
        }

        private void bt_CreateMsg_Click(object sender, EventArgs e)
        {
            string messageType = comboBox1.Text.Substring(0,2).Trim();

            switch(messageType)
            {
                case "ID":
                    rtb_reqMsg.Text = getIDMsg();
                    break;

                case "IB" :
                    rtb_reqMsg.Text = getIBMsg();
                    break;

                case "IL":
                    rtb_reqMsg.Text = getILMsg();
                    break;

                case "IS":
                    rtb_reqMsg.Text = getISMsg();
                    break;

                case "IT":
                    rtb_reqMsg.Text = getITMsg();
                    break;

                default:
                    break;
            }

        }

        private string getILMsg()
        {
            DateTime toDay = DateTime.Now;

            string msg = new StringBuilder().Append("IL")
                             .Append("IDPT")
                             .Append(String.Format("{0:yMMddHmmss}0001", toDay))
                             .Append(tb_ci.Text.ToString())
                             .Append(String.Format("{0,3}", tb_reqCnt.Text).Replace(" ", "0"))
                             .Append(String.Format("{0,4}",tb_remainCnt.Text)).ToString();

            return msg;
        }

        private string getIDMsg()
        {
            DateTime toDay = DateTime.Now;

            string msg = new StringBuilder().Append("ID")
                             .Append("IDPT")
                             .Append(String.Format("{0:yMMddHmmss}0001", toDay))
                             .Append(tb_ci.Text.ToString()).ToString();

            return msg;
        }

        private string getISMsg()
        {
            DateTime toDay = DateTime.Now;

            string msg = new StringBuilder().Append("IS")
                             .Append("IDPT")
                             .Append(String.Format("{0:yMMddHmmss}0001", toDay))
                             .ToString();

            return msg;
        }

        private string getIBMsg()
        {
            DateTime toDay = DateTime.Now;

            if(tb_fromInvMonth.Text.Length != 6 )
            {
                MessageBox.Show("시작청구년월이 맞지 않습니다.!");
                tb_fromInvMonth.Focus();
                return "";
            }

            if (tb_toInvMonth.Text.Length != 6)
            {
                MessageBox.Show("종료청구년월이 맞지 않습니다.!");
                tb_fromInvMonth.Focus();
                return "";
            }

            if (tb_toInvMonth.Text.CompareTo(tb_fromInvMonth.Text) < 0 )
            {
                MessageBox.Show("종료청구년월이 시작청구년월 보다 작습니다!");
                tb_fromInvMonth.Focus();
                return "";
            }

            if (dataGridView2.RowCount == 0)
            {
                MessageBox.Show("가입계약이 조회되지 않았습니다.");
                bt_reqSaid.Focus();
                return "";
            }

            if (tb_said.Text.Length == 0)
            {
                MessageBox.Show("가입계약이 선택되지 않았습니다.");
                dataGridView2.Focus();
                return "";
            }

            string msg = new StringBuilder().Append("IB")
                             .Append("IDPT")
                             .Append(String.Format("{0:yMMddHmmss}0001", toDay))
                             .Append(tb_ci.Text.ToString())
                             .Append(String.Format("{0,-15}", tb_said.Text.ToString()))
                             .Append(tb_fromInvMonth.Text.ToString())
                             .Append(tb_toInvMonth.Text.ToString())
                             .ToString();
            return msg;
        }

        private string getITMsg()
        {
            DateTime toDay = DateTime.Now;

            if (tb_fromPmtMonth.Text.Length != 6)
            {
                MessageBox.Show("시작수납년월이 맞지 않습니다.!");
                tb_fromInvMonth.Focus();
                return "";
            }

            if (tb_toPmtMonth.Text.Length != 6)
            {
                MessageBox.Show("종료수납년월이 맞지 않습니다.!");
                tb_fromInvMonth.Focus();
                return "";
            }

            if (dataGridView2.RowCount == 0)
            {
                MessageBox.Show("가입계약이 조회되지 않았습니다.");
                bt_reqSaid.Focus();
                return "";
            }

            if (tb_said.Text.Length == 0)
            {
                MessageBox.Show("가입계약이 선택되지 않았습니다.");
                dataGridView2.Focus();
                return "";
            }

            string msg = new StringBuilder().Append("IT")
                             .Append("IDPT")
                             .Append(String.Format("{0:yMMddHmmss}0001", toDay))
                             .Append(tb_ci.Text.ToString())
                             .Append(String.Format("{0,-15}", tb_said.Text.ToString()))
                             .Append(tb_fromPmtMonth.Text.ToString())
                             .Append(tb_toPmtMonth.Text.ToString())
                             .ToString();
            return msg;
        }

        private void setCiText(String ci)
        {
            tb_ci.Text = ci;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if( rtb_reqMsg.Text.ToString().Length == 0 )
            {
                MessageBox.Show("전문이 설정되지 않았습니다!!!");
            }

            rtb_rcvMsg.Text = rtb_rcvMsg.Text.ToString() + TcpClientMsg.SendAndRecieve(rtb_reqMsg.Text.ToString());
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView2.CurrentCell.RowIndex;
            tb_said.Text = (String)dataGridView2.Rows[index].Cells[0].Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rtb_rcvMsg.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MakeKTfile form = new MakeKTfile();
            form.Show();
        }
    }
}
