using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCaPhe.Entities
{
    class ChiTietPhieuNhap
    {
        private string maPN;
        private string maSp;
        private int soluong;
        private double thanhtien;

        #region get,set
        public string MaPN { get => maPN; set => maPN = value; }
        public string MaSp { get => maSp; set => maSp = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public double Thanhtien { get => thanhtien; set => thanhtien = value; }
        #endregion

        #region contructor

        public ChiTietPhieuNhap() { }

        public ChiTietPhieuNhap(string maPN, string maSp,int soluong,double thanhtien)
        {
            this.MaPN = maPN;
            this.MaSp = maSp;
            this.Soluong = soluong;
            this.thanhtien = thanhtien;
        }

        #endregion
    }
}
