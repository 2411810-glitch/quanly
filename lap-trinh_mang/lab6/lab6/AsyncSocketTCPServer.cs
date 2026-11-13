using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace lab6
{
    public class AsyncSocketTCPServer
    {
        IPAddress mIP;
        int mPort;
        TcpListener mTCPListener;
        List<TcpClient> mClient;
        public bool KeepRunning { get; set; }
        public AsyncSocketTCPServer()
        {
            mClient = new List<TcpClient>();
        }
        public async void StartListeningForIncomingConnection(IPAddress ipaddr = null, int port = 9001)
        {
            if (ipaddr == null)
            {
                ipaddr = IPAddress.Any;
            }
            if (port < 0)
            {
                port = 9001;
            }
            mIP = ipaddr;
            mPort = port;
            System.Diagnostics.Debug.WriteLine(string.Format("IP Address: {0} - Port: {1}",mIP.ToString(),mPort));
            mTCPListener = new TcpListener(mIP, mPort);
            try
            {
                
            }catch(Exception ex)
            {

            }
        }
    }
}
