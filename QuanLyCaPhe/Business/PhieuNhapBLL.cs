using QuanLyCaPhe.DataAccess;
using QuanLyCaPhe.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QuanLyCaPhe.Business
{
    class PhieuNhapBLL
    {
        DataAccessHelper dah = new DataAccessHelper();
        PhieuNhapDAL pnDAL = new PhieuNhapDAL();

        // load data
        public DataTable loadData()
        {
            return pnDAL.loadDataPhieuNhap();
        }

        // insert
        public void insertDataPN(string mapn, string manv, DateTime ngaynhap, string nguoigiaohang, string ghichu )
        {
            pnDAL.insertDataPN(new PhieuNhap(mapn,manv,ngaynhap,nguoigiaohang,ghichu));
        }

        public void insertDataCTPN(string mapn, string maSp, int soluong, double thanhtien)
        {
            pnDAL.insertDataCTPN(new ChiTietPhieuNhap(mapn,maSp,soluong,thanhtien));
        }

        // update
        public void updateDataPN(string mapn, string manv, DateTime ngaynhap, string nguoigiaohang, string ghichu)
        {
            pnDAL.updateDataPN(new PhieuNhap(mapn, manv, ngaynhap, nguoigiaohang, ghichu));
        }

        public void updateDataCTPN(string mapn, string masp, int soluong, double thanhtien)
        {
            pnDAL.updateDataCTPN( new ChiTietPhieuNhap(mapn,masp,soluong,thanhtien));
        }

        //detele 
        public void deteleDataPN(string mapn)
        {
            pnDAL.deleteDataPN(mapn);
        }

        public void deteleDataCTPN(string mapn, string masp)
        {
            pnDAL.deleteDataCTPN(mapn,masp);
        }

        // check primarykey
        public int TongBanGhiPN(string ma)
        {
            return pnDAL.DemBanGhiPN(ma);
        }
        public int TongBanGhiCTPN(string mapn, string masp)
        {
            return pnDAL.DemBanGhiCTPN(mapn,masp);
        }

    }
}
