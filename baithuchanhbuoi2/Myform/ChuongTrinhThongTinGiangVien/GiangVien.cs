using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuongTrinhThongTinGiangVien
{
    public class GiangVien
    {
        public string MaSo {  get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public DanhSachMucHocPhan dsHocPhan;
        public string GioiTinh;
        public string[] NgoaiNgu;
        public string SoDT;
        public string Mail;
        public GiangVien() 
        {
            dsHocPhan = new DanhSachMucHocPhan();
            NgoaiNgu = new string[20];
        }
        public GiangVien(string maSo, string hoTen, DateTime ngaySinh, DanhSachMucHocPhan dsHocPhan, string gioiTinh, string[] ngoaiNgu, string soDT, string mail)
        {
            MaSo = maSo;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            this.dsHocPhan = dsHocPhan;
            GioiTinh = gioiTinh;
            NgoaiNgu = ngoaiNgu;
            SoDT = soDT;
            Mail = mail;
        }
        public override string ToString()
        {
            string s = "Ma so:"+MaSo+"\n"
                +"Ho Ten:" + HoTen + "\n"
                +"Ngay Sinh:" + NgaySinh + "\n"
                +"Gioi Tinh:" + GioiTinh + "\n"
                +"So DT:" + SoDT + "\n"
                +"Mail:" + Mail + "\n";
            string sngoaingu = "Ngoai Ngu";
            foreach(string t  in NgoaiNgu)
                sngoaingu += t+";";
            string monDay = "Danh sach mon  day";
            foreach (HocPhan hp in dsHocPhan.ds)
                monDay += hp + ";";
            s += "\n" + sngoaingu + "\n" + monDay;
            return s;
        }
    }
}
