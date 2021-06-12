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

namespace 복사해보기
{
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        //Form8 form8;
        string a = "";
        public delegate void FormSendDataHandler(string sendstring);
        public event FormSendDataHandler FormSendEvent;
        string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=hr;Password=hr;";

        //1. 오라클 연결 객체 만들기 - Client

        OracleConnection conn;
        OracleCommand cmd;


        public Form3()
        {
            InitializeComponent();
            conn = new OracleConnection(strConn);
            conn.Open();
            cmd = new OracleCommand();
            cmd.Connection = conn;

        }

        private void Form1_Load(object sender, EventArgs e) //아이템추가
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
            cbMeat.Items.Add("PORK");
            cbMeat.Items.Add("BEEF");
            cbMeat.Items.Add("LAMB");
        }

        private void metroButton1_Click(object sender, EventArgs e) //닫기
        {
            this.FormSendEvent("oraclesearch");
        }

        private void txtOrderNum_Click(object sender, EventArgs e)
        {
        }
        private void cbMeat_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void metroButton1_Click_1(object sender, EventArgs e) //주문종류 및 갯수 확인
        {
            //form8 = new Form8();
            //form8.Show();
            cmd.CommandText = "select amount from PRODUCT_TABLE where id = 101";
            OracleDataReader rdr1 = cmd.ExecuteReader();
            cmd.CommandText = "select amount from PRODUCT_TABLE where id = 102";
            OracleDataReader rdr2 = cmd.ExecuteReader();
            cmd.CommandText = "select amount from PRODUCT_TABLE where id = 103";
            OracleDataReader rdr3 = cmd.ExecuteReader();
            cmd.CommandText = "select amount from PRODUCT_TABLE where id = 104";
            OracleDataReader rdr4 = cmd.ExecuteReader();
            cmd.CommandText = "select amount from PRODUCT_TABLE where id = 201";
            OracleDataReader rdr5 = cmd.ExecuteReader();
            cmd.CommandText = "select amount from PRODUCT_TABLE where id = 202";
            OracleDataReader rdr6 = cmd.ExecuteReader();
            cmd.CommandText = "select amount from PRODUCT_TABLE where id = 203";
            OracleDataReader rdr7 = cmd.ExecuteReader();
            cmd.CommandText = "select amount from PRODUCT_TABLE where id = 204";
            OracleDataReader rdr8 = cmd.ExecuteReader();
            cmd.CommandText = "select amount from PRODUCT_TABLE where id = 301";
            OracleDataReader rdr9 = cmd.ExecuteReader();
            cmd.CommandText = "select amount from PRODUCT_TABLE where id = 302";
            OracleDataReader rdr10 = cmd.ExecuteReader();
            cmd.CommandText = "select amount from PRODUCT_TABLE where id = 303";
            OracleDataReader rdr11 = cmd.ExecuteReader();
            cmd.CommandText = "select amount from PRODUCT_TABLE where id = 304";
            OracleDataReader rdr12 = cmd.ExecuteReader();


            cmd.CommandText = "select pork from MONTH_TABLE where M_NUMBER = 1";
            OracleDataReader rdr01 = cmd.ExecuteReader();
            cmd.CommandText = "select beef from MONTH_TABLE where M_NUMBER = 1";
            OracleDataReader rdr02 = cmd.ExecuteReader();
            cmd.CommandText = "select lamb from MONTH_TABLE where M_NUMBER = 1";
            OracleDataReader rdr03 = cmd.ExecuteReader();

            cmd.CommandText = "select pork from MONTH_TABLE where M_NUMBER = 2";
            OracleDataReader rdr04 = cmd.ExecuteReader();
            cmd.CommandText = "select beef from MONTH_TABLE where M_NUMBER = 2";
            OracleDataReader rdr05 = cmd.ExecuteReader();
            cmd.CommandText = "select lamb from MONTH_TABLE where M_NUMBER = 2";
            OracleDataReader rdr06 = cmd.ExecuteReader();

            cmd.CommandText = "select pork from MONTH_TABLE where M_NUMBER = 3";
            OracleDataReader rdr07 = cmd.ExecuteReader();
            cmd.CommandText = "select beef from MONTH_TABLE where M_NUMBER = 3";
            OracleDataReader rdr08 = cmd.ExecuteReader();
            cmd.CommandText = "select lamb from MONTH_TABLE where M_NUMBER = 3";
            OracleDataReader rdr09 = cmd.ExecuteReader();

            cmd.CommandText = "select pork from MONTH_TABLE where M_NUMBER = 4";
            OracleDataReader rdr010 = cmd.ExecuteReader();
            cmd.CommandText = "select beef from MONTH_TABLE where M_NUMBER = 4";
            OracleDataReader rdr011 = cmd.ExecuteReader();
            cmd.CommandText = "select lamb from MONTH_TABLE where M_NUMBER = 4";
            OracleDataReader rdr012 = cmd.ExecuteReader();

            cmd.CommandText = "select pork from MONTH_TABLE where M_NUMBER = 5";
            OracleDataReader rdr013 = cmd.ExecuteReader();
            cmd.CommandText = "select beef from MONTH_TABLE where M_NUMBER = 5";
            OracleDataReader rdr014 = cmd.ExecuteReader();
            cmd.CommandText = "select lamb from MONTH_TABLE where M_NUMBER = 5";
            OracleDataReader rdr015 = cmd.ExecuteReader();

            cmd.CommandText = "select pork from MONTH_TABLE where M_NUMBER = 6";
            OracleDataReader rdr016 = cmd.ExecuteReader();
            cmd.CommandText = "select beef from MONTH_TABLE where M_NUMBER = 6";
            OracleDataReader rdr017 = cmd.ExecuteReader();
            cmd.CommandText = "select lamb from MONTH_TABLE where M_NUMBER = 6";
            OracleDataReader rdr018 = cmd.ExecuteReader();

            cmd.CommandText = "select pork from MONTH_TABLE where M_NUMBER = 7";
            OracleDataReader rdr019 = cmd.ExecuteReader();
            cmd.CommandText = "select beef from MONTH_TABLE where M_NUMBER = 7";
            OracleDataReader rdr020 = cmd.ExecuteReader();
            cmd.CommandText = "select lamb from MONTH_TABLE where M_NUMBER = 7";
            OracleDataReader rdr021 = cmd.ExecuteReader();

            cmd.CommandText = "select pork from MONTH_TABLE where M_NUMBER = 8";
            OracleDataReader rdr022 = cmd.ExecuteReader();
            cmd.CommandText = "select beef from MONTH_TABLE where M_NUMBER = 8";
            OracleDataReader rdr023 = cmd.ExecuteReader();
            cmd.CommandText = "select lamb from MONTH_TABLE where M_NUMBER = 8";
            OracleDataReader rdr024 = cmd.ExecuteReader();

            cmd.CommandText = "select pork from MONTH_TABLE where M_NUMBER = 9";
            OracleDataReader rdr025 = cmd.ExecuteReader();
            cmd.CommandText = "select beef from MONTH_TABLE where M_NUMBER = 9";
            OracleDataReader rdr026 = cmd.ExecuteReader();
            cmd.CommandText = "select lamb from MONTH_TABLE where M_NUMBER = 9";
            OracleDataReader rdr027 = cmd.ExecuteReader();

            cmd.CommandText = "select pork from MONTH_TABLE where M_NUMBER = 10";
            OracleDataReader rdr028 = cmd.ExecuteReader();
            cmd.CommandText = "select beef from MONTH_TABLE where M_NUMBER = 10";
            OracleDataReader rdr029 = cmd.ExecuteReader();
            cmd.CommandText = "select lamb from MONTH_TABLE where M_NUMBER = 10";
            OracleDataReader rdr030 = cmd.ExecuteReader();

            cmd.CommandText = "select pork from MONTH_TABLE where M_NUMBER = 11";
            OracleDataReader rdr031 = cmd.ExecuteReader();
            cmd.CommandText = "select beef from MONTH_TABLE where M_NUMBER = 11";
            OracleDataReader rdr032 = cmd.ExecuteReader();
            cmd.CommandText = "select lamb from MONTH_TABLE where M_NUMBER = 11";
            OracleDataReader rdr033 = cmd.ExecuteReader();

            cmd.CommandText = "select pork from MONTH_TABLE where M_NUMBER = 12";
            OracleDataReader rdr034 = cmd.ExecuteReader();
            cmd.CommandText = "select beef from MONTH_TABLE where M_NUMBER = 12";
            OracleDataReader rdr035 = cmd.ExecuteReader();
            cmd.CommandText = "select lamb from MONTH_TABLE where M_NUMBER = 12";
            OracleDataReader rdr036 = cmd.ExecuteReader();



            cmd.CommandText = "select * from MONTH_TABLE";
            OracleDataReader rdr100 = cmd.ExecuteReader();



            String txt = cbMeat.SelectedItem as String;
            String a = cbMonth.SelectedItem as String;
            String[] month = a.Split();
            int ODNum = int.Parse(txtOrderNum.Text); //주문수량
            if (ODNum <= 10)
            {
                if (cbMeat.SelectedIndex == 0)
                {

                    while (rdr1.Read())
                    {
                        int AMOUNT1 = rdr1.GetInt32(0);
                        int Result = AMOUNT1 - ODNum;

                        cmd.CommandText = $"UPDATE PRODUCT_TABLE SET AMOUNT = {Result} where id = 101";
                        cmd.ExecuteNonQuery();
                    }
                    while (rdr2.Read())
                    {
                        int AMOUNT1 = rdr2.GetInt32(0);
                        int Result = AMOUNT1 - ODNum;

                        cmd.CommandText = $"UPDATE PRODUCT_TABLE SET AMOUNT = {Result} where id = 102";
                        cmd.ExecuteNonQuery();
                    }
                    while (rdr3.Read())
                    {
                        int AMOUNT1 = rdr3.GetInt32(0);
                        int Result = AMOUNT1 - ODNum;
                        cmd.CommandText = $"UPDATE PRODUCT_TABLE SET AMOUNT = {Result} where id = 103";
                        cmd.ExecuteNonQuery();
                    }
                    while (rdr4.Read())
                    {
                        int AMOUNT1 = rdr4.GetInt32(0);
                        int Result = AMOUNT1 - ODNum;
                        cmd.CommandText = $"UPDATE PRODUCT_TABLE SET AMOUNT = {Result} where id = 104";
                        cmd.ExecuteNonQuery();
                    }
                    if (month[0] == "1")
                        while (rdr01.Read())
                        {
                            int AMOUNT2 = rdr01.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery();
                        }
                    else if (month[0] == "2")
                        while (rdr04.Read())
                        {
                            int AMOUNT2 = rdr04.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery();
                        }
                    else if (month[0] == "3")
                        while (rdr07.Read())
                        {
                            int AMOUNT2 = rdr07.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery(); ;
                        }
                    else if (month[0] == "4")
                        while (rdr010.Read())
                        {
                            int AMOUNT2 = rdr010.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery();
                        }
                    else if (month[0] == "5")
                        while (rdr013.Read())
                        {
                            int AMOUNT2 = rdr013.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery();
                        }
                    else if (month[0] == "6")
                        while (rdr016.Read())
                        {
                            int AMOUNT2 = rdr016.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery();
                        }
                    else if (month[0] == "7")
                        while (rdr019.Read())
                        {
                            int AMOUNT2 = rdr019.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery();
                        }
                    else if (month[0] == "8")
                        while (rdr022.Read())
                        {
                            int AMOUNT2 = rdr022.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery();
                        }
                    else if (month[0] == "9")
                        while (rdr025.Read())
                        {
                            int AMOUNT2 = rdr025.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery();

                        }
                    else if (month[0] == "10")
                        while (rdr028.Read())
                        {
                            int AMOUNT2 = rdr028.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery();
                        }
                    else if (month[0] == "11")
                        while (rdr031.Read())
                        {
                            int AMOUNT2 = rdr031.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery();
                        }
                    else if (month[0] == "12")
                        while (rdr034.Read())
                        {
                            int AMOUNT2 = rdr034.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery();
                        }

                }
                else if (cbMeat.SelectedIndex == 1)
                {
                    while (rdr5.Read())
                    {
                        int AMOUNT1 = rdr5.GetInt32(0);
                        int Result = AMOUNT1 - ODNum;
                        cmd.CommandText = $"UPDATE PRODUCT_TABLE SET AMOUNT = {Result} where id = 201";
                        cmd.ExecuteNonQuery();
                    }
                    while (rdr6.Read())
                    {
                        int AMOUNT1 = rdr6.GetInt32(0);
                        int Result = AMOUNT1 - ODNum;
                        cmd.CommandText = $"UPDATE PRODUCT_TABLE SET AMOUNT = {Result} where id = 202";
                        cmd.ExecuteNonQuery();
                    }
                    while (rdr7.Read())
                    {
                        int AMOUNT1 = rdr7.GetInt32(0);
                        int Result = AMOUNT1 - ODNum;
                        cmd.CommandText = $"UPDATE PRODUCT_TABLE SET AMOUNT = {Result} where id = 203";
                        cmd.ExecuteNonQuery();
                    }
                    while (rdr8.Read())
                    {
                        int AMOUNT1 = rdr8.GetInt32(0);
                        int Result = AMOUNT1 - ODNum;
                        cmd.CommandText = $"UPDATE PRODUCT_TABLE SET AMOUNT = {Result} where id = 204";
                        cmd.ExecuteNonQuery();
                    }
                    
                    if (month[0] == "1")
                        while (rdr02.Read())
                        {
                            int AMOUNT2 = rdr02.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery();
                        }
                    else if (month[0] == "2")
                        while (rdr05.Read())
                        {
                            int AMOUNT2 = rdr05.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery();
                        }
                    else if (month[0] == "3")
                        while (rdr08.Read())
                        {
                            int AMOUNT2 = rdr08.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery(); ;
                        }
                    else if (month[0] == "4")
                        while (rdr011.Read())
                        {
                            int AMOUNT2 = rdr011.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery();
                        }
                    else if (month[0] == "5")
                        while (rdr014.Read())
                        {
                            int AMOUNT2 = rdr014.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery();
                        }
                    else if (month[0] == "6")
                        while (rdr017.Read())
                        {
                            int AMOUNT2 = rdr017.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery();
                        }
                    else if (month[0] == "7")
                        while (rdr020.Read())
                        {
                            int AMOUNT2 = rdr020.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery();
                        }
                    else if (month[0] == "8")
                        while (rdr023.Read())
                        {
                            int AMOUNT2 = rdr023.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery();
                        }
                    else if (month[0] == "9")
                        while (rdr026.Read())
                        {
                            int AMOUNT2 = rdr026.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery();

                        }
                    else if (month[0] == "10")
                        while (rdr029.Read())
                        {
                            int AMOUNT2 = rdr029.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery();
                        }
                    else if (month[0] == "11")
                        while (rdr032.Read())
                        {
                            int AMOUNT2 = rdr032.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery();
                        }
                    else if (month[0] == "12")
                        while (rdr035.Read())
                        {
                            int AMOUNT2 = rdr035.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery();
                        }
                }
                else if (cbMeat.SelectedIndex == 2)
                {
                    while (rdr9.Read())
                    {
                        int AMOUNT1 = rdr9.GetInt32(0);
                        int Result = AMOUNT1 - ODNum;
                        cmd.CommandText = $"UPDATE PRODUCT_TABLE SET AMOUNT = {Result} where id = 301";
                        cmd.ExecuteNonQuery();
                    }
                    while (rdr10.Read())
                    {
                        int AMOUNT1 = rdr10.GetInt32(0);
                        int Result = AMOUNT1 - ODNum;
                        cmd.CommandText = $"UPDATE PRODUCT_TABLE SET AMOUNT = {Result} where id = 302";
                        cmd.ExecuteNonQuery();
                    }
                    while (rdr11.Read())
                    {
                        int AMOUNT1 = rdr11.GetInt32(0);
                        int Result = AMOUNT1 - ODNum;
                        cmd.CommandText = $"UPDATE PRODUCT_TABLE SET AMOUNT = {Result} where id = 303";
                        cmd.ExecuteNonQuery();
                    }
                    while (rdr12.Read())
                    {
                        int AMOUNT1 = rdr12.GetInt32(0);
                        int Result = AMOUNT1 - ODNum;
                        cmd.CommandText = $"UPDATE PRODUCT_TABLE SET AMOUNT = {Result} where id = 304";
                        cmd.ExecuteNonQuery();
                    }
                    
                    if (month[0] == "1")
                        while (rdr03.Read())
                        {
                            int AMOUNT2 = rdr03.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery();
                        }
                    else if (month[0] == "2")
                        while (rdr06.Read())
                        {
                            int AMOUNT2 = rdr06.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery();
                        }
                    else if (month[0] == "3")
                        while (rdr09.Read())
                        {
                            int AMOUNT2 = rdr09.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery(); ;
                        }
                    else if (month[0] == "4")
                        while (rdr012.Read())
                        {
                            int AMOUNT2 = rdr012.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery();
                        }
                    else if (month[0] == "5")
                        while (rdr015.Read())
                        {
                            int AMOUNT2 = rdr015.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery();
                        }
                    else if (month[0] == "6")
                        while (rdr018.Read())
                        {
                            int AMOUNT2 = rdr018.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery();
                        }
                    else if (month[0] == "7")
                        while (rdr021.Read())
                        {
                            int AMOUNT2 = rdr021.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery();
                        }
                    else if (month[0] == "8")
                        while (rdr024.Read())
                        {
                            int AMOUNT2 = rdr024.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery();
                        }
                    else if (month[0] == "9")
                        while (rdr027.Read())
                        {
                            int AMOUNT2 = rdr027.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery();

                        }
                    else if (month[0] == "10")
                        while (rdr030.Read())
                        {
                            int AMOUNT2 = rdr030.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery();
                        }
                    else if (month[0] == "11")
                        while (rdr033.Read())
                        {
                            int AMOUNT2 = rdr033.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery();
                        }
                    else if (month[0] == "12")
                        while (rdr036.Read())
                        {
                            int AMOUNT2 = rdr036.GetInt32(0);
                            int Result = AMOUNT2 + ODNum;
                            cmd.CommandText = $"UPDATE MONTH_TABLE SET {txt} = {Result} where M_NUMBER = {month[0]}";
                            cmd.ExecuteNonQuery();
                        }

                }
                Form8 form8 = new Form8();
                form8.Show();
            }
            else
            { MessageBox.Show($"주문 수량이 너무 많습니다..", "10개 이하로", MessageBoxButtons.OK, MessageBoxIcon.Warning); }



        }
        private void Form1Event(object sender)
        {


        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}