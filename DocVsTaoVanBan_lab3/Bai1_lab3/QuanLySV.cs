using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;


namespace Bai1_lab3
{
	public class QuanLySV
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
			for (int i=0;i<dssv.Count;i++)
			{
				if(dssv[i].MSSV == a.MSSV)
				{
					dssv[i] = a;
					return true;
				}
			}
			return false;
		}

		public List<Student> TimKiem(string tuKhoa)
		{
			if (string.IsNullOrWhiteSpace(tuKhoa))
				return new List<Student>();

			tuKhoa = tuKhoa.Trim();

			return dssv.Where(sv =>
			sv.MSSV.IndexOf(tuKhoa, StringComparison.OrdinalIgnoreCase) >= 0 ||
			sv.HoTen.IndexOf(tuKhoa, StringComparison.OrdinalIgnoreCase) >= 0 ||
			sv.Lop.IndexOf(tuKhoa, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
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
					sv.GioiTinh = false;
					if(s[8]=="Nam")
						sv.GioiTinh= true;
					string[] mon = s[9].Split(',');
					foreach (string c in mon)
						sv.MonDangKy.Add(c);
					this.ThemSV(sv);
				}
			}
		}
		public List<Student> DocTuFileXML(string tenFile)
		{
			if (!File.Exists(tenFile))
				return new List<Student>();

			XmlSerializer serializer =new XmlSerializer(typeof(List<Student>));

			using (FileStream fs = new FileStream(tenFile, FileMode.Open, FileAccess.Read))
			{
				return (List<Student>)serializer.Deserialize(fs);
			}
		} 
		/*public List<Student> DocTuFileJSON(string tenFile)
		{
			if (!File.Exists(tenFile))
				return new List<Student>();

			string json = File.ReadAllText(tenFile);

			return JsonSerializer.Deserialize<List<Student>>(json)?? new List<Student>();
		}*/
	}
}
