<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Booking.aspx.cs" Inherits="presentation.Booking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style2 {
        width: 492px;
    }
        .auto-style5 {
            width: 382px;
        }
        .auto-style6 {
            width: 492px;
            height: 26px;
        }
        .auto-style7 {
            width: 382px;
            height: 26px;
        }
        .auto-style8 {
            width: 492px;
            height: 23px;
        }
        .auto-style9 {
            width: 382px;
            height: 23px;
        }
        .auto-style10 {
            width: 492px;
            height: 30px;
        }
        .auto-style11 {
            width: 382px;
            height: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 530px; margin-left: 379px; background-color: #FFFFFF; font-family: 'Arial Black'; font-size: large; width: 601px;">
    <table style="width: 99%; color: #000000; font-weight: bold; text-align:center; font-family: 'Arial Black'; font-size: large; background-color: #FFFFFF;">
        <tr>
            <td>

                Customer Id</td>
            <td>

                <asp:TextBox ID="customerid1" runat="server"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td>

                Booking Id</td>
            <td>

                <asp:TextBox ID="bookingid1" runat="server"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td class="auto-style8">Name</td>
            <td class="auto-style9">
                <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">FlightNo</td>
            <td class="auto-style7">
                <asp:TextBox ID="txtFlightno" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">AirLines Name</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtAirlinesname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Location From</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtLocationfrom" runat="server"></asp:TextBox>
            </td>
            </tr>
        <tr>
            <td class="auto-style10">Location To</td>
            <td class="auto-style11">
                <asp:TextBox ID="txtLocationto" runat="server"></asp:TextBox>
            </td>
        </tr>
            <tr>
                <td class="auto-style2">Date of Journey</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtDoj" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Departure Time</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtDeparturetime" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">No_of Pasengers</td>
            <td class="auto-style11">
                <asp:DropDownList ID="ddlNoofpassengers" runat="server" OnSelectedIndexChanged="ddlNoofpassengers_SelectedIndexChanged" AutoPostBack="True" >
                    <asp:ListItem>select</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                </asp:DropDownList>
                </td>
        </tr>
        <tr>
            <td class="auto-style2">Booking Date</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtBookingdate" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Total price</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtTotalprice" runat="server" OnDataBinding="ddlNoofpassengers_SelectedIndexChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5">
                &nbsp;</td>
        </tr>
        </table>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="submit" Height="37px" Width="80px" OnClick="Button1_Click" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="bookmessage" runat="server"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>

</asp:Content>
