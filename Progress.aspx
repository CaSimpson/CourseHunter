
<%@ Page Title="Progress" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeFile="Progress.aspx.cs" Inherits="Progress" %>





<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent"> 

    <form runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                
                <h2>Student Progress Page</h2>
            </hgroup>
            <p>
                <asp:Label ID="lblComplete" runat="server" Text="Courses Complete"></asp:Label>
                &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                <asp:Label ID="lblProgressBar" runat="server" Text="Current Progress"></asp:Label>
            </p>
            <p>
                                <asp:ListBox ID="completeListBox" runat="server"></asp:ListBox>
                <link rel="stylesheet" href="//code.jquery.com/ui/1.11.4/themes/smoothness/jquery-ui.css">
                <script src="//code.jquery.com/jquery-1.10.2.js"></script>
                <script src="//code.jquery.com/ui/1.11.4/jquery-ui.js"></script>
                
                  <div id="progressbar"></div>   
                 
                  
                <script type="text/jscript">
                    var myProg;
                    myProg = <%=myProg%>;
                    jQuery(document).ready(function () {
                        jQuery("#progressbar").progressbar({ value: myProg });
                    });
</script>      
           

            </p>
        </div>
    </section>
    </form>

    </asp:Content>