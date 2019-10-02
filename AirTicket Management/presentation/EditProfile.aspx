<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EditProfile.aspx.cs" Inherits="presentation.EditProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style2 {
            width: 397px;
        }
        .auto-style13 {
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
        .auto-style10 {
            width: 397px;
            height: 33px;
        }
        .auto-style15 {
        width: 451px;
        height: 33px;
    }
        .auto-style8 {
            width: 397px;
            height: 31px;
        }
        .auto-style16 {
            width: 451px;
            height: 31px;
        }
        .auto-style12 {
            height: 32px;
            width: 397px;
        }
        .auto-style17 {
            height: 32px;
            width: 451px;
        }
        .auto-style7 {
            height: 26px;
            width: 397px;
        }
        .auto-style18 {
        height: 26px;
        width: 451px;
    }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 1104px">
    <table style="width: 49%; height: 500px; margin-left: 459px; font-family:'Arial Black'; font-size:large; background-color:white;text-align:center">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">CustId</td>
            <td class="auto-style13">
                <asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style19">Name</td>
            <td class="auto-style20">
                <asp:TextBox ID="name1" runat="server" ClientIDMode="Static" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">Email</td>
            <td class="auto-style15">
                <asp:TextBox ID="email1" runat="server" ClientIDMode="Static"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">Date Of Birth</td>
            <td class="auto-style16">
                <asp:TextBox ID="dob1" runat="server" TextMode="Date" Width="155px" ClientIDMode="Static"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">Address</td>
            <td class="auto-style15">
                <asp:TextBox ID="address1" runat="server" ClientIDMode="Static"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">Phone Number </td>
            <td class="auto-style15">
                <asp:TextBox ID="phone1" runat="server" TextMode="Number" ClientIDMode="Static"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style12">Gender</td>
            <td class="auto-style17">
                <asp:DropDownList ID="gender1" runat="server" style="margin-left: 0px" Width="146px" ClientIDMode="Static">
                    <asp:ListItem>select</asp:ListItem>
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">SSN Type</td>
            <td class="auto-style15">
                <asp:TextBox ID="ssntype1" runat="server" ClientIDMode="Static" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">SSN Number</td>
            <td class="auto-style18">
                <asp:TextBox ID="ssnnumber1" runat="server" ClientIDMode="Static" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnEdit" runat="server" Text="Update" BorderStyle="Ridge" Font-Names="Arial Black" OnClick="btnEdit_Click" style="height: 28px"/>
            </td>
            <td class="auto-style18">
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label1" runat="server"></asp:Label>
            &nbsp;<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebForm1.aspx"></asp:HyperLink>
            </td>
            <td class="auto-style13">&nbsp;&nbsp;</td>
        </tr>
    </table>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
</asp:Content>
