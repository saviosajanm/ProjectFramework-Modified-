<%@ Page Title="Mobile Device Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeviceDetails.aspx.cs" Inherits="ProjectFrameworkWeb.Admin.DeviceDetails" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <p>The following details were last sent from the mobile application.</p>
    <div class="panel panel-info">
        <div class="panel-heading"><h4>Received Device Information</h4></div>
        <div class="panel-body">
            <ul class="list-group">
                <li class="list-group-item"><strong>Processor Count:</strong> <asp:Label ID="LabelProcessorCount" runat="server"></asp:Label></li>
                <li class="list-group-item"><strong>Total Memory:</strong> <asp:Label ID="LabelTotalMemory" runat="server"></asp:Label></li>
                <li class="list-group-item"><strong>Memory Left:</strong> <asp:Label ID="LabelMemoryLeft" runat="server"></asp:Label></li>
                <li class="list-group-item"><strong>Total Space:</strong> <asp:Label ID="LabelTotalSpace" runat="server"></asp:Label></li>
                <li class="list-group-item"><strong>Space Left:</strong> <asp:Label ID="LabelSpaceLeft" runat="server"></asp:Label></li>
            </ul>
        </div>
    </div>
</asp:Content>