using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace InventoryManagementByWebForm
{
    public class ProductDAL
    {
        SqlConnection con;
        SqlCommand cmd;
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
        public int InsertDAL(productPropos a)
        {
            connection();
            query = "Insert into AddProduct values('" + a.ID + "','" + a.Name + "','" + a.Price + "')";
            cmd = new SqlCommand(query, con);
            int rs = cmd.ExecuteNonQuery();
            con.Close();
            return rs;
        }
        public int UpdateDAL(productPropos a)
        {
            connection();
            query = "Update AddProduct set Name ='" + a.Name + "'Price = '" + a.Price + "' where ID = '" + a.ID + "'";
            cmd = new SqlCommand(query, con);
            int rs = cmd.ExecuteNonQuery();
            con.Close();
            return rs;
        }
        public int DeleteDAL(productPropos a)
        {
            connection();
            query = "Delete AddProduct where ID = '" + a.ID + "'";
            cmd = new SqlCommand(query, con);
            int rs = cmd.ExecuteNonQuery();
            con.Close();
            return rs;
        }
    }
}