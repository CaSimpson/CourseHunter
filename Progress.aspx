﻿
<%@ Page Title="Progress" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeFile="Progress.aspx.cs" Inherits="Progress" %>




<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent"> 

    <br />
    <br />
    <br />
    <br />
    <br />


    <form runat="server">
    <section class="featured">
        <div class="content-wrapper">
            
               
                <h1 style="margin-left:auto; margin-right:auto; text-align: center;">
                    <asp:Label ID="lblStudentName" runat="server" Text=""></asp:Label></h1>
            <br />    

                <h2 style="margin-left:auto; margin-right:auto; text-align: center;">Overall Progress</h2>
                
                    <link rel="stylesheet" href="//code.jquery.com/ui/1.11.4/themes/smoothness/jquery-ui.css">
                    <script src="//code.jquery.com/jquery-1.10.2.js"></script>
                    <script src="//code.jquery.com/ui/1.11.4/jquery-ui.js"></script>
                
                     <div id="progressbar" style="width:75%; margin:0 auto;"></div>   
                 
                  
                      <script type="text/jscript">
                         var myProg;
                         myProg = <%=myProg%>;
                          jQuery(document).ready(function () {
                              jQuery("#progressbar").progressbar({ value: myProg }).append("<div class='caption'>20%</div>");
                              jQuery("#progressbar").css({ 'background': 'url(images/white-40x100.png) #ffffff repeat-x 50% 50%;' });
                              jQuery("#pbar1 > div").css({ 'background': 'url(images/lime-1x100.png) #cccccc repeat-x 50% 50%;' });
                          });
                        </script>     
                        
           
            
            
            <br />
            <br />

            <h3 style="margin-left:auto; margin-right:auto; text-align: center;">
                Courses Complete
                
            </h3>
            <p style="margin-left:auto; margin-right:auto; text-align: center;">
                                <asp:ListBox ID="completeListBox" runat="server"></asp:ListBox>
                
           

            </p>
        </div>
    </section>
    </form>

    </asp:Content>