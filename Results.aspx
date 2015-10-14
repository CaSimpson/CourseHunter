<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeFile="Results.aspx.cs" Inherits="Results" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %></h1>
                <h2>Select all completed courses and hit submit.</h2>
            </hgroup>
            <p>
                
                </a>
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="appBody" ContentPlaceHolderID="MainContent">
    <p><asp:Label ID="allPosLabel" runat="server" Text="Label">All Courses Available</asp:Label>
        <asp:Label ID="recLabel" runat="server" Text="Label">Recommended Courses</asp:Label>
    </p>
    <p>
        
        <asp:ListBox ID="allPosListBox" runat="server"></asp:ListBox>


        <asp:Label ID="rec1" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="rec2" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="rec3" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="rec4" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="rec5" runat="server" Text="Label"></asp:Label>
    </p>




    </asp:Content>