
namespace 복사해보기
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbMonth = new MetroFramework.Controls.MetroComboBox();
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.chPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.chPie)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(104, 96);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(39, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "월별";
            // 
            // cbMonth
            // 
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.ItemHeight = 24;
            this.cbMonth.Location = new System.Drawing.Point(152, 88);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(121, 30);
            this.cbMonth.TabIndex = 1;
            this.cbMonth.UseSelectable = true;
            this.cbMonth.SelectedIndexChanged += new System.EventHandler(this.cbMonth_SelectedIndexChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnLoad.Location = new System.Drawing.Point(288, 88);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(88, 32);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "불러오기";
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // chPie
            // 
            chartArea2.Name = "ChartArea1";
            this.chPie.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chPie.Legends.Add(legend2);
            this.chPie.Location = new System.Drawing.Point(64, 136);
            this.chPie.Name = "chPie";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chPie.Series.Add(series2);
            this.chPie.Size = new System.Drawing.Size(344, 296);
            this.chPie.TabIndex = 4;
            this.chPie.Text = "chart1";
            this.chPie.Click += new System.EventHandler(this.chPie_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(328, 400);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "닫기";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 465);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chPie);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Form7";
            this.Text = "판매량";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chPie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbMonth;
        private MetroFramework.Controls.MetroButton btnLoad;
        private System.Windows.Forms.DataVisualization.Charting.Chart chPie;
        private MetroFramework.Controls.MetroButton btnClose;
    }
}