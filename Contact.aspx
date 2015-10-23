<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="FeaturedContent">
    <div class="container" role="main">
        <div class="container">
            <div class="jumbotron">
                <h1><%: Title %>.</h1>
                <h2>Your contact page.</h2>
            </div>
        </div>
    </div>
</asp:Content>

<asp:Content runat="server" ID="contact" ContentPlaceHolderID="MainContent">
    <div class="container">
        <header>
            <h3>Phone:</h3>
        </header>
        <p>
            <span class="label">Main:</span>
            <span>425.555.0100</span>
        </p>
        <p>
            <span class="label">Game if your bored</span>
            <span>A spelling/animal identification game!</span>


            <object width="550" height="500">
                <param name="movie" value="hiddenpicture2.swf">
                <embed src="hiddenpicture2.swf" width="550" height="500">
                </embed>
            </object
        </p>
        <section class="contact">
            <header>
                <h3>Email:</h3>
            </header>
            <p>
                <span class="label">Support:</span>
                <span><a href="mailto:Support@example.com">Support@example.com</a></span>
            </p>
            <p>
                <span class="label">Marketing:</span>
                <span><a href="mailto:Marketing@example.com">Marketing@example.com</a></span>
            </p>
            <p>
                <span class="label">General:</span>
                <span><a href="mailto:General@example.com">General@example.com</a></span>
            </p>
        </section>

        <section class="contact">
            <header>
                <h3>Address:</h3>
            </header>
            <p>
                One Microsoft Way<br />
                Redmond, WA 98052-6399
            </p>
        </section>
    </div>
</asp:Content>
