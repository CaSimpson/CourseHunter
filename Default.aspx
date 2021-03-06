﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <div class="container" role="main">
        <div class="content-wrapper">
            <div class="jumbotron">
                <h1><%: Title %></h1>
                <h2>Welcome to CourseHunter, please log in or register to begin!</h2>
            </div>
        </div>
    </div>
</asp:Content>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="container">
        <div class="list-group">
            <div class="list-group-item-heading">
            <h3>We suggest the following:</h3>
                </div>
            <div class="list-group-item">
                <h2 class="list-group-item-heading">Getting Started</h2>
                <p class = "list-group-item-text">ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            <a href="http://go.microsoft.com/fwlink/?LinkId=245146">Learn more…</a>
                    </p>
            </div>
            <div class="list-group-item">
                <h5>Add NuGet packages and jump-start your coding</h5>
                NuGet makes it easy to install and update free libraries and tools.
            <a href="http://go.microsoft.com/fwlink/?LinkId=245147">Learn more…</a>
            </div>
            <div class="list-group-item">
                <h5>Find Web Hosting</h5>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            <a href="http://go.microsoft.com/fwlink/?LinkId=245143">Learn more…</a>
            </div>
        </div>
    </div>
</asp:Content>
