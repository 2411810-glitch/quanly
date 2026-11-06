using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace lab5_TCPEchoServerThread
{
    interface ILogger
    {
        void writeEntry(ArrayList entry);
        void writeEntry(String entry);
    }
}
