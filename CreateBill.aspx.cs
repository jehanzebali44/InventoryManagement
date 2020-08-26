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
    public partial class CreateBill : System.Web.UI.Page
    {
        string constring, query, name, price, pTotal;
        SqlConnection con;

        protected void Button1_Click(object sender, EventArgs e)
        {
            DropDownList2.Visible = false;
            Label4.Visible = false;
            Button1.Visible = false;
            Button5.Visible = false;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Session["ServedBy"] = DropDownList2.Text;
            Response.Redirect("ShowBill.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DropDownList2.Visible = true;
            Label4.Visible = true;
            Button1.Visible = true;
            Button5.Visible = true;
            constring = @"Data Source = JAZZY ;
            Initial Catalog = InventoryWebForm;
            User ID =;
            Password = ;
            Trusted_Connection = True";
            con = new SqlConnection(constring);
            con.Open();
            query = "select * from WorkersData";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                DropDownList2.Items.Add(reader.GetString(0));
            }
            reader.Close();
        }

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
                query = "select * from AddProduct";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                if (DropDownList1.Text.Equals(""))
                {
                    while (reader.Read())
                {
                    
                        DropDownList1.Items.Add(reader.GetString(0));
                }
                }
                reader.Close();
                string myquery = "select * from Bill";
                SqlDataAdapter adapter = new SqlDataAdapter(myquery, con);
                DataTable tb = new DataTable();
                if (tb != null)
                {
                    adapter.Fill(tb);
                    GridView1.DataSource = tb;
                    GridView1.DataBind();
                }
                

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string id = DropDownList1.Text;
            constring = @"Data Source = JAZZY ;
            Initial Catalog = InventoryWebForm;
            User ID =;
            Password = ;
            Trusted_Connection = True";
            con = new SqlConnection(constring);
            con.Open();
            query = "Delete from Bill";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (!TextBox1.Text.Equals(""))
            {
                Label1.Text = "";
                int total;
                string quantity = TextBox1.Text;
                string id = DropDownList1.Text;
                string constring = @"Data Source = JAZZY ;
                Initial Catalog = InventoryWebForm;
                User ID =;
                Password = ;
                Trusted_Connection = True";
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                query = "select * from AddProduct where ID='" + id + "'";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int Quantity = Int32.Parse(quantity);
                    name = reader.GetString(1);
                    price = reader.GetString(2);
                    int productPrice = Int32.Parse(price);
                    total = productPrice * Quantity;
                    pTotal = total.ToString();
                }
                reader.Close();
                string newQuery = "Insert into Bill values('" + id + "','" + name + "','" + quantity + "','" + price + "','" + pTotal + "')";
                SqlCommand cmd = new SqlCommand(newQuery, con);
                cmd.ExecuteNonQuery();
                string myquery = "select * from Bill";
                SqlDataAdapter adapter = new SqlDataAdapter(myquery, con);
                DataTable tb = new DataTable();
                if (tb != null)
                {
                    adapter.Fill(tb);
                    GridView1.DataSource = tb;
                    GridView1.DataBind();
                }
            }
            else
            {
                Label1.Text = "Enter product firts!";
            }

        }
    }
}