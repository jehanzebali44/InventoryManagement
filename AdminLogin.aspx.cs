using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InventoryManagementByWebForm
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            adminProps a = new adminProps();
            a.Username = TextBox1.Text;
            a.Password = TextBox2.Text;
            adminBLL A = new adminBLL();
            int b = A.SelectBLL(a);
            if (b > 0)
            {
                Session["username"] = TextBox1.Text;
                Response.Redirect("AdminPortal.aspx");
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

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}