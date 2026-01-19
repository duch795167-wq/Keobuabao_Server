namespace Keobuabao_Client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtStatus = new TextBox();
            btnKeo = new Button();
            btnBua = new Button();
            btnBao = new Button();
            btnConnect = new Button();
            txtIP = new TextBox();
            label1 = new Label();
            btnPlayAgain = new Button();
            btnExit = new Button();
            pic_You = new PictureBox();
            pic_Enemy = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lbl_Result = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_You).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Enemy).BeginInit();
            SuspendLayout();
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(638, 310);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(234, 207);
            txtStatus.TabIndex = 0;
            // 
            // btnKeo
            // 
            btnKeo.BackColor = SystemColors.GradientActiveCaption;
            btnKeo.BackgroundImage = Properties.Resources.Keo;
            btnKeo.BackgroundImageLayout = ImageLayout.Zoom;
            btnKeo.Location = new Point(9, 367);
            btnKeo.Margin = new Padding(0);
            btnKeo.Name = "btnKeo";
            btnKeo.Size = new Size(150, 150);
            btnKeo.TabIndex = 1;
            btnKeo.UseVisualStyleBackColor = false;
            btnKeo.Click += btnKeo_Click;
            // 
            // btnBua
            // 
            btnBua.BackColor = SystemColors.Info;
            btnBua.BackgroundImage = Properties.Resources.Bua;
            btnBua.BackgroundImageLayout = ImageLayout.Zoom;
            btnBua.Location = new Point(203, 367);
            btnBua.Name = "btnBua";
            btnBua.Size = new Size(150, 150);
            btnBua.TabIndex = 2;
            btnBua.UseVisualStyleBackColor = false;
            btnBua.Click += btnBua_Click;
            // 
            // btnBao
            // 
            btnBao.BackColor = SystemColors.MenuHighlight;
            btnBao.BackgroundImage = Properties.Resources.Bao;
            btnBao.BackgroundImageLayout = ImageLayout.Zoom;
            btnBao.Location = new Point(392, 367);
            btnBao.Name = "btnBao";
            btnBao.Size = new Size(150, 150);
            btnBao.TabIndex = 3;
            btnBao.UseVisualStyleBackColor = false;
            btnBao.Click += btnBao_Click;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(723, 110);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 4;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // txtIP
            // 
            txtIP.Location = new Point(706, 81);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(100, 23);
            txtIP.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(723, 52);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 6;
            label1.Text = "Dia chi IP";
            // 
            // btnPlayAgain
            // 
            btnPlayAgain.Location = new Point(638, 165);
            btnPlayAgain.Margin = new Padding(3, 2, 3, 2);
            btnPlayAgain.Name = "btnPlayAgain";
            btnPlayAgain.Size = new Size(82, 22);
            btnPlayAgain.TabIndex = 7;
            btnPlayAgain.Text = "Choi lai";
            btnPlayAgain.UseVisualStyleBackColor = true;
            btnPlayAgain.Click += btnPlayAgain_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(790, 165);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(82, 22);
            btnExit.TabIndex = 8;
            btnExit.Text = "Thoat";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pic_You
            // 
            pic_You.Location = new Point(12, 110);
            pic_You.Name = "pic_You";
            pic_You.Size = new Size(200, 200);
            pic_You.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_You.TabIndex = 9;
            pic_You.TabStop = false;
            // 
            // pic_Enemy
            // 
            pic_Enemy.Location = new Point(342, 110);
            pic_Enemy.Name = "pic_Enemy";
            pic_Enemy.Size = new Size(200, 200);
            pic_Enemy.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Enemy.TabIndex = 10;
            pic_Enemy.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(44, 52);
            label2.Name = "label2";
            label2.Size = new Size(126, 37);
            label2.TabIndex = 11;
            label2.Text = "Ban chon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(252, 195);
            label3.Name = "label3";
            label3.Size = new Size(48, 37);
            label3.TabIndex = 12;
            label3.Text = "VS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(358, 52);
            label4.Name = "label4";
            label4.Size = new Size(170, 37);
            label4.TabIndex = 13;
            label4.Text = "Doi thu chon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(683, 279);
            label5.Name = "label5";
            label5.Size = new Size(152, 28);
            label5.TabIndex = 14;
            label5.Text = "Trạng thái game";
            // 
            // lbl_Result
            // 
            lbl_Result.AutoSize = true;
            lbl_Result.Font = new Font("Segoe UI", 20F);
            lbl_Result.Location = new Point(232, 417);
            lbl_Result.Name = "lbl_Result";
            lbl_Result.Size = new Size(90, 37);
            lbl_Result.TabIndex = 15;
            lbl_Result.Text = "label6";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(lbl_Result);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pic_Enemy);
            Controls.Add(pic_You);
            Controls.Add(btnExit);
            Controls.Add(btnPlayAgain);
            Controls.Add(label1);
            Controls.Add(txtIP);
            Controls.Add(btnConnect);
            Controls.Add(btnBao);
            Controls.Add(btnBua);
            Controls.Add(btnKeo);
            Controls.Add(txtStatus);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pic_You).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Enemy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStatus;
        private Button btnKeo;
        private Button btnBua;
        private Button btnBao;
        private Button btnConnect;
        private TextBox txtIP;
        private Label label1;
        private Button btnPlayAgain;
        private Button btnExit;
        private PictureBox pic_You;
        private PictureBox pic_Enemy;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lbl_Result;
    }
}
