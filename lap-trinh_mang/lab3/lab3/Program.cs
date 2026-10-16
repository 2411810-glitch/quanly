using System.Net;
using System.Net.Sockets;
using System.Text;
using System;
namespace lab3
{
    class Program
    {
        static void Main(string[] args) 
        {
            IPEndPoint severEnd = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5000);
            Socket severSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            severSocket.Bind(severEnd);
            Console.WriteLine("Dang cho clinet ket noi toi...");
            EndPoint remote = new IPEndPoint(IPAddress.Any, 0);
            byte[] buff = new byte[1024];
            int received = severSocket.ReceiveFrom(buff, 0, buff.Length, SocketFlags.None, ref remote);
            severSocket.ReceiveFrom(buff, 0, buff.Length, SocketFlags.None, ref remote);
            Console.WriteLine("Da ket noi voi cilent:" + remote);
            string hello = "Hello server";
            Console.WriteLine(hello);
            byte[] response = Encoding.ASCII.GetBytes(hello);
            severSocket.SendTo(response,0,response.Length,SocketFlags.None,remote);
            Console.WriteLine("da dong ket noi voi clint");
            severSocket.Close();
        }
    }
}
