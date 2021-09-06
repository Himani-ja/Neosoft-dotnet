<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="Web.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
            <h1>Customer Page</h1>
        </div>
    <div>
        <form>
          <div class="form-group row">
              <asp:Label for="txt_Name" ID="lbl_Name" runat="server" Text="Name" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="txt_Name" runat="server" class="form-control" placeholder="Please enter the name of the Customer"></asp:TextBox>
            </div>
          </div>
          <div class="form-group row">
              <asp:Label for="txt_email" ID="lbl_email" runat="server" Text="Email" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="txt_email" runat="server" class="form-control" placeholder="abc@gamil.com"></asp:TextBox>
            </div>
          </div>
             <div class="form-group row">
              <asp:Label for="txt_zipcode" ID="lbl_zipcode" runat="server" Text="Zipcode" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="txt_zipcode" runat="server" class="form-control" placeholder="Please enter the zipcode"></asp:TextBox>
            </div>
          </div>
          <div class="form-group row">
              <asp:Label for="txt_username" ID="lbl_username" runat="server" Text="Username" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="txt_username" runat="server" class="form-control" placeholder="please enter username"></asp:TextBox>
            </div>
          </div>
            <div class="form-group row">
              <asp:Label for="txt_username" ID="lbl_password" runat="server" Text="Password" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="txt_password" runat="server" class="form-control" placeholder="please enter password"></asp:TextBox>
            </div>
          </div>
          <div class="form-group row">
            <div class="col-sm-10 offset-sm-2">
                <asp:Button ID="btn_submit" class="btn btn-primary" runat="server" Text="Submit" OnClick="btn_submit_Click"/>
            </div>    
          </div>
           
    </form>
    </div>

</asp:Content>
