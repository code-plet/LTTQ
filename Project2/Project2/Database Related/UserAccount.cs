using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    static class UserAccount
    {
        public static string UserID;
        public static bool QuanTriAccess;
        public static bool HeThongAccess;
        public static bool DanhMucAccess;
        public static bool NhanSuAccess;
        public static bool TienLuongAccess;
        public static bool BaoCaoAccess;

        public static void SetUser(string userID,string QuanTri,  DataTable dt)
        {
            UserID = userID;
            if (QuanTri == "True") QuanTriAccess = true;
            foreach(DataRow dr in dt.Rows)
            {
                switch (int.Parse(dr["NghiepVuID"].ToString()))
                {
                    case 1:
                        HeThongAccess = true;
                        break;
                    case 2:
                        DanhMucAccess = true;
                        break;
                    case 3:
                        NhanSuAccess = true;
                        break;
                    case 4:
                        TienLuongAccess = true;
                        break;
                    case 5:
                        BaoCaoAccess = true;
                        break;
                }
            }
        }

    }
}
