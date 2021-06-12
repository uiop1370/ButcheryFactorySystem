
namespace 복사해보기
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.killPig = new MetroFramework.Controls.MetroButton();
            this.killCow = new MetroFramework.Controls.MetroButton();
            this.killSheep = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exit = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(82, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 177);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(300, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 177);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(536, 80);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(154, 177);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // killPig
            // 
            this.killPig.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.killPig.Location = new System.Drawing.Point(112, 280);
            this.killPig.Name = "killPig";
            this.killPig.Size = new System.Drawing.Size(96, 32);
            this.killPig.TabIndex = 3;
            this.killPig.Text = "돼지고기";
            this.killPig.UseSelectable = true;
            this.killPig.Click += new System.EventHandler(this.killPig_Click);
            // 
            // killCow
            // 
            this.killCow.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.killCow.Location = new System.Drawing.Point(344, 280);
            this.killCow.Name = "killCow";
            this.killCow.Size = new System.Drawing.Size(96, 32);
            this.killCow.TabIndex = 4;
            this.killCow.Text = "소고기";
            this.killCow.UseSelectable = true;
            this.killCow.Click += new System.EventHandler(this.killCow_Click);
            // 
            // killSheep
            // 
            this.killSheep.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.killSheep.Location = new System.Drawing.Point(568, 280);
            this.killSheep.Name = "killSheep";
            this.killSheep.Size = new System.Drawing.Size(96, 32);
            this.killSheep.TabIndex = 5;
            this.killSheep.Text = "양고기";
            this.killSheep.UseSelectable = true;
            this.killSheep.Click += new System.EventHandler(this.killSheep_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exit);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.killSheep);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.killCow);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.killPig);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 424);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "도축하기";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(344, 357);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(96, 23);
            this.exit.TabIndex = 6;
            this.exit.Text = "닫기";
            this.exit.UseSelectable = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroButton killPig;
        private MetroFramework.Controls.MetroButton killCow;
        private MetroFramework.Controls.MetroButton killSheep;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton exit;
    }
}