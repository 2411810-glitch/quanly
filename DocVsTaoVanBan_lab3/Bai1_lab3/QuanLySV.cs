using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace Bai1_lab3
{
	internal class QuanLySV
	{
		public List<Student> dssv;
		public QuanLySV()
		{
			dssv = new List<Student>();
		}

		public List<Student> DanhSach
		{
			get { return dssv; }
		}

		public int SoLuong
		{
			get { return dssv.Count; }
		}

		public Student this[int index]
		{
			get { return dssv[index]; }
			set { dssv[index] = value; }
		}
		public bool Them(Student sv)
		{
			if (dssv.Any(x => x.MSSV == sv.MSSV))
			return false;

			dssv.Add(sv);
			return true;
		}
		public bool CapNhat(Student a)
		{
			Student sv = dssv.FirstOrDefault(x => x.MSSV == a.MSSV);

			if (sv == null)
				return false;
			sv.HoVaTenLot = a.HoVaTenLot;
			sv.Ten = a.Ten;
			sv.NgaySinh = a.NgaySinh;
			sv.Lop = a.Lop;
			sv.SoCMND = a.SoCMND;
			sv.SoDT = a.SoDT;
			sv.DiaChi = a.DiaChi;
			sv.MonDangKy = a.MonDangKy;
			return true;
		}
		public List<Student> TimKiem(string mssv = "",string ten = "",string lop = "")
		{
			var ketQua = dssv.AsEnumerable();

			if (!string.IsNullOrWhiteSpace(mssv))
			{
				ketQua = ketQua.Where(x =>x.MSSV.Contains(mssv));
			}

			if (!string.IsNullOrWhiteSpace(ten))
			{
				ketQua = ketQua.Where(x =>x.HoTen.IndexOf(ten,StringComparison.OrdinalIgnoreCase) >= 0);
			}

			if (!string.IsNullOrWhiteSpace(lop))
			{
				ketQua = ketQua.Where(x => x.Lop.IndexOf(lop, StringComparison.OrdinalIgnoreCase) >= 0);
			}

			return ketQua.ToList();
		}
		public bool KiemTraMSSV(string mssv)
		{
			return Regex.IsMatch(mssv, @"^\d{7}$");
		}
		public bool KiemTraCMND(string cmnd)
		{
			return Regex.IsMatch(cmnd, @"^\d{9}$");
		}
		public bool KiemTraSDT(string sdt)
		{
			return Regex.IsMatch(sdt, @"^\d{10}$");
		}
		public void ThemSV(Student sv)
        {
			this.dssv.Add(sv);
        }
		public void DocTuFile(string filename)
		{
			string t;
			string[] s;
			Student sv;
			using (StreamReader sr = new StreamReader(
				new FileStream(filename, FileMode.Open)))
			{
				while ((t = sr.ReadLine()) != null)
				{
					s = t.Split('\t');
					sv = new Student();
					sv.MSSV = s[0];
					sv.HoVaTenLot = s[1];
					sv.Ten = s[2];
					sv.NgaySinh = DateTime.ParseExact(s[3].Trim(), "d/M/yyyy", System.Globalization.CultureInfo.InvariantCulture);
					sv.Lop = s[4];
					sv.SoCMND = s[5];
					sv.SoDT = s[6];
					sv.DiaChi = s[7];
					string[] mon = s[8].Split(',');
					foreach (string c in mon)
						sv.MonDangKy.Add(c);
					this.ThemSV(sv);
				}
			}
		}
	}
}
