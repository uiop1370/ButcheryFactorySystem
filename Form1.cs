using MetroFramework.Forms;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 복사해보기
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {


        // 네트워크 연결 정보 직접 대입
        string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=hr;Password=hr;";

        // 오라클 연결
        OracleConnection conn;
        // 명령 객체 생성
        OracleCommand cmd;
        //상태
        int state = 1;
        bool flag = false;

        //이미지박스용
        int X, Y;


        Form3 form3;
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
            conn = new OracleConnection(strConn);
            conn.Open();
            cmd = new OracleCommand();
            cmd.Connection = conn;
            oraclesearch();
            //this.porkFront.MouseHover += MouseHover_Event;
        }

        //public void MouseHover_Event(object sender, EventArgs e)
        //{
        //    ToolTip ToolTip1 = new ToolTip();
        //    ToolTip1.SetToolTip(this.porkFront, "Main 버튼입니다");
        //}

        private void Form2_Load(object sender, EventArgs e)
        {
            /*cbMonth.Items.Add("1월");
            cbMonth.Items.Add("2월");
            cbMonth.Items.Add("3월");
            cbMonth.Items.Add("4월");
            cbMonth.Items.Add("5월");
            cbMonth.Items.Add("6월");
            cbMonth.Items.Add("7월");
            cbMonth.Items.Add("8월");
            cbMonth.Items.Add("9월");
            cbMonth.Items.Add("10월");
            cbMonth.Items.Add("11월");
            cbMonth.Items.Add("12월");*/
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        void oraclesearch()
        {
            //돼지 앞다리살 
            cmd.CommandText = "select amount from PRODUCT_TABLE where ID = 101";
            OracleDataReader rdr1 = cmd.ExecuteReader();
            while (rdr1.Read())
            {
                int amount = rdr1.GetInt32(0);
                porkFront.Value = amount;
            }

            //돼지 뒷다리살
            cmd.CommandText = "select amount from PRODUCT_TABLE where ID = 102";
            OracleDataReader rdr2 = cmd.ExecuteReader();
            while (rdr2.Read())
            {
                int amount = rdr2.GetInt32(0);
                porkBehind.Value = amount;
            }

            //돼지 등심
            cmd.CommandText = "select amount from PRODUCT_TABLE where ID = 103";
            OracleDataReader rdr3 = cmd.ExecuteReader();
            while (rdr3.Read())
            {
                int amount = rdr3.GetInt32(0);

                porkBack.Value = amount;
            }

            //  돼지 갈비
            cmd.CommandText = "select amount from PRODUCT_TABLE where ID = 104";
            OracleDataReader rdr4 = cmd.ExecuteReader();
            while (rdr4.Read())
            {
                int amount = rdr4.GetInt32(0);

                porkLips.Value = amount;
            }

            // 소 뒷다리
            cmd.CommandText = "select amount from PRODUCT_TABLE where ID = 201";
            OracleDataReader rdr5 = cmd.ExecuteReader();
            while (rdr5.Read())
            {
                int amount = rdr5.GetInt32(0);
                beefFront.Value = amount;
            }
            // 소 뒷다리살
            cmd.CommandText = "select amount from PRODUCT_TABLE where ID = 202";
            OracleDataReader rdr6 = cmd.ExecuteReader();
            while (rdr6.Read())
            {
                int amount = rdr6.GetInt32(0);
                beefBehind.Value = amount;
            }
            // 소 등심
            cmd.CommandText = "select amount from PRODUCT_TABLE where ID = 203";
            OracleDataReader rdr7 = cmd.ExecuteReader();
            while (rdr7.Read())
            {
                int amount = rdr7.GetInt32(0);
                beefBack.Value = amount;
            }
            // 소 갈비
            cmd.CommandText = "select amount from PRODUCT_TABLE where ID = 204";
            OracleDataReader rdr8 = cmd.ExecuteReader();
            while (rdr8.Read())
            {
                int amount = rdr8.GetInt32(0);

                beefLips.Value = amount;
            }
            // 양 앞다리
            cmd.CommandText = "select amount from PRODUCT_TABLE where ID = 301";
            OracleDataReader rdr9 = cmd.ExecuteReader();
            while (rdr9.Read())
            {
                int amount = rdr9.GetInt32(0);

                lambFront.Value = amount;
            }
            // 양 뒷달디살
            cmd.CommandText = "select amount from PRODUCT_TABLE where ID = 302";
            OracleDataReader rdr10 = cmd.ExecuteReader();
            while (rdr10.Read())
            {
                int amount = rdr10.GetInt32(0);

                lambBehind.Value = amount;
            }
            // 양 등심
            cmd.CommandText = "select amount from PRODUCT_TABLE where ID = 303";
            OracleDataReader rdr11 = cmd.ExecuteReader();
            while (rdr11.Read())
            {
                int amount = rdr11.GetInt32(0);

                lambBack.Value = amount;
            }
            // 레드버튼
            cmd.CommandText = "select amount from PRODUCT_TABLE where ID = 304";
            OracleDataReader rdr12 = cmd.ExecuteReader();
            while (rdr12.Read())
            {
                int amount = rdr12.GetInt32(0);

                lambLips.Value = amount;
            }
        }

        private void SaveOracle()
        {
            // SQL문 지정 및 INSERT 실행
            // 돼지 앞다리살
            cmd.CommandText = $"update PRODUCT_TABLE set amount = {porkFront.Value} where ID = 101";
            cmd.ExecuteNonQuery();
            // 파란펜 심
            cmd.CommandText = $"update PRODUCT_TABLE set amount = {porkBehind.Value} where ID = 102";
            cmd.ExecuteNonQuery();
            // 빨간펜 심
            cmd.CommandText = $"update PRODUCT_TABLE set amount = {porkBack.Value} where ID = 103";
            cmd.ExecuteNonQuery();
            // 스프링
            cmd.CommandText = $"update PRODUCT_TABLE set amount = {porkLips.Value} where ID = 104";
            cmd.ExecuteNonQuery();
            // 1구 캡
            cmd.CommandText = $"update PRODUCT_TABLE set amount = {beefFront.Value} where ID = 201";
            cmd.ExecuteNonQuery();
            // 2구 캡
            cmd.CommandText = $"update PRODUCT_TABLE set amount = {beefBehind.Value} where ID = 202";
            cmd.ExecuteNonQuery();
            // 3구 캡
            cmd.CommandText = $"update PRODUCT_TABLE set amount = {beefBack.Value} where ID = 203";
            cmd.ExecuteNonQuery();
            // 1구 바디
            cmd.CommandText = $"update PRODUCT_TABLE set amount = {beefLips.Value} where ID = 204";
            cmd.ExecuteNonQuery();
            // 2구 바디
            cmd.CommandText = $"update PRODUCT_TABLE set amount = {lambFront.Value} where ID = 301";
            cmd.ExecuteNonQuery();
            // 3구 바디
            cmd.CommandText = $"update PRODUCT_TABLE set amount = {lambBehind.Value} where ID = 302";
            cmd.ExecuteNonQuery();
            // 1구 버튼
            cmd.CommandText = $"update PRODUCT_TABLE set amount = {lambBack.Value} where ID = 303";
            cmd.ExecuteNonQuery();
            // 2구 버튼
            cmd.CommandText = $"update PRODUCT_TABLE set amount = {lambLips.Value} where ID = 304";
            cmd.ExecuteNonQuery();

        }

        private void order_Click(object sender, EventArgs e)
        {
            form3 = new Form3();
            form3.FormSendEvent += new Form3.FormSendDataHandler(Form3Event);
            form3.Show();
            oraclesearch();
        }
        private void Form3Event(object sender)
        {
            oraclesearch();
            form3.Close();


        }

        private void add_Click_1(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.FormSendEvent += new Form2.FormSendDataHandler(Form2Event);
            form2.Show();
            oraclesearch();

        }

        private void selectedIndex(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Form2Event(object sender)
        {
            oraclesearch();
            form2.Close();


        }
        private void porkFront_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "돼지고기 앞다리 재고량";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.porkFront, $"{Convert.ToInt32(porkFront.Value)}/100");
        }
        private void porkBehind_MouseHover(object sender, EventArgs e)
        {
            this.toolTip2.ToolTipTitle = "돼지고기 뒷다리 재고량";
            this.toolTip2.IsBalloon = true;
            this.toolTip2.SetToolTip(this.porkBehind, $"{Convert.ToInt32(porkBehind.Value)}/100");
            //toolTip2.SetToolTip(porkBehind, $"{Convert.ToInt32(porkBehind.Value)}/100");
        }
        private void porkBack_MouseHover(object sender, EventArgs e)
        {
            this.toolTip3.ToolTipTitle = "돼지고기 등심 재고량";
            this.toolTip3.IsBalloon = true;
            this.toolTip3.SetToolTip(this.porkBack, $"{Convert.ToInt32(porkBack.Value)}/100");
            //toolTip3.SetToolTip(porkBack, $"{Convert.ToInt32(porkBack.Value)}/100");
        }
        private void porkLips_MouseHover(object sender, EventArgs e)
        {
            this.toolTip4.ToolTipTitle = "돼지고기 갈비 재고량";
            this.toolTip4.IsBalloon = true;
            this.toolTip4.SetToolTip(this.porkLips, $"{Convert.ToInt32(porkLips.Value)}/100");
            // toolTip4.SetToolTip(porkLips, $"{Convert.ToInt32(porkLips.Value)}/100");
        }

        private void beefFront_MouseHover(object sender, EventArgs e)
        {
            this.toolTip5.ToolTipTitle = "소고기 앞다리 재고량";
            this.toolTip5.IsBalloon = true;
            this.toolTip5.SetToolTip(this.beefFront, $"{Convert.ToInt32(beefFront.Value)}/100");
            //toolTip5.SetToolTip(beefFront, $"{Convert.ToInt32(beefFront.Value)}/100");
        }

        private void beefBehind_MouseHover(object sender, EventArgs e)
        {
            this.toolTip6.ToolTipTitle = "소고기 뒷다리 재고량";
            this.toolTip6.IsBalloon = true;
            this.toolTip6.SetToolTip(this.beefBehind, $"{Convert.ToInt32(beefBehind.Value)}/100");
            //toolTip6.SetToolTip(beefBehind, $"{Convert.ToInt32(beefBehind.Value)}/100");
        }

        private void beefBack_MouseHover(object sender, EventArgs e)
        {
            this.toolTip7.ToolTipTitle = "소고기 등심 재고량";
            this.toolTip7.IsBalloon = true;
            this.toolTip7.SetToolTip(this.beefBack, $"{Convert.ToInt32(beefBack.Value)}/100");
            //toolTip7.SetToolTip(beefBack, $"{Convert.ToInt32(beefBack.Value)}/100");
        }

        private void beefLips_MouseHover(object sender, EventArgs e)
        {
            this.toolTip8.ToolTipTitle = "소고기 갈비 재고량";
            this.toolTip8.IsBalloon = true;
            this.toolTip8.SetToolTip(this.beefLips, $"{Convert.ToInt32(beefLips.Value)}/100");
            //toolTip8.SetToolTip(beefLips, $"{Convert.ToInt32(beefLips.Value)}/100");
        }


        private void lambFront_MouseHover(object sender, EventArgs e)
        {
            this.toolTip9.ToolTipTitle = "양고기 앞다리 재고량";
            this.toolTip9.IsBalloon = true;
            this.toolTip9.SetToolTip(this.lambFront, $"{Convert.ToInt32(lambFront.Value)}/100");
            //toolTip9.SetToolTip(lambFront, $"{Convert.ToInt32(lambFront.Value)}/100");
        }

        private void lambBehind_MouseHover(object sender, EventArgs e)
        {
            this.toolTip10.ToolTipTitle = "양고기 뒷다리 재고량";
            this.toolTip10.IsBalloon = true;
            this.toolTip10.SetToolTip(this.lambBehind, $"{Convert.ToInt32(lambBehind.Value)}/100");
            //toolTip10.SetToolTip(lambBehind, $"{Convert.ToInt32(lambBehind.Value)}/100");
        }

        private void lambBack_MouseHover(object sender, EventArgs e)
        {
            this.toolTip11.ToolTipTitle = "양고기 등심 재고량";
            this.toolTip11.IsBalloon = true;
            this.toolTip11.SetToolTip(this.lambBack, $"{Convert.ToInt32(lambBack.Value)}/100");
            //toolTip11.SetToolTip(lambBack, $"{Convert.ToInt32(lambBack.Value)}/100");
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Form7 butchery = new Form7();
            butchery.Show();
        }

        private void lambLips_MouseHover(object sender, EventArgs e)
        {
            this.toolTip12.ToolTipTitle = "양고기 갈비 재고량";
            this.toolTip12.IsBalloon = true;
            this.toolTip12.SetToolTip(this.lambLips, $"{Convert.ToInt32(lambLips.Value)}/100");
            //toolTip12.SetToolTip(lambLips, $"{Convert.ToInt32(lambLips.Value)}/100");
        }


    }
}
