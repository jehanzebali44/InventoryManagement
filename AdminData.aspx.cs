using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InventoryManagementByWebForm
{
    public partial class AdminData : System.Web.UI.Page
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
            adminProps a = new adminProps();
            a.Username = TextBox1.Text;
            a.Email = TextBox5.Text;
            a.Password = TextBox3.Text;
            a.Gender = DropDownList1.Text;
            adminBLL A = new adminBLL();
            A.InsertBLL(a);
            TextBox1.Text = "";
            TextBox5.Text = "";
            TextBox3.Text = "";
            Label1.Text = "Admin data is inserted successfully!";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            adminProps a = new adminProps();
            a.Username = TextBox1.Text;
            a.Email = TextBox5.Text;
            a.Password = TextBox3.Text;
            a.Gender = DropDownList1.Text;
            adminBLL A = new adminBLL();
            A.UpdateBLL(a);
            TextBox1.Text = "";
            TextBox5.Text = "";
            TextBox3.Text = "";
            Label1.Text = "Admin data is updated successfully!";

        }
    }
}