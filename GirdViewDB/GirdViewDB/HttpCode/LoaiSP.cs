using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GirdViewDB.HttpCode
{
    public class LoaiSP
    {
        private int _MaL;
        private string _TenLoai;

        public int MaL { get => _MaL; set => _MaL = value; }
        public string TenLoai { get => _TenLoai; set => _TenLoai = value; }

        public LoaiSP()
        {
            MaL = 0;
            TenLoai = "";
        }

        public LoaiSP(int _MaL, string _TenLoai)
        {
            _MaL = 0;
            _TenLoai = "";
        }

     

        public bool exist(string _TenLoai)
        {
            String sQuery = "SELECT Count(*) FROM LoaiSP WHERE TenLoai = @TenLoai";
            SqlParameter[] sParams =
            {
                new SqlParameter("@TenLoai",_TenLoai)
            };
            return Convert.ToInt32(DataProvider.ExecQuery(sQuery,sParams).Rows[0][0]) > 0;
        }

        public List<LoaiSP> getList()
        {
            String sQuery = "SELECT * FROM LoaiSP";
            SqlParameter[] sParams =
            {
                new SqlParameter("@TenLoai",_TenLoai)
            };
            List<LoaiSP> lsl = new List<LoaiSP>();
            DataTable dt= DataProvider.ExecQuery(sQuery, sParams);
            foreach (DataRow dr in dt.Rows)
            {
                lsl.Add(convertToObject(dr));
            }
            return lsl;
        }


        public bool add()
        {
            String sQuery = "INSERT INTO [dbo].[LoaiSP] ([TenLoai]) VALUES (@TenLoai)";
            SqlParameter[] sParams =
            {
                new SqlParameter("@TenLoai",this._TenLoai)
            };
            return Convert.ToBoolean(DataProvider.ExecNoQuery(sQuery,sParams) > 0);
        }

        public bool update()
        {
            String sQuery = "UPDATE [dbo].[LoaiSP] SET [TenLoai] = @TenLoai WHERE MaL = @MaL";
            SqlParameter[] sParams =
            {
                new SqlParameter("@TenLoai",this._MaL),
                new SqlParameter("@TenLoai",this._TenLoai)
            };
            return Convert.ToBoolean(DataProvider.ExecNoQuery(sQuery, sParams) > 0);
        }

       
        public LoaiSP convertToObject(DataRow dr)
        {
            LoaiSP l = new LoaiSP();
            l.MaL = Convert.ToInt32(dr["MaL"]);
            l.TenLoai = dr["TenLoai"].ToString();
            return l;
        }
    }
}