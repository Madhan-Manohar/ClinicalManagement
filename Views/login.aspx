<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ClinicalManagement.Views.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel ="stylesheet" href ="../Libs/Bootstrap/css/bootstrap.min.css" />
    <link rel="stylesheet" href ="../CSS/Login.css"/>
</head>
<body style="background-image:url(../Assets/Images/login1.jpg);background-size:cover">

     <div class ="container-fluid">
        <div class="row" style ="height:120px"></div>
        <div class ="row">
            <div class="col-md-4"></div>
            <div class="col-md-5">
                <h1 class="T pl-2">ABC General Clinic</h1>
                <form id="form1" runat="server">
  <div class="mb-3">
    <label for="EmailTb" class="form-label">Email address</label>
    <input type="email" class="form-control" id="EmailTb" runat ="server" required="required">
   
  </div>
  <div class="mb-3">
    <label for="PasswordTb" class="form-label">Password</label>
    <input type="password" class="form-control" id="PasswordTb" runat ="server" required ="required">
  </div>
  <div class="mb-3 form-check">
    
    <asp:DropDownList ID="RoleCb" runat="server" class="form-control" required ="required">
          <asp:ListItem>--Select Role--</asp:ListItem>
          <asp:ListItem>Admin</asp:ListItem> 
          <asp:ListItem>Doctor</asp:ListItem>
          <asp:ListItem>Receptionist</asp:ListItem>
          <asp:ListItem>Laboratorian</asp:ListItem>
      </asp:DropDownList>
       
  </div>
<div class="d-grid">
     <label runat="server" id="ErrMsg" class="text-danger"> </label> <br />
  <asp:Button ID="EditBtn" runat="server" Text="Login" class="btn btn-primary btn-block" OnClick="EditBtn_Click"  />
   
</div>
  
</form>
                <div class="row" style="height:10px"></div>

            </div>
            <div class="col-md-3"></div>
        </div>
    </div>
    
    

    
</body>
</html>