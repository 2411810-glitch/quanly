using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DocVsTaoVanBan_lab3
{
    class FileInfo
    {
        private void WriteReadText(string filename, string[] text)
        {
            File.WriteAllLines(filename, text);
            foreach(string s in File.ReadAllLines(filename))
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
