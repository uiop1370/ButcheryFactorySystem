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
using System.Windows.Forms.DataVisualization.Charting;

namespace 복사해보기
{
    public partial class Form7 : MetroFramework.Forms.MetroForm
    {
        string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
               "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=hr;Password=hr;";
        // 오라클 연결
        OracleConnection conn;
        // 명령 객체 생성
        OracleCommand cmd;

        public Form7()
        {
            InitializeComponent();
            conn = new OracleConnection(strConn);
            conn.Open();
            cmd = new OracleCommand();
            cmd.Connection = conn;
        }

        //1. 오라클 연결 객체 만들기 - Client
        private void Form7_Load(object sender, EventArgs e)
        {
            cbMonth.Items.Add("1 월");
            cbMonth.Items.Add("2 월");
            cbMonth.Items.Add("3 월");
            cbMonth.Items.Add("4 월");
            cbMonth.Items.Add("5 월");
            cbMonth.Items.Add("6 월");
            cbMonth.Items.Add("7 월");
            cbMonth.Items.Add("8 월");
            cbMonth.Items.Add("9 월");
            cbMonth.Items.Add("10 월");
            cbMonth.Items.Add("11 월");
            cbMonth.Items.Add("12 월");

            chPie.Series.Clear();

            Series chSold = chPie.Series.Add("판매량");
            chPie.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void btnLoad_Click(object sender, EventArgs e)
        {
            chPie.Series["판매량"].Points.Clear();

            if (cbMonth.SelectedIndex == 0)
            {
                cmd.CommandText = "select Pork from MONTH_TABLE where M_NUMBER = 1";
                OracleDataReader rdr01 = cmd.ExecuteReader();
                cmd.CommandText = "select Beef from MONTH_TABLE where M_NUMBER = 1";
                OracleDataReader rdr02 = cmd.ExecuteReader();
                cmd.CommandText = "select Lamb from MONTH_TABLE where M_NUMBER = 1";
                OracleDataReader rdr03 = cmd.ExecuteReader();

                while (rdr01.Read() & rdr02.Read() & rdr03.Read())
                {
                    int a = rdr01.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("돼지고기", a);
                    chPie.Series["판매량"].Points[0].Color = Color.Pink;

                    int b = rdr02.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("소고기", b);
                    chPie.Series["판매량"].Points[1].Color = Color.IndianRed;

                    int c = rdr03.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("양고기", c);
                    chPie.Series["판매량"].Points[2].Color = Color.Ivory;
                }
            }

            else if (cbMonth.SelectedIndex == 1)
            {
                cmd.CommandText = "select Pork from MONTH_TABLE where M_NUMBER = 2";
                OracleDataReader rdr04 = cmd.ExecuteReader();
                cmd.CommandText = "select Beef from MONTH_TABLE where M_NUMBER = 2";
                OracleDataReader rdr05 = cmd.ExecuteReader();
                cmd.CommandText = "select Lamb from MONTH_TABLE where M_NUMBER = 2";
                OracleDataReader rdr06 = cmd.ExecuteReader();

                while (rdr04.Read() & rdr05.Read() & rdr06.Read())
                {
                    int a = rdr04.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("돼지고기", a);
                    chPie.Series["판매량"].Points[0].Color = Color.Pink;

                    int b = rdr05.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("소고기", b);
                    chPie.Series["판매량"].Points[1].Color = Color.IndianRed;

                    int c = rdr06.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("양고기", c);
                    chPie.Series["판매량"].Points[2].Color = Color.Ivory;
                }
            }


            else if (cbMonth.SelectedIndex == 2)
            {
                cmd.CommandText = "select pork from MONTH_TABLE where M_NUMBER = 3";
                OracleDataReader rdr07 = cmd.ExecuteReader();
                cmd.CommandText = "select beef from MONTH_TABLE where M_NUMBER = 3";
                OracleDataReader rdr08 = cmd.ExecuteReader();
                cmd.CommandText = "select lamb from MONTH_TABLE where M_NUMBER = 3";
                OracleDataReader rdr09 = cmd.ExecuteReader();

                while (rdr07.Read() & rdr08.Read() & rdr09.Read())
                {
                    int a = rdr07.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("돼지고기", a);
                    chPie.Series["판매량"].Points[0].Color = Color.Pink;

                    int b = rdr08.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("소고기", b);
                    chPie.Series["판매량"].Points[1].Color = Color.IndianRed;

                    int c = rdr09.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("양고기", c);
                    chPie.Series["판매량"].Points[2].Color = Color.Ivory;
                }
            }


            else if (cbMonth.SelectedIndex == 3)
            {
                cmd.CommandText = "select Pork from MONTH_TABLE where M_NUMBER = 4";
                OracleDataReader rdr10 = cmd.ExecuteReader();
                cmd.CommandText = "select Beef from MONTH_TABLE where M_NUMBER = 4";
                OracleDataReader rdr11 = cmd.ExecuteReader();
                cmd.CommandText = "select Lamb from MONTH_TABLE where M_NUMBER = 4";
                OracleDataReader rdr12 = cmd.ExecuteReader();

                while (rdr10.Read() & rdr11.Read() & rdr12.Read())
                {
                    int a = rdr10.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("돼지고기", a);
                    chPie.Series["판매량"].Points[0].Color = Color.Pink;

                    int b = rdr11.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("소고기", b);
                    chPie.Series["판매량"].Points[1].Color = Color.IndianRed;

                    int c = rdr12.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("양고기", c);
                    chPie.Series["판매량"].Points[2].Color = Color.Ivory;
                }
            }


            else if (cbMonth.SelectedIndex == 4)
            {
                cmd.CommandText = "select pork from MONTH_TABLE where M_NUMBER = 5";
                OracleDataReader rdr013 = cmd.ExecuteReader();
                cmd.CommandText = "select beef from MONTH_TABLE where M_NUMBER = 5";
                OracleDataReader rdr014 = cmd.ExecuteReader();
                cmd.CommandText = "select lamb from MONTH_TABLE where M_NUMBER = 5";
                OracleDataReader rdr015 = cmd.ExecuteReader();

                while (rdr013.Read() & rdr014.Read() & rdr015.Read())
                {
                    int a = rdr013.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("돼지고기", a);
                    chPie.Series["판매량"].Points[0].Color = Color.Pink;

                    int b = rdr014.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("소고기", b);
                    chPie.Series["판매량"].Points[1].Color = Color.IndianRed;

                    int c = rdr015.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("양고기", c);
                    chPie.Series["판매량"].Points[2].Color = Color.Ivory;
                }
            }


            else if (cbMonth.SelectedIndex == 5)
            {
                cmd.CommandText = "select pork from MONTH_TABLE where M_NUMBER = 6";
                OracleDataReader rdr016 = cmd.ExecuteReader();
                cmd.CommandText = "select beef from MONTH_TABLE where M_NUMBER = 6";
                OracleDataReader rdr017 = cmd.ExecuteReader();
                cmd.CommandText = "select lamb from MONTH_TABLE where M_NUMBER = 6";
                OracleDataReader rdr018 = cmd.ExecuteReader();

                while (rdr016.Read() & rdr017.Read() & rdr018.Read()) 
                {
                    int a = rdr016.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("돼지고기", a);
                    chPie.Series["판매량"].Points[0].Color = Color.Pink;

                    int b = rdr017.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("소고기", b);
                    chPie.Series["판매량"].Points[1].Color = Color.IndianRed;

                    int c = rdr018.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("양고기", c);
                    chPie.Series["판매량"].Points[2].Color = Color.Ivory;
                }
            }


            else if (cbMonth.SelectedIndex == 6)
            {
                cmd.CommandText = "select pork from MONTH_TABLE where M_NUMBER = 7";
                OracleDataReader rdr019 = cmd.ExecuteReader();
                cmd.CommandText = "select beef from MONTH_TABLE where M_NUMBER = 7";
                OracleDataReader rdr020 = cmd.ExecuteReader();
                cmd.CommandText = "select lamb from MONTH_TABLE where M_NUMBER = 7";
                OracleDataReader rdr021 = cmd.ExecuteReader();

                while (rdr019.Read() & rdr020.Read() & rdr021.Read()) 
                {
                    int a = rdr019.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("돼지고기", a);
                    chPie.Series["판매량"].Points[0].Color = Color.Pink;

                    int b = rdr020.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("소고기", b);
                    chPie.Series["판매량"].Points[1].Color = Color.IndianRed;

                    int c = rdr021.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("양고기", c);
                    chPie.Series["판매량"].Points[2].Color = Color.Ivory;
                }
            }


            else if (cbMonth.SelectedIndex == 7)
            {
                cmd.CommandText = "select pork from MONTH_TABLE where M_NUMBER = 8";
                OracleDataReader rdr022 = cmd.ExecuteReader();
                cmd.CommandText = "select beef from MONTH_TABLE where M_NUMBER = 8";
                OracleDataReader rdr023 = cmd.ExecuteReader();
                cmd.CommandText = "select lamb from MONTH_TABLE where M_NUMBER = 8";
                OracleDataReader rdr024 = cmd.ExecuteReader();

                while (rdr022.Read() & rdr023.Read() & rdr024.Read())
                {
                    int a = rdr022.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("돼지고기", a);
                    chPie.Series["판매량"].Points[0].Color = Color.Pink;

                    int b = rdr023.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("소고기", b);
                    chPie.Series["판매량"].Points[1].Color = Color.IndianRed;

                    int c = rdr024.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("양고기", c);
                    chPie.Series["판매량"].Points[2].Color = Color.Ivory;
                }
            }


            else if (cbMonth.SelectedIndex == 8)
            {
                cmd.CommandText = "select pork from MONTH_TABLE where M_NUMBER = 9";
                OracleDataReader rdr025 = cmd.ExecuteReader();
                cmd.CommandText = "select beef from MONTH_TABLE where M_NUMBER = 9";
                OracleDataReader rdr026 = cmd.ExecuteReader();
                cmd.CommandText = "select lamb from MONTH_TABLE where M_NUMBER = 9";
                OracleDataReader rdr027 = cmd.ExecuteReader();

                while (rdr025.Read() & rdr026.Read() & rdr027.Read())
                {
                    int a = rdr025.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("돼지고기", a);
                    chPie.Series["판매량"].Points[0].Color = Color.Pink;

                    int b = rdr026.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("소고기", b);
                    chPie.Series["판매량"].Points[1].Color = Color.IndianRed;

                    int c = rdr027.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("양고기", c);
                    chPie.Series["판매량"].Points[2].Color = Color.Ivory;
                }
            }


            else if (cbMonth.SelectedIndex == 9)
            {
                cmd.CommandText = "select pork from MONTH_TABLE where M_NUMBER = 10";
                OracleDataReader rdr028 = cmd.ExecuteReader();
                cmd.CommandText = "select beef from MONTH_TABLE where M_NUMBER = 10";
                OracleDataReader rdr029 = cmd.ExecuteReader();
                cmd.CommandText = "select lamb from MONTH_TABLE where M_NUMBER = 10";
                OracleDataReader rdr030 = cmd.ExecuteReader();

                while (rdr028.Read() & rdr029.Read() & rdr030.Read())
                {
                    int a = rdr028.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("돼지고기", a);
                    chPie.Series["판매량"].Points[0].Color = Color.Pink;

                    int b = rdr029.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("소고기", b);
                    chPie.Series["판매량"].Points[1].Color = Color.IndianRed;

                    int c = rdr030.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("양고기", c);
                    chPie.Series["판매량"].Points[2].Color = Color.Ivory;
                }
            }


            else if (cbMonth.SelectedIndex == 10)
            {
                cmd.CommandText = "select pork from MONTH_TABLE where M_NUMBER = 11";
                OracleDataReader rdr031 = cmd.ExecuteReader();
                cmd.CommandText = "select beef from MONTH_TABLE where M_NUMBER = 11";
                OracleDataReader rdr032 = cmd.ExecuteReader();
                cmd.CommandText = "select lamb from MONTH_TABLE where M_NUMBER = 11";
                OracleDataReader rdr033 = cmd.ExecuteReader();

                while (rdr031.Read() & rdr032.Read() & rdr033.Read())
                {
                    int a = rdr031.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("돼지고기", a);
                    chPie.Series["판매량"].Points[0].Color = Color.Pink;

                    int b = rdr032.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("소고기", b);
                    chPie.Series["판매량"].Points[1].Color = Color.IndianRed;

                    int c = rdr033.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("양고기", c);
                    chPie.Series["판매량"].Points[2].Color = Color.Ivory;
                }
            }


            else if (cbMonth.SelectedIndex == 11)
            {
                cmd.CommandText = "select pork from MONTH_TABLE where M_NUMBER = 12";
                OracleDataReader rdr034 = cmd.ExecuteReader();
                cmd.CommandText = "select beef from MONTH_TABLE where M_NUMBER = 12";
                OracleDataReader rdr035 = cmd.ExecuteReader();
                cmd.CommandText = "select lamb from MONTH_TABLE where M_NUMBER = 12";
                OracleDataReader rdr036 = cmd.ExecuteReader();

                while (rdr034.Read() & rdr035.Read() & rdr036.Read())
                {
                    int a = rdr034.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("돼지고기", a);
                    chPie.Series["판매량"].Points[0].Color = Color.Pink;

                    int b = rdr035.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("소고기", b);
                    chPie.Series["판매량"].Points[1].Color = Color.IndianRed;

                    int c = rdr036.GetInt32(0);
                    chPie.Series["판매량"].Points.AddXY("양고기", c);
                    chPie.Series["판매량"].Points[2].Color = Color.Ivory;
                }
            }
        }
        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chPie_Click(object sender, EventArgs e)
        {
            String a = cbMonth.SelectedItem as String;
            String[] month = a.Split();

            cmd.CommandText = ($"select * from MONTH_TABLE where M_NUMBER = {month[0]}");
            OracleDataReader rdr1000 = cmd.ExecuteReader();
            while (rdr1000.Read())
            {
                string pork_num = rdr1000["pork"].ToString();
                string cow_num = rdr1000["beef"].ToString();
                string sheep_num = rdr1000["lamb"].ToString();
                double n_1 = double.Parse(pork_num) * 100000;
                double n_2 = double.Parse(cow_num) * 200000;
                double n_3 = double.Parse(sheep_num) * 200000;
                MessageBox.Show($"{month[0]}월의 순수익은 \n 돼지고기 : {string.Format("{0:n0}", n_1)}원 \n 소고기 : {string.Format("{0:n0}", n_2)}원 " +
                    $"\n 양고기 : {string.Format("{0:n0}", n_3)}원", "매출액", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
