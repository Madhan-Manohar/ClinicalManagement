<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Doctors/DoctorMaster.Master" AutoEventWireup="true" CodeBehind="Prescription.aspx.cs" Inherits="ClinicalManagement.Views.Doctors.Prescription" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
     <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <h2>Prescription Details</h2>
                <br /><br /><br />
                <form>
  <div class="mb-3">
    <label for="PatientCb" class="form-label">Patient</label>
    <asp:DropDownList ID="PatientCb" runat="server" class="form-control" required="required"  >
      </asp:DropDownList>
  </div>
  <div class="mb-3">
    <label for="MedicineTb" class="form-label">Medicines</label>
    <input type="text" class="form-control" id="MedicineTb"  runat ="server" required="required"/>
  </div>
  <div class="mb-3">
    <label for="TestTb" class="form-label">LabTest</label>
     <asp:DropDownList ID="TestCb" runat="server" class="form-control">
      </asp:DropDownList>
  </div>
     <div class="mb-3">
    <label for="CostTb" class="form-label">Cost</label>
    <input type="text" class="form-control" id="CostTb" runat ="server" required="required"/>
  </div>
  <div class="mb-3">
    <label for="AddTb" class="form-label">AddBy</label>
     <asp:DropDownList ID="AddCb" runat="server" class="form-control" required="required">
      </asp:DropDownList>
  </div>
  <div class="d-grid">
      <label runat="server" id="ErrMsg" class="text-danger"> </label> <br />
  
  <asp:Button ID="Button2" runat="server" Text="Save Prescription" class="btn btn-warning btn-l=block text-white" OnClick="Button2_Click"  />
  

  </div>
 
 
   
</form>

            </div>
            <div class ="col-md-8">
                <div class="row">
                    <div class="col">
                        <img src="../../Assets/Images/pre.jpg" height ="200px" width ="100%" class="rounded-3" />
                    </div>
                </div>
                <div class ="row">
                    <div class="col">
                        <h1>Prescription Details</h1>
                        <asp:GridView ID="PrescriptionGV" Class ="table table-hover" runat="server" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="PrescriptionGV_SelectedIndexChanged" >
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