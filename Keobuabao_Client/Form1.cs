using System;
using System.Drawing.Drawing2D;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Keobuabao_Client
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread;
        public string choice_You;
        public Form1()
        {
            InitializeComponent();
            btnKeo.Visible = false;
            btnBua.Visible = false;
            btnBao.Visible = false;
            lbl_Result.Visible = false;
            MakeCircleButton(btnKeo);
            MakeCircleButton(btnBua);
            MakeCircleButton(btnBao);
        }


        private void ReceiveMessages()
        {
            try
            {
                byte[] buffer = new byte[1024];
                while (true)
                {
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0) break;

                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    this.Invoke((MethodInvoker)delegate
                    {
                        if (message.StartsWith("Doi thu chon:"))
                        {
                            string choice_Enemy = message.Split(':')[1].Trim();
                            ShowEnemyChoice(choice_Enemy);
                            lbl_Result.Visible = true;
                            
                            lbl_Result.Text = ShowResult(choice_You,choice_Enemy);
                        }
                        else
                        {
                            txtStatus.AppendText("-" + message + Environment.NewLine);
                        }
                        

                        // Khi bắt đầu game → hiện nút chọn
                        if (message.Contains("BẮT ĐẦU"))
                        {
                            txtStatus.Clear();
                            txtStatus.AppendText("-" + message + Environment.NewLine);
                            lbl_Result.Visible = false;
                            pic_Enemy.Image = null;
                            pic_You.Image = null;
                            btnKeo.Visible = true;
                            btnBua.Visible = true;
                            btnBao.Visible = true;
                            
                        }
                        
                    });
                }
            }
            catch { }
        }

        private void SendChoice(string choice)
        {
            try
            {
                byte[] data = Encoding.UTF8.GetBytes(choice);
                stream.Write(data, 0, data.Length);


                this.Invoke((MethodInvoker)delegate
                {
                    btnKeo.Visible = false;
                    btnBua.Visible = false;
                    btnBao.Visible = false;
                    if (choice != "N")
                        txtStatus.AppendText("Đã gửi lựa chọn... Đang chờ kết quả" + Environment.NewLine);
                    else txtStatus.AppendText(Environment.NewLine + "Ban da thoat");
                });


                // Ẩn nút sau khi chọn

            }
            catch { }
        }

        // Các sự kiện nút chọn
        private void btnKeo_Click(object sender, EventArgs e)
        {
            
            SendChoice("1");
            pic_You.Image = Properties.Resources.Keo;
            choice_You = "1";

        }
        private void btnBua_Click(object sender, EventArgs e)
        {
            SendChoice("2");
            pic_You.Image = Properties.Resources.Bua;
            choice_You = "2";
        }
        private void btnBao_Click(object sender, EventArgs e)
        {

            SendChoice("3");
            pic_You.Image = Properties.Resources.Bao;
            choice_You = "3";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            stream?.Close();
            client?.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            try
            {
                string ip = string.IsNullOrEmpty(txtIP.Text) ? "127.0.0.1" : txtIP.Text;
                client = new TcpClient(ip, 8888);
                stream = client.GetStream();

                txtStatus.Text = "Đã kết nối server!\n";

                // Thread nhận tin nhắn từ server
                receiveThread = new Thread(ReceiveMessages);
                receiveThread.IsBackground = true;
                receiveThread.Start();

                btnConnect.Enabled = false;
                txtIP.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được server!\n" + ex.Message);
            }
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            SendChoice("Y");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            SendChoice("N");
        }
        void MakeCircleButton(Button btn)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, btn.Width, btn.Height);
            btn.Region = new Region(path);

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
        }
        void ShowEnemyChoice(string choice)
        {
            pic_Enemy.SizeMode = PictureBoxSizeMode.Zoom;

            switch (choice)
            {
                case "1":
                    pic_Enemy.Image = Properties.Resources.Keo;
                    break;
                case "2":
                    pic_Enemy.Image = Properties.Resources.Bua;
                    break;
                case "3":
                    pic_Enemy.Image = Properties.Resources.Bao;
                    break;
            }
        }
        string ShowResult(string c1, string c2)
        {
            if (c1 == c2) return "HÒA!";

            if ((c1 == "1" && c2 == "3") ||    // Kéo thắng Bao
                (c1 == "2" && c2 == "1") ||    // Búa thắng Kéo
                (c1 == "3" && c2 == "2"))      // Bao thắng Búa
                return "Bạn THẮNG! 🎉";

            return "Bạn THUA! 😢";
        }
    }
}
