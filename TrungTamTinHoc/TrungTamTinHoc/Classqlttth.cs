using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TrungTamTinHoc
{
    class Classqlttth
    {
        TrungTamTinHoc.DataContext.DataContext obj = new TrungTamTinHoc.DataContext.DataContext();
        public Classqlttth()
        {

          
        }

        //hàm đổi mật khẩu
        public bool DOIMATKHAU(string _manv, string _pass)
        {
            string sql = "update admind set pass=N'" + _pass + "' where ma=N'" + _manv + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, obj.con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return true;
        }
        //===========HAM KIEM TRA USER DANG NHAP VAO HE THONG================
        public bool kiemtrauser(string _user, string _pass)
        {
            string sql = "select * from NguoiDung where username=N'" + _user + "' AND password=N'" + _pass + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, obj.con);
            obj.con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds);
            obj.con.Close();
            if (ds.Tables[0].Rows.Count == 1)
                return true;
            else
                return false;
      
        }
        //===========HAM KIEM TRA XEM MA LOP HOC  NHAP CO TRUNG KHONG================
       
    }
}