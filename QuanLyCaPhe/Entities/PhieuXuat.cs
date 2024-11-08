using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCaPhe.Entities
{
    class PhieuXuat
    {
        private string mapx;
        private string manvxuat;
        private DateTime ngayxuat;
        private int banso;
        
        
        #region thuoc tinh
       
        public string Mapx
        {
            get { return mapx; }
            set { mapx = value; }
        }
        public string Manvxuat
        {
            get { return manvxuat; }
            set { manvxuat = value; }
        }
        public DateTime  Ngayxuat
        {
            get { return ngayxuat; }
            set { ngayxuat = value; }
        }
     
        public int Banso
        {
            get { return banso; }
            set { banso = value; }
        }
       
        #endregion
      //phuong thuc khoi tao khong tham so
            public PhieuXuat()
            {
                this.mapx = "";
                this.manvxuat = "";
                this.banso = 0;

                this.ngayxuat = new DateTime();
            
            }
        //phuong thuc khi tao co tham so
            public PhieuXuat(string mapx,string manvxuat,int  banso)
            {
                this.mapx = mapx;
                this.manvxuat = manvxuat;
                 this.banso = banso;
               
            }

        public PhieuXuat(string mapx, string manvxuat, DateTime ngayxuat, int banso)
        {
            this.mapx = mapx;
            this.manvxuat = manvxuat;
            this.ngayxuat = ngayxuat;
            this.Banso = banso;
           
        }
    }
}
