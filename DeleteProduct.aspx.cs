using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InventoryManagementByWebForm
{
    public partial class DeleteProduct : System.Web.UI.Page
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
            ProductBLL A = new ProductBLL();
            A.DeleteBLL(a);
            TextBox2.Text = "";
            Label1.Text = "Your product is deleted successfully!";
        }
    }
}