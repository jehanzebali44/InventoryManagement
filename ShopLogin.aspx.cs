using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InventoryManagementByWebForm
{
    public partial class ShopLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            userProps a = new userProps();
            a.Username = TextBox1.Text;
            a.Password = TextBox2.Text;
            UserBLL A = new UserBLL();
            int b = A.SelectBLL(a);
            if (b > 0)
            {
                Session["name"] = TextBox1.Text;
                Response.Redirect("ShopPortal.aspx");
            }
            else
            {
                if (TextBox1.Text.Equals("") && TextBox2.Text.Equals(""))
                {
                    Label1.Text = "Write Username and Password First";
                }
                else if (TextBox1.Text.Equals(""))
                {
                    Label1.Text = "Write Username First";
                }
                else if (TextBox2.Text.Equals(""))
                {
                    Label1.Text = "Write Password First";
                }
                else
                {
                    Label1.Text = "Incorrect Username or Password";
                }
            }
        }
    }
}