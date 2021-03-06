﻿<%@ Page Title="Account" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeFile="Account.aspx.cs" Inherits="Account" %>



<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent"> 

    <form runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                
                <h2>User Account Page : Click a button to manage account</h2>
            </hgroup>
            <p>
                <asp:Button ID="btnAddCourse" runat="server" Text="Add / Remove Courses" OnClick="btnAddCourse_Click" />
                <asp:Button ID="btnStatus" runat="server" Text="Status / Progress page" OnClick="btnStatus_Click" />
                <asp:Button ID="btnShowRecommended" runat="server" Text="Recommended / Possible courses" OnClick="btnShowRecommended_Click" />
            </p>
        </div>
    </section>
    </form>

    </asp:Content>