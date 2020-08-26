using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InventoryManagementByWebForm
{
    public partial class UserList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("AdminLogin.aspx");
            }
            else
            {
                string constring = @"Data Source = JAZZY ;
                Initial Catalog = InventoryWebForm;
                User ID =;
                Password = ;
                Trusted_Connection = True";
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                string query = "select * from UserData";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                GridView1.DataSource = tb;
                GridView1.DataBind();
            }
        }
    }
}