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
            SuspendLayout();
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(159, 13);
            txtStatus.Margin = new Padding(3, 4, 3, 4);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(447, 232);
            txtStatus.TabIndex = 0;
            // 
            // btnKeo
            // 
            btnKeo.Location = new Point(159, 316);
            btnKeo.Margin = new Padding(3, 4, 3, 4);
            btnKeo.Name = "btnKeo";
            btnKeo.Size = new Size(86, 31);
            btnKeo.TabIndex = 1;
            btnKeo.Text = "Keo";
            btnKeo.UseVisualStyleBackColor = true;
            btnKeo.Click += btnKeo_Click;
            // 
            // btnBua
            // 
            btnBua.Location = new Point(343, 316);
            btnBua.Margin = new Padding(3, 4, 3, 4);
            btnBua.Name = "btnBua";
            btnBua.Size = new Size(86, 31);
            btnBua.TabIndex = 2;
            btnBua.Text = "Bua";
            btnBua.UseVisualStyleBackColor = true;
            btnBua.Click += btnBua_Click;
            // 
            // btnBao
            // 
            btnBao.Location = new Point(518, 316);
            btnBao.Margin = new Padding(3, 4, 3, 4);
            btnBao.Name = "btnBao";
            btnBao.Size = new Size(86, 31);
            btnBao.TabIndex = 3;
            btnBao.Text = "Bao";
            btnBao.UseVisualStyleBackColor = true;
            btnBao.Click += btnBao_Click;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(325, 413);
            btnConnect.Margin = new Padding(3, 4, 3, 4);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(86, 31);
            btnConnect.TabIndex = 4;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // txtIP
            // 
            txtIP.Location = new Point(684, 127);
            txtIP.Margin = new Padding(3, 4, 3, 4);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(114, 27);
            txtIP.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(707, 103);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 6;
            label1.Text = "Dia chi IP";
            // 
            // btnPlayAgain
            // 
            btnPlayAgain.Location = new Point(636, 216);
            btnPlayAgain.Name = "btnPlayAgain";
            btnPlayAgain.Size = new Size(94, 29);
            btnPlayAgain.TabIndex = 7;
            btnPlayAgain.Text = "Choi lai";
            btnPlayAgain.UseVisualStyleBackColor = true;
            btnPlayAgain.Click += btnPlayAgain_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(785, 216);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 8;
            btnExit.Text = "Thoat";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnExit);
            Controls.Add(btnPlayAgain);
            Controls.Add(label1);
            Controls.Add(txtIP);
            Controls.Add(btnConnect);
            Controls.Add(btnBao);
            Controls.Add(btnBua);
            Controls.Add(btnKeo);
            Controls.Add(txtStatus);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
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
    }
}
