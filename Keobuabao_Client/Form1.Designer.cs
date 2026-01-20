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
            lbl_You = new Label();
            lbl_VS = new Label();
            lbl_Enemy = new Label();
            label5 = new Label();
            lbl_Result = new Label();
            pic_Background = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic_You).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Enemy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Background).BeginInit();
            SuspendLayout();
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(729, 413);
            txtStatus.Margin = new Padding(3, 4, 3, 4);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(267, 275);
            txtStatus.TabIndex = 0;
            // 
            // btnKeo
            // 
            btnKeo.BackColor = SystemColors.GradientActiveCaption;
            btnKeo.BackgroundImage = Properties.Resources.Keo;
            btnKeo.BackgroundImageLayout = ImageLayout.Zoom;
            btnKeo.Location = new Point(10, 489);
            btnKeo.Margin = new Padding(0);
            btnKeo.Name = "btnKeo";
            btnKeo.Size = new Size(171, 200);
            btnKeo.TabIndex = 1;
            btnKeo.UseVisualStyleBackColor = false;
            btnKeo.Click += btnKeo_Click;
            // 
            // btnBua
            // 
            btnBua.BackColor = SystemColors.Info;
            btnBua.BackgroundImage = Properties.Resources.Bua;
            btnBua.BackgroundImageLayout = ImageLayout.Zoom;
            btnBua.Location = new Point(232, 489);
            btnBua.Margin = new Padding(3, 4, 3, 4);
            btnBua.Name = "btnBua";
            btnBua.Size = new Size(171, 200);
            btnBua.TabIndex = 2;
            btnBua.UseVisualStyleBackColor = false;
            btnBua.Click += btnBua_Click;
            // 
            // btnBao
            // 
            btnBao.BackColor = SystemColors.MenuHighlight;
            btnBao.BackgroundImage = Properties.Resources.Bao;
            btnBao.BackgroundImageLayout = ImageLayout.Zoom;
            btnBao.Location = new Point(448, 489);
            btnBao.Margin = new Padding(3, 4, 3, 4);
            btnBao.Name = "btnBao";
            btnBao.Size = new Size(171, 200);
            btnBao.TabIndex = 3;
            btnBao.UseVisualStyleBackColor = false;
            btnBao.Click += btnBao_Click;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(826, 147);
            btnConnect.Margin = new Padding(3, 4, 3, 4);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(86, 31);
            btnConnect.TabIndex = 4;
            btnConnect.Text = "Kết nối";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // txtIP
            // 
            txtIP.Location = new Point(807, 108);
            txtIP.Margin = new Padding(3, 4, 3, 4);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(114, 27);
            txtIP.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(826, 79);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 6;
            label1.Text = "Dia chi IP";
            // 
            // btnPlayAgain
            // 
            btnPlayAgain.Location = new Point(729, 220);
            btnPlayAgain.Name = "btnPlayAgain";
            btnPlayAgain.Size = new Size(94, 29);
            btnPlayAgain.TabIndex = 7;
            btnPlayAgain.Text = "Choi lai";
            btnPlayAgain.UseVisualStyleBackColor = true;
            btnPlayAgain.Click += btnPlayAgain_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(903, 220);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 8;
            btnExit.Text = "Thoat";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pic_You
            // 
            pic_You.Location = new Point(14, 147);
            pic_You.Margin = new Padding(3, 4, 3, 4);
            pic_You.Name = "pic_You";
            pic_You.Size = new Size(229, 267);
            pic_You.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_You.TabIndex = 9;
            pic_You.TabStop = false;
            // 
            // pic_Enemy
            // 
            pic_Enemy.Location = new Point(391, 147);
            pic_Enemy.Margin = new Padding(3, 4, 3, 4);
            pic_Enemy.Name = "pic_Enemy";
            pic_Enemy.Size = new Size(229, 267);
            pic_Enemy.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Enemy.TabIndex = 10;
            pic_Enemy.TabStop = false;
            // 
            // lbl_You
            // 
            lbl_You.AutoSize = true;
            lbl_You.Font = new Font("Segoe UI", 20F);
            lbl_You.Location = new Point(87, 79);
            lbl_You.Name = "lbl_You";
            lbl_You.Size = new Size(75, 46);
            lbl_You.TabIndex = 11;
            lbl_You.Text = "Bạn";
            // 
            // lbl_VS
            // 
            lbl_VS.AutoSize = true;
            lbl_VS.Font = new Font("Segoe UI", 20F);
            lbl_VS.Location = new Point(288, 260);
            lbl_VS.Name = "lbl_VS";
            lbl_VS.Size = new Size(59, 46);
            lbl_VS.TabIndex = 12;
            lbl_VS.Text = "VS";
            // 
            // lbl_Enemy
            // 
            lbl_Enemy.AutoSize = true;
            lbl_Enemy.Font = new Font("Segoe UI", 20F);
            lbl_Enemy.Location = new Point(448, 79);
            lbl_Enemy.Name = "lbl_Enemy";
            lbl_Enemy.Size = new Size(131, 46);
            lbl_Enemy.TabIndex = 13;
            lbl_Enemy.Text = "Đối thủ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(765, 374);
            label5.Name = "label5";
            label5.Size = new Size(195, 35);
            label5.TabIndex = 14;
            label5.Text = "Trạng thái game";
            // 
            // lbl_Result
            // 
            lbl_Result.AutoSize = true;
            lbl_Result.Font = new Font("Segoe UI", 20F);
            lbl_Result.Location = new Point(265, 556);
            lbl_Result.Name = "lbl_Result";
            lbl_Result.Size = new Size(109, 46);
            lbl_Result.TabIndex = 15;
            lbl_Result.Text = "label6";
            // 
            // pic_Background
            // 
            pic_Background.BackgroundImage = Properties.Resources.Background;
            pic_Background.BackgroundImageLayout = ImageLayout.Zoom;
            pic_Background.Location = new Point(10, 12);
            pic_Background.Name = "pic_Background";
            pic_Background.Size = new Size(988, 724);
            pic_Background.TabIndex = 16;
            pic_Background.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1010, 748);
            Controls.Add(lbl_Result);
            Controls.Add(label5);
            Controls.Add(lbl_Enemy);
            Controls.Add(lbl_VS);
            Controls.Add(lbl_You);
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
            Controls.Add(pic_Background);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pic_You).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Enemy).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Background).EndInit();
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
        private Label lbl_You;
        private Label lbl_VS;
        private Label lbl_Enemy;
        private Label label5;
        private Label lbl_Result;
        private PictureBox pic_Background;
    }
}
