using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace lab3_clinet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint serverEnd = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5000);

            Socket clientSocket = new Socket(
            AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            byte[] buff = Encoding.ASCII.GetBytes("Hello Server");

            clientSocket.SendTo(buff, 0, buff.Length, SocketFlags.None, serverEnd);

            EndPoint remote = new IPEndPoint(IPAddress.Any, 0);
            byte[] response = new byte[1024];

            int received = clientSocket.ReceiveFrom(response, 0, response.Length, SocketFlags.None, ref remote);

            Console.WriteLine(Encoding.ASCII.GetString(response, 0, received));

            clientSocket.Close();
        }
    }
}
