<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="presentation.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server" >
  
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div style=" height: 318px; background-color: #FFFFFF; width: 414px; margin-left: 1072px; margin-right: 599px; margin-top: 516px; font-family: 'Arial Black'; font-size: large;">
           <p style="font-family: 'Arial Black'; font-size: large">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </p>
        <p style="text-align:center">
            &nbsp;Sign in
            </p>
        <p style="text-align:center">
            Customer Id <asp:TextBox ID="customerid" runat="server"></asp:TextBox><br />
            Password&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
        </p>
        <p style="text-align:center">
            <asp:Button ID="Button1" runat="server" Text="Submit" BorderStyle="Ridge" Font-Names="Arial Black" OnClick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
           <p style="text-align:center">
               &nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
        <p style="text-align:center">
            New User? Register&nbsp;
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/customer.aspx">Here</asp:HyperLink>
        </p>
          </div>
</asp:Content>
