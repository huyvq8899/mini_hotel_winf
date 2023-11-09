using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace TrungTamTinHoc.DanhMuc.BaoCao
{
    public class SQLCommandBaoCao
    {
        TrungTamTinHoc.DataContext.DataContext obj = new TrungTamTinHoc.DataContext.DataContext();

        public BaoCaoViewModel BaoCaoDoanhThu(DateTime fromDate, DateTime toDate, string TenPhong)
        {
            // Sử dụng string.Format để tạo câu lệnh SQL với giá trị trực tiếp
            string sql = string.Format(@"
        SELECT
            COUNT(MaDon) AS SoLuongHoaDon,
            SUM(ThanhTien) AS TongTienHoaDon
        FROM [hotel].[dbo].[HoaDon]
        WHERE GioVao >= '{0}' AND GioVao <= '{1}';
    ", fromDate, toDate, TenPhong);

            int soLuongHoaDon = 0;
            decimal tongTienHoaDon = 0;
            using (SqlCommand cmd = new SqlCommand(sql, obj.con))
            {
                obj.con.Open();
                SqlDataReader reader = cmd.ExecuteReader();



                if (reader.Read())
                {
                    soLuongHoaDon = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    tongTienHoaDon = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                }
                BaoCaoViewModel viewModel = new BaoCaoViewModel
                {
                    SoLuongHoaDon = soLuongHoaDon,
                    TongTienHoaDon = tongTienHoaDon
                };

                obj.con.Close();

                return viewModel;

            }
        }

    }
}
