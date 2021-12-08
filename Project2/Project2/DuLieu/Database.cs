using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Project2
{
    class Database
    {
        SqlConnection ketnoi = new SqlConnection(@"Server = .\SQLEXPRESS;Database=HRM_VTHP;Integrated Security=SSPI");

        public bool Execute(string cmd)
        {
            bool check = false;
            ketnoi.Open();

            try
            {
                SqlCommand caulenh = new SqlCommand(cmd, ketnoi);
                caulenh.ExecuteNonQuery();
                check = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi " + e.Message);
                check = false;
            }
            ketnoi.Close();
            return check;
        }

        public DataTable Read(string cmd)
        {
            ketnoi.Open();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand caulenh = new SqlCommand(cmd, ketnoi);
                SqlDataAdapter adapter = new SqlDataAdapter(caulenh);
                adapter.Fill(dt);
            }
            catch (Exception)
            {
                dt = null;
            }
            ketnoi.Close();
            return dt;
        }
    }
}

