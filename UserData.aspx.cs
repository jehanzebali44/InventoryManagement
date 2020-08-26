using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InventoryManagementByWebForm
{
    public partial class UserData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("AdminLogin.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            userProps a = new userProps();
            a.Username = TextBox1.Text;
            a.Email = TextBox5.Text;
            a.Password = TextBox3.Text;
            a.Gender = DropDownList1.Text;
            UserBLL A = new UserBLL();
            A.InsertBLL(a);
            TextBox1.Text = "";
            TextBox5.Text = "";
            TextBox3.Text = "";
            Label1.Text = "User data is inserted successfully!";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            userProps a = new userProps();
            a.Username = TextBox1.Text;
            a.Email = TextBox5.Text;
            a.Password = TextBox3.Text;
            a.Gender = DropDownList1.Text;
            UserBLL A = new UserBLL();
            A.UpdateBLL(a);
            TextBox1.Text = "";
            TextBox5.Text = "";
            TextBox3.Text = "";
            Label1.Text = "User data is updated successfully!";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            userProps a = new userProps();
            a.Username = TextBox1.Text;
            UserBLL A = new UserBLL();
            A.DeleteBLL(a);
            TextBox1.Text = "";
            TextBox5.Text = "";
            TextBox3.Text = "";
            Label1.Text = "User data is deleted successfully!";
        }
    }
}