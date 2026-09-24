using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLySinhVien_lab2
{
    public delegate int SoSanh(object sv1, object sv2);
    public class QuanLySinhVien
    {
        public List<SinhVien> dsSinhVien;
        public QuanLySinhVien()
        {
            dsSinhVien = new List<SinhVien>();
        }
        public SinhVien this [int index]
        {
            get { return this.dsSinhVien[index]; }
            set { dsSinhVien[index] = value; }
        }
        public void Them(SinhVien sv)
        {
            this.dsSinhVien.Add(sv);
        }
        public SinhVien Tim(object obj,SoSanh ss)
        {
            SinhVien svresult = null;
            foreach(SinhVien sv in dsSinhVien)
                if(ss(obj,sv)==0)
                {
                    svresult = sv;
                    break;
                }
            return svresult;
        }
        public bool Sua(SinhVien svsua,object obj,SoSanh ss )
        {
            int i, cout;
            bool kq = false;
            cout = this.dsSinhVien.Count - 1;
            for (i = 0; i < cout; i++) 
                if(ss(obj,this[i])==0)
                {
                    this[i] = svsua;
                    kq = true;
                    break;
                }
            return kq;
        }
        public void Xoa (object obj,SoSanh ss)
        {
            int i = dsSinhVien.Count - 1;
            for (; i >= 0; i--)
                if (ss(obj, this[i]) == 0)
                    this.dsSinhVien.RemoveAt(i);
        }
        public void DocTuFile(string filename)
        {
            string t;
            string[] s;
            SinhVien sv;
            using (StreamReader sr =new StreamReader(
                new FileStream(filename, FileMode.Open)))
            {
                while ((t=sr.ReadLine()) != null)
                {
                    s = t.Split('\t');
                    sv = new SinhVien();
                    sv.MaSo = s[0];
                    sv.HoTen = s[1];
                    sv.NgaySinh = DateTime.Parse(s[2]);
                    sv.DiaChi = s[3];
                    sv.Lop = s[4];
                    sv.Hinh = s[5];
                    sv.GioiTinh = false;
                    if (s[6] == "1")
                        sv.GioiTinh = true;
                    string[] cn = s[7].Split(',');
                    foreach (string c in cn)
                        sv.ChuyenNganh.Add(c);
                    this.Them(sv);
                }
            }
        }
        public delegate int SoSanh
            (object a, object b);
        enum Kieu { 
        MaSV,
        HoTen,
        NgaySinh}
        public void SapXep(SoSanh ss,object a)
        {
            if (ss(Kieu.MaSV, a) == 1)
                dsSinhVien = dsSinhVien.OrderBy(x => x.MaSo).ToList();
            if (ss(Kieu.HoTen, a) == 1)
                dsSinhVien = dsSinhVien.OrderBy(x => x.HoTen).ToList();
            if (ss(Kieu.NgaySinh, a) == 1)
                dsSinhVien = dsSinhVien.OrderBy(x => x.NgaySinh).ToList();
        }
    }
}
