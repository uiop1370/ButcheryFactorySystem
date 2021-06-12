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
    public partial class Form8 : MetroFramework.Forms.MetroForm
    {
        

        public Form8()
        {
            InitializeComponent();

            //timer.Interval = 1000; //주기 설정
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
            timer2.Tick += new EventHandler(timer2_Tick);
            timer3.Tick += new EventHandler(timer3_Tick);
            timer4.Tick += new EventHandler(timer4_Tick);

        }
        void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox1.Visible = true;
            //pictureBox1.BringToFront();

            timer1.Stop();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            pictureBox1.Visible = false;
            pictureBox2.Visible = true;

            pictureBox2.BringToFront();

            timer2.Stop();
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            pictureBox3.BringToFront();

            timer3.Stop();
            timer4.Start();
        }


        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
            pictureBox4.BringToFront();

            timer4.Stop();
            timer6.Start();



        }


       private void timer5_Tick(object sender, EventArgs e)
        {
            
        }

        private void Timer6(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox7.Visible = true;
            pictureBox7.BringToFront();

            timer6.Stop();



            Form5 frm5 = new Form5();
            frm5.Show();
            this.Close();
        }
    }
}
