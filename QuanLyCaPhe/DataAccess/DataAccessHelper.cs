﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QuanLyCaPhe.DataAccess
{
    class DataAccessHelper
    {

        static string connec = @"Data Source=DESKTOP-06D4HKR\SQLEXPRESS01;Initial Catalog=QuanLyNhanVienCoffee;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connec);
        SqlDataAdapter adap;
        SqlCommand cmd;
        

        /// <summary>
        /// Mở kết nối
        /// </summary>
        public void KetNoi()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }
       /// <summary>
       /// Ngắt kết nối
       /// </summary>
        public void NgatKetNoi()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }


        public DataTable get_DaTaTable(string clSelect)
        {
            adap = new SqlDataAdapter(clSelect, connection);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
       
       
      /// <summary>
      /// Thực thi câu lệnh select
      /// </summary>
      /// <param name="caulenh"> </param>
 
        public void ThucThiCL(string caulenh)
        {
            KetNoi();
            cmd = new SqlCommand(caulenh, connection);
            cmd.ExecuteNonQuery();// thực thi câu lệnh Insert, Update, delete
            NgatKetNoi();
        }
       
  //kiem tra ma
        public int TongBanGhi(string strSelect)
        {
            DataTable dtTong = new DataTable();
            adap = new SqlDataAdapter(strSelect, connec);
            adap.Fill(dtTong);
            // 
            int sbg = dtTong.Rows.Count;
            return sbg;

        }

        // lấy tên  theo mã
        public  string GetFieldValues(string sql)
        {
            string ma = "";
            KetNoi();
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;
        }

    }
}

   
