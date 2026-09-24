using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DocVsTaoVanBan_lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            string Str = "";
            string Path = "../../students.json";
            List<StudentInfo> List = LoadJSON(Path);
            for(int i = 0; i < List.Count; i++) 
            {
                StudentInfo info = List[i];
                Str += string.Format("Sinh vien {0} co MSSV: {1},ho ten: {2}," + "diem TB: {3}\r\n",(i+1),info.MSSV,info.HoTen,info.Diem);
            }
            MessageBox.Show(Str);
        }
        private List<StudentInfo> LoadJSON(string Path)
        {
            List<StudentInfo> list = new List<StudentInfo>();
            StreamReader r = new StreamReader(Path);
            string json = r.ReadToEnd();
            var array = (JObject)JsonConvert.DeserializeObject(json);
            var student = array["sinhvien"].Children();
            foreach (var item in student)
            {
                string mssv = item["MSSV"].Value<string>();
                string hoten = item["hoten"].Value<string>();
                int tuoi = item["tuoi"].Value<int>();
                double diem = item["diem"].Value<double>();
                bool tongiao = item["tongiao"].Value<bool>();
                StudentInfo info = new StudentInfo(mssv,hoten,tuoi,diem,tongiao);
                list.Add(info);
            }
            return list;
        }
    }
}
