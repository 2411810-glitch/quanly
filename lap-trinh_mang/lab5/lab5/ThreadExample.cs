using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace lab5
{
    class ThreadExample
    {
        static void Main(string[] args)
        {
            MythreadClass mtc1 = new MythreadClass("Day la tieu trinh thu nhat");
            Thread thread1 = new Thread(new ThreadStart(mtc1.runMyThread));
            thread1.Start();

            MythreadClass mtc2 = new MythreadClass("Day la tieu trinh thu hai");
            Thread thread2 = new Thread(new ThreadStart(mtc2.runMyThread));
            thread2.Start();

            Console.ReadKey();
        }
    }
}
