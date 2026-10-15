using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


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
        public SinhVien Tim(Kieu kieu,object a)
        {
			SinhVien sv = new SinhVien();
			switch(kieu)
			{
				case Kieu.MaSV:
					sv = dsSinhVien.FirstOrDefault(x=>x.MaSo==a.ToString());
					break;
				case Kieu.HoTen:
					sv = dsSinhVien.FirstOrDefault(x=>x.HoTen==a.ToString());
					break;
				case Kieu.NgaySinh:
					DateTime ngay = Convert.ToDateTime( a );
					sv = dsSinhVien.FirstOrDefault( x => x.NgaySinh.Date == ngay );
					break;
			}
			return sv;
        }
        public bool Sua(SinhVien svsua,string maSo)
        {
            int i, cout;
            bool kq = false;
            cout = this.dsSinhVien.Count - 1;
            for (i = 0; i <= cout; i++)
            {
                if (string.Compare(dsSinhVien[i].MaSo, maSo) == 0)
                {

                    this[i] = svsua;
                    kq = true;
                    break;
                }
            }
            return kq;
        }
        public bool Xoa(string maSo)
		{
			for (int i = dsSinhVien.Count - 1; i >= 0; i--)
			{
				if (dsSinhVien[i].MaSo == maSo)
				{
					dsSinhVien.RemoveAt(i);
					return true;
				}
			}
			return false;
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
				sv.NgaySinh = DateTime.ParseExact(s[2].Trim(),"d/M/yyyy",System.Globalization.CultureInfo.InvariantCulture);
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
		public int SoSanhKieu(object a, object b)
		{
			return  ((Kieu)a).CompareTo(b);
		}
        public enum Kieu { 
        MaSV,
        HoTen,
        NgaySinh}
       
		public void SapXep(Kieu kieu)
{
    switch (kieu)
    {
        case Kieu.MaSV:
            dsSinhVien = dsSinhVien.OrderBy(x => x.MaSo).ToList();
            break;

        case Kieu.HoTen:
            dsSinhVien = dsSinhVien.OrderBy(x => x.HoTen).ToList();
            break;

        case Kieu.NgaySinh:
            dsSinhVien = dsSinhVien.OrderBy(x => x.NgaySinh).ToList();
            break;
    }
}
    }
}
