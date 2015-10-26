<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <div class="container" role="main">
        <div class="jumbotron">
            <div class="container">
            <h1><%: Title %>.</h1>
            <h2>Your app description page.</h2>
                </div>
        </div>
    </div>
</asp:Content>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
        <div class="row">
            <div class="col-md-4">
                <div class="panel panel-default">
                    <div class="panel-heading">Topic</div>
                    <div class="panel-body">Use this area to provide additional information.</div>
                </div>
            </div>

           <div class="col-md-4">
                <div class="panel panel-default">
                    <div class="panel-heading">Topic</div>
                    <div class="panel-body">Use this area to provide additional information.</div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="panel panel-default">
                    <div class="panel-heading">Topic</div>
                    <div class="panel-body">Use this area to provide additional information.</div>
                </div>
            </div>



        <aside>
            <h3>Aside Title</h3>
            <p>
                Use this area to provide additional information.
            </p>
            <ul>
                <li><a runat="server" href="~/">Home</a></li>
                <li><a runat="server" href="~/About">About</a></li>
                <li><a runat="server" href="~/Contact">Contact</a></li>
            </ul>
        </aside>
    </div>
</asp:Content>
