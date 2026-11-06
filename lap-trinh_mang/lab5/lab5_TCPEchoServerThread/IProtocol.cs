using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_TCPEchoServerThread
{
    public interface IProtocol
    {
        void handleclient();
    }
}
