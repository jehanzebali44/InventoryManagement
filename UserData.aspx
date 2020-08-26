<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserData.aspx.cs" Inherits="InventoryManagementByWebForm.UserData" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
      <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Inventory Management</title>
	<!-- Bootstrap Styles-->
    <link href="assets/css/bootstrap.css" rel="stylesheet" />
     <!-- FontAwesome Styles-->
    <link href="assets/css/font-awesome.css" rel="stylesheet" />
        <!-- Custom Styles-->
    <link href="assets/css/custom-styles.css" rel="stylesheet" />
     <!-- Google Fonts-->
   <link href='http://fonts.googleapis.com/css?family=Open+Sans' rel='stylesheet' type='text/css' />
</head>
<body>
    <div id="wrapper">
        <nav class="navbar navbar-default top-navbar" role="navigation">
            <ul class="nav navbar-top-links navbar-right">       
                <li class="dropdown">
                    <a class="dropdown-toggle" data-toggle="dropdown" href="#" aria-expanded="false">
                        <i class="fa fa-user fa-fw"></i> <i class="fa fa-caret-down"></i>
                    </a>
                    <ul class="dropdown-menu dropdown-user">
                        <li class="divider"></li>
                        <li><a href="AdminLogin.aspx"><i class="fa fa-sign-out fa-fw"></i> Logout</a>
                        </li>
                    </ul>
                </li>
            </ul>
        </nav>
          <nav class="navbar-default navbar-side" role="navigation">
            <div class="sidebar-collapse">
                <ul class="nav" id="main-menu">
                    <li>
                        <a href="AdminLogin.aspx" class="active-menu"><i class="fa fa-edit"></i> Admin Portal </a>
                    </li>
                     <li>
                        <a href="ShopLogin.aspx" ><i class="fa fa-desktop"></i> Shop Portal </a>
                    </li>
                </ul>
            </div>

        </nav>
        <div id="page-wrapper" >
            <div id="page-inner">
			 <div class="row">
                    <div class="col-md-12">
                        <h1 class="page-header">
                           Add / Modify / Delete User
                        </h1>
                    </div>
                 <div class="form-group">
                                            <asp:Label ID="Label1" runat="server" style="color:green; font-weight:bold"  Text=""></asp:Label>
                  </div>
                  <div class="row">
                <div class="col-lg-12">
                    <div class="panel panel-default">
                        <div class="panel-body">
                            <div class="row">
                                <div class="col-lg-6">
                                    <form role="form" runat="server">
                                        <div class="form-group">
                                            <label>Enter Username</label>
                                            <asp:TextBox ID="TextBox1" runat="server" class="form-control" placeholder="e.g Ahmed123"></asp:TextBox>
                                        </div>
                                         <div class="form-group">
                                            <label>Enter Email</label>
                                            <asp:TextBox ID="TextBox5" runat="server"  class="form-control" placeholder="e.g example@gmail.com"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <label>Enter Password</label>
                                            <asp:TextBox ID="TextBox3" runat="server" class="form-control" placeholder="Password"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <label>Gender</label>
                                            <asp:DropDownList ID="DropDownList1" runat="server">
                                                <asp:ListItem>Male</asp:ListItem>
                                                <asp:ListItem>Female</asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        <asp:Button ID="Button1" runat="server" class="btn btn-default" Text="Add" OnClick="Button1_Click" />
                                        <asp:Button ID="Button2" runat="server" class="btn btn-default" Text="Modify" OnClick="Button2_Click"/>
                                        <asp:Button ID="Button3" runat="server" class="btn btn-default" Text="Delete" OnClick="Button3_Click" />
                                    </form>
                                </div>
                                <!-- /.col-lg-6 (nested) -->
                            </div>
                            <!-- /.row (nested) -->
                        </div>
                        <!-- /.panel-body -->
                    </div>
                    <!-- /.panel -->
                </div>
                <!-- /.col-lg-12 -->
            </div>
			</div>
             <!-- /. PAGE INNER  -->
            </div>
        </div>
         <!-- /. PAGE WRAPPER  -->
        </div>
     <!-- /. WRAPPER  -->
    <!-- JS Scripts-->
    <!-- jQuery Js -->
    <script src="assets/js/jquery-1.10.2.js"></script>
      <!-- Bootstrap Js -->
    <script src="assets/js/bootstrap.min.js"></script>
    <!-- Metis Menu Js -->
    <script src="assets/js/jquery.metisMenu.js"></script>
      <!-- Custom Js -->
    <script src="assets/js/custom-scripts.js"></script>
    
   
</body>
</html>

