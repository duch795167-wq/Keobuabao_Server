using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Keobuabao_Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Kéo Búa Bao Server";
            TcpListener server = new TcpListener(IPAddress.Any, 8888);
            server.Start();
            Console.WriteLine("Server khởi động tại port 8888... Đang chờ người chơi");

            while (true)
            {
                // Chờ 2 người chơi
                TcpClient player1 = server.AcceptTcpClient();
                SendMessage(player1, "Đang chờ đối thủ...\n");

                TcpClient player2 = server.AcceptTcpClient();
                SendMessage(player2, "Đang chờ đối thủ...\n");

                Console.WriteLine("Đã ghép đôi 2 người chơi!");

                // Gửi thông báo bắt đầu cho cả 2
                SendMessage(player1, "BẮT ĐẦU! Chọn: 1=Kéo, 2=Búa, 3=Bao\n");
                SendMessage(player2, "BẮT ĐẦU! Chọn: 1=Kéo, 2=Búa, 3=Bao\n");

                // Xử lý trong thread riêng
                new Thread(() => HandleGame(player1, player2)).Start();
            }
        }
        static void HandleGame(TcpClient p1, TcpClient p2)
        {
            try
            {
                string choice1 = "";
                string choice2 = "";

                // Nhận lựa chọn từ player 1
                choice1 = ReceiveChoice(p1);
                SendMessage(p2, "Đối thủ đã chọn... Đang chờ bạn\n");

                // Nhận lựa chọn từ player 2
                choice2 = ReceiveChoice(p2);
                SendMessage(p1, "Đối thủ đã chọn... Tính kết quả\n");

                // Tính kết quả
                string result1 = CalculateResult(choice1, choice2);
                string result2 = CalculateResult(choice2, choice1);
                // Gửi kết quả cho cả hai
                SendMessage(p1, $"\nKẾT QUẢ:\nBạn: {ToName(choice1)} - Đối thủ: {ToName(choice2)}\n{result1}\n");
                SendMessage(p2, $"\nKẾT QUẢ:\nBạn: {ToName(choice2)} - Đối thủ: {ToName(choice1)}\n{result2}\n");

                // Đóng kết nối (hoặc có thể cho chơi tiếp)
                p1.Close();
                p2.Close();
            }
            catch { }
        }

        static string ReceiveChoice(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            return Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim();
        }

        static void SendMessage(TcpClient client, string msg)
        {
            try
            {
                NetworkStream stream = client.GetStream();
                byte[] data = Encoding.UTF8.GetBytes(msg);
                stream.Write(data, 0, data.Length);
            }
            catch { }
        }

        static string CalculateResult(string c1, string c2)
        {
            if (c1 == c2) return "HÒA!";

            if ((c1 == "1" && c2 == "3") ||    // Kéo thắng Bao
                (c1 == "2" && c2 == "1") ||    // Búa thắng Kéo
                (c1 == "3" && c2 == "2"))      // Bao thắng Búa
                return "Bạn THẮNG! 🎉";

            return "Bạn THUA! 😢";
        }

        static string ToName(string choice)
        {
            switch (choice)
            {
                case "1": return "Kéo ✊";
                case "2": return "Búa ✌️";
                case "3": return "Bao ✋";
                default: return "???";
            }
        }
    }
}
