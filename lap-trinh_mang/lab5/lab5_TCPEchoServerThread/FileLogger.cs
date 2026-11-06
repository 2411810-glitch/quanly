using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;
using System.IO;

namespace lab5_TCPEchoServerThread
{
    class FileLogger
    {
        private static Mutex mutex = new Mutex();
        private StreamWriter output;
        public FileLogger(String filename)
        {
            output = new StreamWriter(filename, true);
        }
        public void writeEntry(ArrayList entry)
        {
            mutex.WaitOne();
            IEnumerator line = entry.GetEnumerator();
            while (line.MoveNext())
                Console.WriteLine(line.Current);
            output.Flush();
            mutex.ReleaseMutex();
        }
        public void writeEntry(string entry)
        {
            mutex.WaitOne();
            output.WriteLine(entry);
            output.WriteLine();
            output.Flush();
            mutex.ReleaseMutex();
        }
    }
}
