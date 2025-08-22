<%@ Page Title="E-Mail Settings" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmailSettings.aspx.cs" Inherits="ProjectFrameworkWeb.Admin.EmailSettings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <div class="panel panel-primary">
      <div class="panel-heading"><h4>Configure E-Mail Server Settings</h4></div>
      <div class="panel-body">

          <div class="form-group">
            <label for="TextBoxSmtpServer">SMTP Server</label>
                <asp:TextBox ID="TextBoxSmtpServer" class="form-control"  style="min-width: 100%;" runat="server" Width="80%"></asp:TextBox>
          </div>
          <div class="form-group">
            <label for="TextBoxSmtpPort">SMTP Port</label>
                <asp:TextBox ID="TextBoxSmtpPort" class="form-control" style="min-width: 100%;" runat="server" Width="80%"></asp:TextBox>
          </div>
          <div class="form-group">
            <label for="TextBoxEmail">E-Mail Address</label>
                <asp:TextBox ID="TextBoxEmail" class="form-control" style="min-width: 100%;" runat="server" TextMode="Email" Width="80%"></asp:TextBox>
          </div>
          <div class="form-group">
            <label for="TextBoxPassword">Password</label>
                <asp:TextBox ID="TextBoxPassword" class="form-control" style="min-width: 100%;" runat="server" TextMode="Password" Width="80%"></asp:TextBox>
          </div>
          <div class="form-group">
              <asp:CheckBox ID="CheckEnableSSL" runat="server" Text="Enable SSL" />
          </div>
          <div class="form-group">
              <asp:Button ID="ButtonUpdate" runat="server" Text="Update" class="btn btn-primary" OnClick="ButtonUpdate_Click" />
          </div>
          <div class="form-group">
              <asp:Label ID="LabelStatus" runat="server" Text="" ForeColor="Red" Font-Bold="true"></asp:Label>
          </div>
      </div>
    </div>
</asp:Content>