<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Cancelticket.aspx.cs" Inherits="presentation.Cancelticket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="background-color:wheat; font-family:Arial;font-size:large;text-align:center">Cancel Ticket</h1>
    <div style="font-family: 'Arial Black'; font-size: large; background-color: #FFFFFF; height: 389px; width: 1111px; margin-left: 202px; margin-top: 25px;">
        
        <p style="margin-left: 280px">
            Enter the booking id
            <asp:TextBox ID="txtbookid" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Enter" />
&nbsp;<asp:Label ID="Label1" runat="server"></asp:Label>
        &nbsp;&nbsp;&nbsp;
            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" Height="16px" Width="319px" style="margin-left: 315px; margin-top: 0px">
                <Fields>
                    <asp:BoundField DataField="bookingid" HeaderText="Bookingid" />
                    <asp:BoundField DataField="bookingdate" HeaderText="BookingDate" />
                    <asp:BoundField DataField="journeydate" HeaderText="JourneyDate" />
                    <asp:BoundField DataField="from" HeaderText="From" />
                    <asp:BoundField DataField="to" HeaderText="To" />
                    <asp:BoundField DataField="totalfare" HeaderText="Total Fare" />
                    <asp:BoundField DataField="cancellationcharge" HeaderText="Cancellation Charge" />
                    <asp:BoundField DataField="refundamount" HeaderText="Refund Amount" />
                </Fields>
            </asp:DetailsView>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="cancel" OnClick="Button1_Click" OnClientClick="openPopupWindow();return false;" />
        </p>
        <p style="margin-left: 280px">
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </p>
        
    </div>
    </asp:Content>
