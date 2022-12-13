using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MydataClient
{
    public partial class MakeKTfile : Form
    {
        public MakeKTfile()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string toMonth = DateTime.Now.ToString("yyyyMM");

            tb_Yyyymmdd.Text = toMonth.Substring(0, 4) + "/" + toMonth.Substring(4, 2);

            string sbPrevText = DateTime.Now.AddMonths(-1).ToString("yyyyMM");

            setValueList(tb_Yyyymmdd.Text);


        }

        private void bt_default_Click(object sender, EventArgs e)
        {
            //내 폴더 위치 불러오기
            string filePath = tb_defaultFld.Text.ToString();
            MessageBox.Show("" + filePath);
            
            if (!System.IO.Directory.Exists(filePath))
            {
                MessageBox.Show("Folder가 없습니다.");
                return;
            }

            FolderBrowserDialog dlg = new FolderBrowserDialog();

            if( dlg.ShowDialog() == DialogResult.OK)
            {
                tb_defaultFld.Text = dlg.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //내 폴더 위치 불러오기
            string filePath = tb_targetFld.Text.ToString();


            if (!System.IO.Directory.Exists(filePath))
            {
                MessageBox.Show("Folder가 없습니다.");
                return;
            }

            FolderBrowserDialog dlg = new FolderBrowserDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tb_targetFld.Text = dlg.SelectedPath;
            }
        }

        private void tb_Yyyymmdd_TextChanged(object sender, EventArgs e)
        {
            string inputValue = tb_Yyyymmdd.Text.Replace("/", "").Replace("-", "");

            if (inputValue.Length < 6 )  return;

            string value = inputValue + "01";

            if (!Util.isYyyyyMMdd(value))
            {
                MessageBox.Show("날짜 입력이 잘못 되었습니다!!");
                return;
            }

            setValueList(inputValue.Substring(0, 4) + "/" + inputValue.Substring(4, 2));

            tb_Yyyymmdd.Text = inputValue.Substring(0, 4) + "/" + inputValue.Substring(4, 2);

        }

        private void setValueList(string dateValue)
        {
            string indateValue = dateValue + "/01";

            DateTime toDate = Convert.ToDateTime(indateValue);

            string sbPrevText = toDate.AddMonths(-1).ToString().Replace("/", "").Replace("-", "").Substring(0, 6);

            tb_defaultFld.Text = "C:\\project\\총산\\" + sbPrevText + "\\KT청구정보\\";
            tb_targetFld.Text = "C:\\project\\총산\\" + dateValue.Replace("/", "").Replace("-", "") + "\\KT청구정보\\";

            tb_srcIa.Text = "IA" + sbPrevText + "_KTTRS_99.dat";
            tb_srcSa.Text = "SA" + sbPrevText + "_KTTRS_99.dat";

            tb_TargetIa.Text = "IA" + dateValue.Replace("/", "").Replace("-", "") + "_KTTRS_99.dat";
            tb_TargetSa.Text = "SA" + dateValue.Replace("/", "").Replace("-", "") + "_KTTRS_99.dat";


        }

        private void btMake_Click(object sender, EventArgs e)
        {
            rtbLog.Text = "";
            convertFileContent("IA" , tb_defaultFld.Text + tb_srcIa.Text, tb_targetFld.Text + tb_TargetIa.Text);
            convertFileContent("SA", tb_defaultFld.Text + tb_srcSa.Text, tb_targetFld.Text + tb_TargetSa.Text);

        }


        private bool convertFileContent(string gubun, string srcfilename, string targfilename)
        {
            logWrite(srcfilename + " ==> " + srcfilename + " convert start!!");

            StreamWriter sw = new StreamWriter(@targfilename, false, Encoding.GetEncoding("euc-kr"));
            sw.NewLine = "\n";
            StreamReader sr = new StreamReader(srcfilename, Encoding.GetEncoding("euc-kr"));

            string preMonth = getPremonth(tb_Yyyymmdd.Text);

            string firstDay = preMonth + "01";
            string lastDay = getPremonthLastday(tb_Yyyymmdd.Text);
            String s = "";
            string w = "";

            while (sr.Peek() >= 0)
            {
                s = sr.ReadLine().ToString();
                
                if ("IA".Equals(gubun))
                {
                    logWrite("0:6 : " + s.Substring(0, 6) + " => " + tb_Yyyymmdd.Text.Replace("/", "").Replace("-", ""));
                    logWrite("55,16: " + s.Substring(55, 16) + " => " + firstDay + lastDay);
                    w = tb_Yyyymmdd.Text.Replace("/", "").Replace("-", "") + s.Substring(6,49) + firstDay + lastDay + s.Substring(71, s.Length - 71);
                    
                } else
                {
                    logWrite("0:6 : " + s.Substring(0, 6) + " => " + tb_Yyyymmdd.Text.Replace("/", "").Replace("-", ""));
                    w = tb_Yyyymmdd.Text.Replace("/", "").Replace("-", "") + s.Substring(6, s.Length - 6);
                }
                sw.WriteLine(w);
            }

            sw.Flush();
            sw.Close();
            sr.Close();

            return true;
        }

        private void logWrite(string logStr)
        {
            rtbLog.Text = rtbLog.Text + logStr + "\n";
        }

        private String getPremonth(string toMonth)
        {
            string month = toMonth.Replace("/", "").Replace("-","");

            string indateValue = month.Substring(0, 4) + "/" + month.Substring(4,2) + "/01";

            DateTime toDate = Convert.ToDateTime(indateValue);

            return toDate.AddMonths(-1).ToString().Replace("/", "").Replace("-", "").Substring(0, 6);
        }

        private String getPremonthLastday(string toMonth)
        {
            string month = toMonth.Replace("/", "").Replace("-", "");

            string indateValue = month.Substring(0, 4) + "/" + month.Substring(4, 2) + "/01";

            DateTime toDate = Convert.ToDateTime(indateValue);
            String preMonth = Convert.ToDateTime(indateValue).AddMonths(-1).ToString().Replace("/", "").Replace("-", "").Substring(0, 6);

            int day = DateTime.DaysInMonth(Convert.ToDateTime(indateValue).AddMonths(-1).Year, Convert.ToDateTime(indateValue).AddMonths(-1).Month);

            return preMonth + string.Format("{0,2:##}", day);

        }
    }
}
