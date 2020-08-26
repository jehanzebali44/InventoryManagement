using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace InventoryManagementByWebForm
{
    public class adminDAL
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        string constring, query;
        public void connection()
        {
            constring = @"Data Source = JAZZY ;
            Initial Catalog = InventoryWebForm;
            User ID =;
            Password = ;
            Trusted_Connection = True";
            con = new SqlConnection(constring);
            con.Open();
        }
        public int InsertDAL(adminProps a)
        {
            connection();
            query = "Insert into admin values('" + a.Username + "','" + a.Email + "','" + a.Password + "','" + a.Gender + "')";
            cmd = new SqlCommand(query, con);
            int rs = cmd.ExecuteNonQuery();
            con.Close();
            return rs;
        }
        public int UpdateDAL(adminProps a)
        {
            connection();
            query = "Update admin set Email ='" + a.Email + "',Password = '" + a.Password + "',Gender = '" + a.Gender + "' where Username = '" + a.Username + "'";
            cmd = new SqlCommand(query, con);
            int rs = cmd.ExecuteNonQuery();
            con.Close();
            return rs;
        }
        public int SelectDAL(adminProps a)
        {
            connection();
            query = "Select * from admin where Username='" + a.Username + "' and Password= '" + a.Password + "'";
            adapter = new SqlDataAdapter(query, con);
            DataTable tb = new DataTable();
            int v = adapter.Fill(tb);
            if (tb.Rows.Count == 4)
            {
            }
            return v;
        }
    }
}