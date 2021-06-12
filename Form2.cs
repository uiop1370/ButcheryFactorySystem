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
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public delegate void FormSendDataHandler(string sendstring);
        public event FormSendDataHandler FormSendEvent;
        string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=hr;Password=hr;";

        // 오라클 연결
        OracleConnection conn;
        // 명령 객체 생성

        OracleCommand cmd;

        public Form2()
        {
            InitializeComponent();
            conn = new OracleConnection(strConn);
            conn.Open();
            cmd = new OracleCommand();
            cmd.Connection = conn;


        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void killPig_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select AMOUNT from PRODUCT_TABLE where ID = 101";
            OracleDataReader rdr1 = cmd.ExecuteReader();
            cmd.CommandText = "select amount from PRODUCT_TABLE where ID = 102";
            OracleDataReader rdr2 = cmd.ExecuteReader();
            cmd.CommandText = "select amount from PRODUCT_TABLE where ID = 103";
            OracleDataReader rdr3 = cmd.ExecuteReader();
            cmd.CommandText = "select amount from PRODUCT_TABLE where ID = 104";
            OracleDataReader rdr4 = cmd.ExecuteReader();
            
            while (rdr1.Read())
            {
                    int x = rdr1.GetInt32(0);
                if (x <= 95)
                {
                    x = x + 5;
                    cmd.CommandText = $"UPDATE PRODUCT_TABLE SET AMOUNT = {x}  where ID = 101";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = $"UPDATE PRODUCT_TABLE SET AMOUNT = {x}  where ID = 102";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = $"UPDATE PRODUCT_TABLE SET AMOUNT = {x}  where ID = 103";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = $"UPDATE PRODUCT_TABLE SET AMOUNT = {x}  where ID = 104";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("돼지가 도륙됩니다.");

                }
                else
                { MessageBox.Show($"창고가 꽉 찼습니다...", "도축x", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            }
            
        }

        private void killCow_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select AMOUNT from PRODUCT_TABLE where ID = 201";
            OracleDataReader rdr1 = cmd.ExecuteReader();
            cmd.CommandText = "select amount from PRODUCT_TABLE where ID = 202";
            OracleDataReader rdr2 = cmd.ExecuteReader();
            cmd.CommandText = "select amount from PRODUCT_TABLE where ID = 203";
            OracleDataReader rdr3 = cmd.ExecuteReader();
            cmd.CommandText = "select amount from PRODUCT_TABLE where ID = 204";
            OracleDataReader rdr4 = cmd.ExecuteReader();
            while (rdr1.Read())
            {
                int x = rdr1.GetInt32(0);
                if (x <= 90)
                {
                    x = x + 10;
                    cmd.CommandText = $"UPDATE PRODUCT_TABLE SET AMOUNT = {x}  where ID = 201";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = $"UPDATE PRODUCT_TABLE SET AMOUNT = {x}  where ID = 202";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = $"UPDATE PRODUCT_TABLE SET AMOUNT = {x}  where ID = 203";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = $"UPDATE PRODUCT_TABLE SET AMOUNT = {x}  where ID = 204";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("소가 도륙됩니다.");

                }
                else
                { MessageBox.Show($"창고가 꽉 찼습니다...", "도축x", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            }
            



        }

        private void killSheep_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select AMOUNT from PRODUCT_TABLE where ID = 301";
            OracleDataReader rdr1 = cmd.ExecuteReader();
            cmd.CommandText = "select amount from PRODUCT_TABLE where ID = 302";
            OracleDataReader rdr2 = cmd.ExecuteReader();
            cmd.CommandText = "select amount from PRODUCT_TABLE where ID = 303";
            OracleDataReader rdr3 = cmd.ExecuteReader();
            cmd.CommandText = "select amount from PRODUCT_TABLE where ID = 304";
            OracleDataReader rdr4 = cmd.ExecuteReader();
           
                while (rdr1.Read())
                {
                    int x = rdr1.GetInt32(0);
                if (x <= 97)
                {
                    x = x + 3;
                    cmd.CommandText = $"UPDATE PRODUCT_TABLE SET AMOUNT = {x}  where ID = 301";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = $"UPDATE PRODUCT_TABLE SET AMOUNT = {x}  where ID = 302";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = $"UPDATE PRODUCT_TABLE SET AMOUNT = {x}  where ID = 303";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = $"UPDATE PRODUCT_TABLE SET AMOUNT = {x}  where ID = 304";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("양이 도륙됩니다.");

                }
                else
                { MessageBox.Show($"창고가 꽉 찼습니다...", "도축x", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

                 }
            


        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.FormSendEvent("oraclesearch");
        }
    }
}
