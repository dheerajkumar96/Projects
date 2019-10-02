<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="customer.aspx.cs" Inherits="presentation.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 397px;
        }
        .auto-style3 {
            height: 37px;
            width: 397px;
        }
        .auto-style7 {
            height: 26px;
            width: 397px;
        }
        .auto-style8 {
            width: 397px;
            height: 31px;
        }
        .auto-style10 {
            width: 397px;
            height: 33px;
        }
        .auto-style12 {
            height: 32px;
            width: 397px;
        }
        .auto-style13 {
        width: 451px;
    }
        .auto-style14 {
        height: 37px;
        width: 451px;
    }
        .auto-style15 {
        width: 451px;
        height: 33px;
    }
        .auto-style16 {
            width: 451px;
            height: 31px;
        }
        .auto-style17 {
            height: 32px;
            width: 451px;
        }
        .auto-style18 {
        height: 26px;
        width: 451px;
    }
        .auto-style19 {
            width: 397px;
            height: 34px;
        }
        .auto-style20 {
            width: 451px;
            height: 34px;
        }
    </style>
    <script src="Scripts/customervalidation.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="background-color:wheat; text-align:center">Customer Registration</h1>
    <table style="width: 49%; height: 500px; margin-left: 459px; font-family:'Arial Black'; font-size:large; background-color:white; text-align:center">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style13">
                &nbsp;</td>
            
        </tr>
        <tr>
            <td class="auto-style19">Name</td>
            <td class="auto-style20">
                <asp:TextBox ID="name" runat="server" ClientIDMode="Static" ></asp:TextBox>
            </td>
            
        </tr>
        <tr>
            <td class="auto-style10">Email</td>
            <td class="auto-style15">
                <asp:TextBox ID="email" runat="server" ClientIDMode="Static"></asp:TextBox>
            </td>
            
        </tr>
        <tr>
            <td class="auto-style3"> Password</td>
            <td class="auto-style14"> 
                <asp:TextBox ID="password" runat="server" ClientIDMode="Static"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8"> Date Of Birth</td>
            <td class="auto-style16"> 
                <asp:TextBox ID="dob" runat="server" TextMode="Date" Width="155px" ClientIDMode="Static"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style10"> Address</td>
            <td class="auto-style15"> 
                <asp:TextBox ID="address" runat="server" ClientIDMode="Static"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style10"> Phone Number </td>
            <td class="auto-style15"> 
                <asp:TextBox ID="phone" runat="server" TextMode="Number" ClientIDMode="Static"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style12"> Gender</td>
            <td class="auto-style17"> 
                <asp:DropDownList ID="gender" runat="server" style="margin-left: 0px" Width="146px" ClientIDMode="Static">
                    <asp:ListItem>select</asp:ListItem>
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style10"> SSN Type</td>
            <td class="auto-style15"> 
                <asp:TextBox ID="ssntype" runat="server" ClientIDMode="Static"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7"> SSN Number</td>
            <td class="auto-style18"> 
                <asp:TextBox ID="ssnnumber" runat="server" ClientIDMode="Static"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7"> &nbsp;</td>
            <td class="auto-style18"> &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7"> 
                <asp:Button ID="Button1" runat="server" Text="Register" BorderStyle="Ridge" Font-Names="Arial Black" OnClick="Button1_Click"   OnClientClick="return validate();"/>
            </td>
            <td class="auto-style18"> 
                <asp:Button ID="Button2" runat="server" Text="Reset" BorderStyle="Ridge" Font-Names="Arial Black" OnClick="Button2_Click"  />
            </td>
        </tr>
        <tr>
            <td class="auto-style2"> 
                <asp:Label ID="Label1" runat="server"></asp:Label>
            &nbsp;<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/LoginPage.aspx">[HyperLink1]</asp:HyperLink>
            </td>
            <td class="auto-style13"> </td>
        </tr>
    </table>
    
</asp:Content>
