using System.Net.Sockets;
using System.Text;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Keobuabao_Client
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread;
        public Form1()
        {
            InitializeComponent();
            btnKeo.Visible = false;
            btnBua.Visible = false;
            btnBao.Visible = false;
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
                        txtStatus.AppendText(message + "\n");

                        // Khi bắt đầu game → hiện nút chọn
                        if (message.Contains("BẮT ĐẦU"))
                        {
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
                if(choice != "Y"|| choice != "N")
                {

                    this.Invoke((MethodInvoker)delegate
                    {
                        btnKeo.Visible = false;
                        btnBua.Visible = false;
                        btnBao.Visible = false;
                        txtStatus.AppendText("Đã gửi lựa chọn... Đang chờ kết quả\n");
                    });

                }
                // Ẩn nút sau khi chọn
                
            }
            catch { }
        }

        // Các sự kiện nút chọn
        private void btnKeo_Click(object sender, EventArgs e) => SendChoice("1");
        private void btnBua_Click(object sender, EventArgs e) => SendChoice("2");
        private void btnBao_Click(object sender, EventArgs e) => SendChoice("3");

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            stream?.Close();
            client?.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            txtStatus.Text = "Ok";
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
        
    }
}
