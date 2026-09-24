using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocVsTaoVanBan_lab3
{
    public class StudentInfo
    {
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public double Diem { get; set; }
        public bool TonGiao { get; set; }
        public StudentInfo(string ms,string ten,int tuoi,double diem,bool tongiao)
        {
            this.MSSV = ms;
            this.HoTen = ten;
            this.Tuoi = tuoi;
            this.Diem = diem;
            this.TonGiao = tongiao;
        }
    }
}
