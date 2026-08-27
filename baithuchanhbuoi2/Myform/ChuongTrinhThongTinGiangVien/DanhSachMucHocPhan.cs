using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ChuongTrinhThongTinGiangVien
{
    public class DanhSachMucHocPhan
    {
        public List<HocPhan> ds;
        public DanhSachMucHocPhan()
        {
            ds = new List<HocPhan>();
        }
        public HocPhan this[int index]
        {
            get { return ds[index] as HocPhan;}
            set { ds[index] = value; }
        }
        public void Them(HocPhan hp)
        {
            ds.Add(hp);
        }
        public override string ToString()
        {
            string s = "Danh sach mon hoc:";
            foreach(object mh in ds) 
            {
                s += mh as HocPhan + ";";
            }
            return s;
        }
    }
}
