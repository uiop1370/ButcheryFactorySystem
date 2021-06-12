
namespace 복사해보기
{
    partial class Form3
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbMeat = new MetroFramework.Controls.MetroComboBox();
            this.txtOrderNum = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.cbMonth = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // cbMeat
            // 
            this.cbMeat.FormattingEnabled = true;
            this.cbMeat.ItemHeight = 24;
            this.cbMeat.Location = new System.Drawing.Point(168, 96);
            this.cbMeat.Name = "cbMeat";
            this.cbMeat.Size = new System.Drawing.Size(121, 30);
            this.cbMeat.TabIndex = 0;
            this.cbMeat.UseSelectable = true;
            this.cbMeat.SelectedIndexChanged += new System.EventHandler(this.cbMeat_SelectedIndexChanged);
            // 
            // txtOrderNum
            // 
            // 
            // 
            // 
            this.txtOrderNum.CustomButton.Image = null;
            this.txtOrderNum.CustomButton.Location = new System.Drawing.Point(37, 2);
            this.txtOrderNum.CustomButton.Name = "";
            this.txtOrderNum.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtOrderNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOrderNum.CustomButton.TabIndex = 1;
            this.txtOrderNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOrderNum.CustomButton.UseSelectable = true;
            this.txtOrderNum.CustomButton.Visible = false;
            this.txtOrderNum.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtOrderNum.Lines = new string[0];
            this.txtOrderNum.Location = new System.Drawing.Point(304, 96);
            this.txtOrderNum.MaxLength = 32767;
            this.txtOrderNum.Name = "txtOrderNum";
            this.txtOrderNum.PasswordChar = '\0';
            this.txtOrderNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOrderNum.SelectedText = "";
            this.txtOrderNum.SelectionLength = 0;
            this.txtOrderNum.SelectionStart = 0;
            this.txtOrderNum.ShortcutsEnabled = true;
            this.txtOrderNum.Size = new System.Drawing.Size(65, 30);
            this.txtOrderNum.TabIndex = 1;
            this.txtOrderNum.UseSelectable = true;
            this.txtOrderNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOrderNum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtOrderNum.Click += new System.EventHandler(this.txtOrderNum_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(368, 104);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(24, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "개";
            // 
            // btnClose
            // 
            this.btnClose.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnClose.Location = new System.Drawing.Point(448, 168);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "닫기";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Location = new System.Drawing.Point(400, 96);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(121, 30);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "주문하기";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // cbMonth
            // 
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.ItemHeight = 24;
            this.cbMonth.Location = new System.Drawing.Point(40, 96);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(121, 30);
            this.cbMonth.TabIndex = 6;
            this.cbMonth.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 214);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtOrderNum);
            this.Controls.Add(this.cbMeat);
            this.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Text = "발주하기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbMeat;
        private MetroFramework.Controls.MetroTextBox txtOrderNum;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox cbMonth;
    }
}

