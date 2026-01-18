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
            SuspendLayout();
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(106, 64);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(422, 107);
            txtStatus.TabIndex = 0;
            // 
            // btnKeo
            // 
            btnKeo.Location = new Point(139, 237);
            btnKeo.Name = "btnKeo";
            btnKeo.Size = new Size(75, 23);
            btnKeo.TabIndex = 1;
            btnKeo.Text = "Keo";
            btnKeo.UseVisualStyleBackColor = true;
            btnKeo.Click += btnKeo_Click;
            // 
            // btnBua
            // 
            btnBua.Location = new Point(296, 237);
            btnBua.Name = "btnBua";
            btnBua.Size = new Size(75, 23);
            btnBua.TabIndex = 2;
            btnBua.Text = "Bua";
            btnBua.UseVisualStyleBackColor = true;
            btnBua.Click += btnBua_Click;
            // 
            // btnBao
            // 
            btnBao.Location = new Point(453, 237);
            btnBao.Name = "btnBao";
            btnBao.Size = new Size(75, 23);
            btnBao.TabIndex = 3;
            btnBao.Text = "Bao";
            btnBao.UseVisualStyleBackColor = true;
            btnBao.Click += btnBao_Click;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(284, 310);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 4;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // txtIP
            // 
            txtIP.Location = new Point(449, 188);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(100, 23);
            txtIP.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtIP);
            Controls.Add(btnConnect);
            Controls.Add(btnBao);
            Controls.Add(btnBua);
            Controls.Add(btnKeo);
            Controls.Add(txtStatus);
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
    }
}
