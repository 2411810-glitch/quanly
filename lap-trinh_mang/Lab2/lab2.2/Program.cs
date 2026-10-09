using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace lab2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int byteReceive;
            string str;
            IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Loopback, 5000);
            Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
ProtocolType.Tcp);
            Console.WriteLine("Dang ket noi voi server...");
            serverSocket.Bind(serverEndPoint);
            serverSocket.Connect(serverEndPoint);
            byte[] buff = new byte[1024];
            if (serverSocket.Connected)
            {
                Console.WriteLine("Ket noi thanh cong voi server ...");
                byteReceive = serverSocket.Receive(buff, 0, buff.Length, SocketFlags.None);
                str = Encoding.ASCII.GetString(buff, 0, byteReceive);
                Console.WriteLine(str);
            }
            try
            {
                serverSocket.Connect(serverEndPoint);
            }
            catch (SocketException se)
            {
                Console.WriteLine("Khong the ket noi den server");
                return;
            }
            while (true)
            {
                str = Console.ReadLine();
                buff = Encoding.ASCII.GetBytes(str);
                serverSocket.Send(buff, 0, buff.Length, SocketFlags.None);
                buff = new byte[1024];
                byteReceive = serverSocket.Receive(buff, 0, buff.Length, SocketFlags.None);
                str = Encoding.ASCII.GetString(buff, 0, byteReceive);
                Console.WriteLine(str);
            }
        }
    }
}
