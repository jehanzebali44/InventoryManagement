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
    public partial class BillHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] == null)
            {
                Response.Redirect("ShopLogin.aspx");
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
                string query = "select * from BillHistory";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable tb = new DataTable();
                if (tb != null)
                {
                    adapter.Fill(tb);
                    GridView1.DataSource = tb;
                    GridView1.DataBind();
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShopPortal.aspx");
        }
    }
}