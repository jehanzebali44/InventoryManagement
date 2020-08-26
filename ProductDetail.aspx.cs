using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InventoryManagementByWebForm
{
    public partial class ProductDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] == null)
            {
                Response.Redirect("ShopLogin.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            productPropos a = new productPropos();
            a.ID = TextBox2.Text;
            a.Name = TextBox1.Text;
            a.Price = TextBox4.Text;
            ProductBLL A = new ProductBLL();
            A.InsertBLL(a);
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox4.Text = "";
            Label1.Text = "Your product is added successfully!";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            productPropos a = new productPropos();
            a.ID = TextBox2.Text;
            a.Name = TextBox1.Text;
            a.Price = TextBox4.Text;
            ProductBLL A = new ProductBLL();
            A.UpdateBLL(a);
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox4.Text = "";
            Label1.Text = "Your product is Updated successfully!";
        }
    }
}