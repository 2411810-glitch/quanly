using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_lab3
{
	internal class Student
	{
		    public string MSSV { get; set; }
    public string HoVaTenLot { get; set; }
    public string Ten { get; set; }
    public DateTime NgaySinh { get; set; }
    public string Lop { get; set; }
    public string SoCMND { get; set; }
    public string SoDT { get; set; }
    public string DiaChi { get; set; }

    public List<string> MonDangKy { get; set; }

    public Student()
    {
        MonDangKy = new List<string>();
    }

    public Student(
        string mssv,
        string hoVaTenLot,
        string ten,
        DateTime ngaySinh,
        string lop,
        string soCMND,
        string soDT,
        string diaChi,
        List<string> monDangKy)
    {
        MSSV = mssv;
        HoVaTenLot = hoVaTenLot;
        Ten = ten;
        NgaySinh = ngaySinh;
        Lop = lop;
        SoCMND = soCMND;
        SoDT = soDT;
        DiaChi = diaChi;
        MonDangKy = monDangKy ?? new List<string>();
    }

    public string HoTen
    {
        get
        {
            return HoVaTenLot + " " + Ten;
        }
    }
	}
}
