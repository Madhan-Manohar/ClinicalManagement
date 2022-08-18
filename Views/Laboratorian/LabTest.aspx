<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Laboratorian/LaboratorianMaster.Master" AutoEventWireup="true" CodeBehind="LabTest.aspx.cs" Inherits="ClinicalManagement.Views.Laboratorian.LabTest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
     <div class="container-fluid">
         <div class="row" style="height:50px"></div>
        <div class="row">
            <div class="col-md-4">
                <h2>Laboratory Test Details</h2>
                <form>
  <div class="mb-3">
    <label for="LabNameTb" class="form-label">Name</label>
    <input type="text" class="form-control" id="LabNameTb" runat ="server" required="required"/>
  </div>
  <div class="mb-3">
    <label for="TestCostTb" class="form-label">Test Cost</label>
    <input type="text" class="form-control" id="TestCostTb"  runat ="server" required="required"/>
  </div>
  <div class="mb-3">
    <label for="AddTb" class="form-label">AddBy</label>
     <asp:DropDownList ID="AddCb" runat="server" class="form-control" required="required">
      </asp:DropDownList>
</div>
  <div class="row" style="height:150px"></div>
 
   <label runat="server" id="ErrMsg" class="text-danger"> </label> <br />
  <asp:Button ID="EditBtn" runat="server" Text=" Edit " class="btn btn-warning" OnClick="EditBtn_Click"    />
  <asp:Button ID="AddBtn" runat="server" Text=" Save " class="btn btn-primary" OnClick="AddBtn_Click"     />
  <asp:Button ID="DeleteBtn" runat="server" Text=" Delete " class="btn btn-danger" OnClick="DeleteBtn_Click"  />
</form>

            </div>
            <div class ="col-md-8">
                <div class="row">
                    <div class="col">
                        <img src="../../Assets/Images/l1.png" height ="200px" width ="100%" class="rounded-3" />
                    </div>
                </div>
                <div class ="row">
                    <div class="col">
                        <h1>Laboratory Test Details</h1>
                        <asp:GridView ID="LabTestGV" Class ="table table-hover" runat="server" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="LabTestGV_SelectedIndexChanged"  >
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
