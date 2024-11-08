using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCaPhe.Entities
{
    class PhieuNhap
    {
        private string maPhieuNhap ;
        private string maNV;
        private DateTime ngaynhap;
        private string nguoigiaohang;
        private string ghichu;

        #region get, setter
        public string MaPhieuNhap { get => maPhieuNhap; set => maPhieuNhap = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public DateTime Ngaynhap { get => ngaynhap; set => ngaynhap = value; }
        public string Nguoigiaohang { get => nguoigiaohang; set => nguoigiaohang = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        #endregion

        #region Contructor
        public PhieuNhap() { }

        public PhieuNhap(string maPX, string maNV, DateTime ngaynhap, string nguoigiaohang, string ghichu)
        {
            this.maNV = maNV;
            this.MaPhieuNhap = maPX;
            this.ngaynhap = ngaynhap;
            this.nguoigiaohang = nguoigiaohang;
            this.ghichu = ghichu;
        }

        

        #endregion

    }
}
