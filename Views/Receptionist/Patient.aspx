<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Receptionist/ReceptionistMaster.Master" AutoEventWireup="true" CodeBehind="Patient.aspx.cs" Inherits="ClinicalManagement.Views.Receptionist.Patient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
    <div class="container-fluid">
        <div class="row" style="height:50px"></div>
        <div class="row">
            <div class="col-md-3">
                <h2>Patient Details</h2>
                <form>
  <div class="mb-3">
    <label for="PatNameTb" class="form-label">Name</label>
    <input type="text" class="form-control" id="PatNameTb" runat ="server" required="required"/>
  </div>
  <div class="mb-3">
    <label for="PhoneTb" class="form-label">Phone</label>
    <input type="tel" class="form-control" id="PhoneTb"  runat ="server" required="required" causesvalidation="True" maxlength="10" />
  </div>
  <div class="mb-3">
    <label for="GenderCb" class="form-label">Gender</label>
    <asp:DropDownList ID="GenderCb" runat="server" class="form-control" required="required">
          <asp:ListItem>Male</asp:ListItem>
          <asp:ListItem>Female</asp:ListItem>
      </asp:DropDownList>
  </div>
  <div class="mb-3">
    <label for="DOBTb" class="form-label">DOB</label>
    <input type="date" class="form-control" id="DOBTb" runat ="server" required="required"/>
  </div>
  <div class="mb-3">
    <label for="AddTb" class="form-label">AddBy</label>
     <asp:DropDownList ID="AddCb" runat="server" class="form-control" required="required">
      </asp:DropDownList>
</div>
     <div class="mb-3">
    <label for="AddressTb" class="form-label">Address</label>
    <input type="text" class="form-control" id="AddressTb" runat ="server" required="required"/>
  </div>
  
  <div class="mb-3">
    <label for="AllergyTb" class="form-label">Allergies</label>
    <input type="text" class="form-control" id="AllergyTb" runat ="server" required="required"/>
  </div>
  
   <label runat="server" id="ErrMsg" class="text-danger"> </label> <br />
  <asp:Button ID="EditBtn" runat="server" Text="Edit" class="btn btn-warning" OnClick="EditBtn_Click"   />
  <asp:Button ID="AddBtn" runat="server" Text="Save" class="btn btn-primary" OnClick="AddBtn_Click"   />
  <asp:Button ID="DeleteBtn" runat="server" Text="Delete" class="btn btn-danger" OnClick="DeleteBtn_Click"   />
</form>

            </div>
            <div class ="col-md-9">
                
                <div class ="row">
                    <div class="col">
                        <h1>Patients List</h1>
                        <asp:GridView ID="PatientGV" Class ="table table-hover" runat="server" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="PatientGV_SelectedIndexChanged"   >
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
