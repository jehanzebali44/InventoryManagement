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
    public partial class Salesman : System.Web.UI.Page
    {
        SqlConnection con;
        string constring, query;
        SqlCommand cmd;
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
                string query = "select * from WorkersData ORDER BY Name ASC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                GridView1.DataSource = tb;
                GridView1.DataBind();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            constring = @"Data Source = JAZZY ;
            Initial Catalog = InventoryWebForm;
            User ID =;
            Password = ;
            Trusted_Connection = True";
            con = new SqlConnection(constring);
            con.Open();
            query = "Insert into WorkersData values('" + TextBox1.Text + "','" + TextBox2.Text + "')";
            cmd = new SqlCommand(query, con);
            i=cmd.ExecuteNonQuery();
            if (i != 0)
            {
                Label1.Text = "Data is inserted successfully!";
            }
            con.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            constring = @"Data Source = JAZZY ;
            Initial Catalog = InventoryWebForm;
            User ID =;
            Password = ;
            Trusted_Connection = True";
            query = "Delete WorkersData where Name = '" + TextBox1.Text + "'";
            cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                Label1.Text = "Data is deleted successfully!";
            }
            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            constring = @"Data Source = JAZZY ;
            Initial Catalog = InventoryWebForm;
            User ID =;
            Password = ;
            Trusted_Connection = True";
            con = new SqlConnection(constring);
            con.Open();
            query = "Update WorkersData set CNIC ='" + TextBox2.Text + "' where Name = '" + TextBox1.Text + "'";
            cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                Label1.Text = "Data is updated successfully!";
            }
            con.Close();
        }
    }
}