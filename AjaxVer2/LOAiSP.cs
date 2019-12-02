using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace AjaxVer2
{
    public class LOAiSP
    {
        private int _maL;
        private string _tenLoai;

        public LOAiSP()
        {
        }

        public LOAiSP(int maL, string tenLoai)
        {
            MaL = maL;
            TenLoai = tenLoai;
        }

        public int MaL { get => _maL; set => _maL = value; }
        public string TenLoai { get => _tenLoai; set => _tenLoai = value; }

        public static bool insert(LOAiSP l)
        {
            string sQuery =string.Format("INSERT INTO [dbo].[LoaiSP] ([TenLoai]) VALUES ('{0}')",l.TenLoai);

            return DataProvider.ExecuteNonQuery(sQuery) > 0;
        }

        public static DataTable search(string tenloai)
        {
            string sQuery ="SELECT * FROM LoaiSP WHERE TenLoai like '%"+ tenloai + "%'";
            return DataProvider.ExecuteQuery(sQuery);
        }


        public static DataTable getList()
        {
            string sQuery = "SELECT * FROM LoaiSP";
            return DataProvider.ExecuteQuery(sQuery);
        }

    }
}