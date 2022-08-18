<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Receptionist.aspx.cs" Inherits="ClinicalManagement.Views.Admin.Receptionist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
     <div class="container-fluid">
        <div class ="row">
            <div class="col-md-4">
                <h2>Receptionist Detail</h2>
                 <form>
  <div class="mb-3">
    <label for="RecNameTb" class="form-label">Name</label>
    <input type="text" class="form-control" id="RecNameTb" runat ="server" required="required"/>
  </div>
  <div class="mb-3">
    <label for="RecEmailTb" class="form-label">Email</label>
    <input type="text" class="form-control" id="RecEmailTb" runat ="server" required="required"/>
  </div>
  <div class="mb-3">
    <label for="AddressTb" class="form-label">Address</label>
    <input type="text" class="form-control" id="AddressTb" runat ="server" required="required"/>
  </div>
  <div class="mb-3">
    <label for="PhoneTb" class="form-label">Phone</label>
    <input type="text" class="form-control" id="PhoneTb" runat ="server" required="required"/>
  </div>
  <div class="mb-3">
    <label for="PasswordTb" class="form-label">Password</label>
    <input type="password" class="form-control" id="PasswordTb" runat ="server" required="required" min="3"/>
  </div>
 <label runat="server" id="ErrMsg" class="text-danger"> </label> <br />
  <asp:Button ID="EditBtn" runat="server" Text="Edit" class="btn btn-warning" OnClick="EditBtn_Click"  />
  <asp:Button ID="AddBtn" runat="server" Text="Save" class="btn btn-primary" OnClick="AddBtn_Click1"  />
  <asp:Button ID="DeleteBtn" runat="server" Text="Delete" class="btn btn-danger" OnClick="DeleteBtn_Click"  />
  
</form>
            </div>
             <div class="col-md-8">
                 <div class ="row">
                     <div class="col">
                         <img src="../../Assets/Images/rec.jpg" height ="200px" width="100%" class="rounded-3"/>
                     </div>

                 </div>
                 <div class="row">
                      <div class="col">
                         <h1>Receptionist Details</h1>
                          <asp:GridView ID="ReceptionistGV" Class="table table-hover" runat="server" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="ReceptionistGV_SelectedIndexChanged">
                              <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                              <EditRowStyle BackColor="#999999" />
                              <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                              <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                              <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                              <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                              <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                              <SortedAscendingCellStyle BackColor="#E9E7E2" />
                              <SortedAscendingHeaderStyle BackColor="#506C8C" />
                              <SortedDescendingCellStyle BackColor="#FFFDF8" />
                              <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                          </asp:GridView>
                     </div>
                 </div>

            </div>

        </div>

    </div>
</asp:Content>
