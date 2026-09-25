using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            args = new string[] {"google.com","lms.dlu.edu.vn" };
            foreach (string arg in args)
            {
                Console.WriteLine("phan giai ten mien" + arg);
                Gethostinfo(arg);
            }
            GetAll();
            Console.ReadKey();
            
        }
        static void Gethostinfo(string host)
        {
            try
            {
                IPHostEntry hostInfo = Dns.GetHostEntry(host);
                Console.WriteLine("ten mien: " + hostInfo.HostName);
                Console.Write("dia chi IP:");
                foreach (IPAddress ipaddr in hostInfo.AddressList)
                {
                    Console.Write(ipaddr.ToString() + " ");
                }
                Console.WriteLine();
            }
            catch (Exception)
            {
                Console.WriteLine("khong phan giai duoc ten mien:" + host + "\n");
            }
        }
        static void GetAll()
        {
            string hostName = Dns.GetHostName();
            Console.WriteLine("\nTên máy        : " + hostName);

            NetworkInterface[] interfaces =
            NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface ni in interfaces)
            {
                if (ni.OperationalStatus != OperationalStatus.Up)
                    continue;

                IPInterfaceProperties properties =
                    ni.GetIPProperties();

                foreach (UnicastIPAddressInformation ip in
                     properties.UnicastAddresses)
                {
                    if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        Console.WriteLine("\nCard mang      : " + ni.Name);
                        Console.WriteLine("Đia chi IP     : " + ip.Address);
                        Console.WriteLine("Subnet Mask    : " + ip.IPv4Mask);
                    }
                }
                foreach (GatewayIPAddressInformation gateway in
                     properties.GatewayAddresses)
                {
                    if (gateway.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        Console.WriteLine("Default Gateway: " + gateway.Address);
                    }
                }
            }
            

        }
    }
}
