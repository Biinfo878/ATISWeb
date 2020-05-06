<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web.Mobile.ATIS._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-4">
            <h2>ATIS Mobile</h2>
            <p>
                <asp:Button ID="Button1" runat="server" Text="دانلود" Font-Names="B Homa" Font-Size="Small" OnClick="Button1_Click" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>ATIS Desktop</h2>
            <p>
                <asp:Button ID="Button2" runat="server" Text="دانلود" Font-Names="B Homa" Font-Size="Small" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>ATIS Web</h2>
            <p>
            </p>
        </div>
    </div>

</asp:Content>
