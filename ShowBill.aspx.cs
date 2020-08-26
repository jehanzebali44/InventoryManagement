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
    public partial class ShowBill : System.Web.UI.Page
    {
        int GrandTotal;
        string constring, query;
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["name"] == null)
            {
                Response.Redirect("ShopLogin.aspx");
            }
            else
            {
                constring = @"Data Source = JAZZY ;
                Initial Catalog = InventoryWebForm;
                User ID =;
                Password = ;
                Trusted_Connection = True";
                con = new SqlConnection(constring);
                con.Open();
                string myquery = "select * from Bill";
                SqlDataAdapter adapter = new SqlDataAdapter(myquery, con);
                DataTable tb = new DataTable();
                if (tb != null)
                {
                    adapter.Fill(tb);
                    GridView1.DataSource = tb;
                    GridView1.DataBind();
                }
                string servedBy = (string)Session["ServedBy"];
                Label1.Text = "Served By: " + servedBy;
                query = "select * from Bill";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string mytotal= reader.GetString(4);
                    int total = Int32.Parse(mytotal);
                    GrandTotal = GrandTotal + total;

                }
                Label2.Text = "Total Bill: " + GrandTotal;
                reader.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int NoOfProduct = 0; ;
            constring = @"Data Source = JAZZY ;
            Initial Catalog = InventoryWebForm;
            User ID =;
            Password = ;
            Trusted_Connection = True";
            con = new SqlConnection(constring);
            con.Open();
            query = "select * from Bill";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                NoOfProduct = NoOfProduct + 1;

            }
            reader.Close();
            string servedBy = (string)Session["ServedBy"];
            string newQuery = "Insert into BillHistory values('" + NoOfProduct + "','" + servedBy + "','" + GrandTotal + "')";
            SqlCommand cmd = new SqlCommand(newQuery, con);
            cmd.ExecuteNonQuery();
            query = "Delete from Bill";
            SqlCommand cmdDel = new SqlCommand(query, con);
            cmdDel.ExecuteNonQuery();
            con.Close();
            Response.Redirect("CreateBill.aspx");
        }
    }
}