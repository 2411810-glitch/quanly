using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ChuongTrinhThongTinGiangVien
{
    internal class QuanLyGiangVien
    {
        List<GiangVien> dsGiangVien;
        public QuanLyGiangVien()
        {
            dsGiangVien = new List<GiangVien>();
        }
        public GiangVien this[int index]
        {
            get { return dsGiangVien[index]; }
            set { dsGiangVien[index] = value; }
        }
        public delegate int SoSanh
            (object a, object b);
        enum KieuTm
        {
            TheoMa,
            TheoHoTen,
            TheoSDT
        }
        public void SapXep(SoSanh ss,object a)
        {
            if(ss(KieuTm.TheoMa,a)==1)
                dsGiangVien.OrderBy(x => x.MaSo);
            if(ss(KieuTm.TheoHoTen,a)==1)
                dsGiangVien.OrderBy(x => x.HoTen);
            if (ss(KieuTm.TheoSDT, a) == 1)
                dsGiangVien.OrderBy(x => x.SoDT);
        }
        public GiangVien Tim(object a,SoSanh ss)
        {
            GiangVien gv = null;
            foreach(GiangVien o in dsGiangVien)
                if(ss(a,o)==0)
                {
                    gv = o;
                    break;
                }
            return gv;
        }
        public bool Them (GiangVien gv)
        {
            foreach (GiangVien vien in dsGiangVien)
            {
                if (gv.MaSo.Contains(vien.MaSo))
                {
                    dsGiangVien.Add(gv);
                    return true;
                }
            }
            return false;
        }
        public void Xoa(object temp,SoSanh ss)
        {
            int i = dsGiangVien.Count - 1;
            for(;i>=0;i--)
                if( ss(temp, this[i])==0)
                {
                    this.dsGiangVien.RemoveAt(i);
                }   
        }
    }
}
