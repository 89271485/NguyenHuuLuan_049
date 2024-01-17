using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_1
{
    class NHANVIEN
    {
        private String HoTen;
        private int SoNgayCong;
        private int SoNgayLamThem;
        private string XepLoai;
        private string BoPhan;
        public NHANVIEN()
        {
        }
        public  NHANVIEN(string hoten, int songaycong, int songaylamthem, string xeploai, string bophan)
        {
            this.HoTen = hoten;
            this.SoNgayCong = songaycong;
            this.SoNgayLamThem = songaylamthem;
            this.XepLoai = xeploai;
            this.BoPhan = bophan;
        }
        public string hoTen
        {
            set { HoTen = value; }
            get { return HoTen; }
        }
        public int songaycong
        {
            set { songaycong = value; }
            get { return songaycong; }
        }
        public string songaylamthem
        {
            set { songaylamthem = value; }
            get { return songaylamthem; }
        }
        public string bophan
        {
            set { BoPhan = value; }
            get { return bophan; }
        }
    }
}
