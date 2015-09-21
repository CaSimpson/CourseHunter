<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UIClassPicker.aspx.cs" Inherits="UIClassPicker" MasterPageFile="~/Site.Master"%>


<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>Modify this template to jump-start your ASP.NET application.</h2>
            </hgroup>
            
          



        </div>



    </section>
</asp:Content>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <asp:Label ID="lblComm" runat="server" Text="I. Communication"></asp:Label>
      <asp:Panel ID="Panel1" runat="server" CssClass="coursePanel" HorizontalAlign="NotSet" BackColor="#666666">
          
          <table style="width: 100%;">
              <tr>
                  <td class="auto-style4" style="padding: 10px; border: medium solid #333333; background-color: #CCCCCC;">
                      <asp:Label ID="Label1" runat="server" Text="lblComm">I: Communication</asp:Label>
                      <asp:CheckBoxList ID="chkListComm" runat="server" CellPadding="1" CellSpacing="1" >
                   
                         <asp:ListItem Value="ENG101">ENG-101</asp:ListItem>
                         <asp:ListItem Value="ENG102">ENG-102</asp:ListItem>
                         <asp:ListItem Value="SPH201">SPH-201</asp:ListItem>
                        
                     </asp:CheckBoxList>
                      
                  </td>
                  <td class="auto-style4" style="padding: 10px; border: medium solid #333333; background-color: #CCCCCC;">
                      
                      <asp:CheckBoxList ID="chkListForeignLang" runat="server" CellPadding="1" CellSpacing="1" >
                   
                         <asp:ListItem Value="CHI102">CHI-102</asp:ListItem>
                         <asp:ListItem Value="FRN102">FRN-102</asp:ListItem>
                         <asp:ListItem Value="GRM102">GRM-102</asp:ListItem>
                          <asp:ListItem Value="SPN102">SPN-102</asp:ListItem>
                        
                     </asp:CheckBoxList>
                      
                  </td>

                  <td class="auto-style5"></td>
              </tr>
              <tr>
                  <td class="auto-style1" style="padding: 10px; border: medium solid #333333; background-color: #CCCCCC;">
                      <asp:CheckBoxList ID="chkListMath" runat="server">
                          <asp:ListItem Value="MAT141">MAT-141</asp:ListItem>
                          <asp:ListItem Value="MAT142">MAT-142</asp:ListItem>
                          <asp:ListItem Value="MAT174">MAT-174</asp:ListItem>
                          <asp:ListItem Value="MAT315">MAT-315</asp:ListItem>

                      </asp:CheckBoxList>
                  </td>
                  <td class="auto-style1" style="padding: 10px; border: medium solid #333333; background-color: #CCCCCC; text-align: center;">
                      <asp:Label ID="lblHistory" runat="server" Text="History" BackColor="Gray" BorderColor="Black" BorderStyle="Double" ForeColor="White" Width="46px"></asp:Label>
                      <asp:CheckBoxList ID="chkListHistory" runat="server">
                          <asp:ListItem Value="HST101">HST-101</asp:ListItem>
                         <asp:ListItem Value="HST102">HST-102</asp:ListItem>
                         <asp:ListItem Value="HST105">HST-105</asp:ListItem>
                          <asp:ListItem Value="HST106">HST-106</asp:ListItem>
                      </asp:CheckBoxList>
                  </td>
              </tr>
              <tr>
                  <td class="auto-style1" style="padding: 10px; border: medium solid #333333; background-color: #CCCCCC;">
                      <asp:CheckBoxList ID="chkListNScience" runat="server">
                          <asp:ListItem Value="BIO101">BIO-101</asp:ListItem>
                          <asp:ListItem Value="BIO102">BIO-102</asp:ListItem>
                          <asp:ListItem Value="CHM111">CHM-111</asp:ListItem>
                          <asp:ListItem Value="CHM112">CHM-112</asp:ListItem>
                          <asp:ListItem Value="PHS211">PHS-211</asp:ListItem>
                          <asp:ListItem Value="PHS212">PHS-212</asp:ListItem>
                      </asp:CheckBoxList>
                  </td>
                  <td class="auto-style1" style="padding: 10px; border: medium solid #333333; background-color: #CCCCCC;">
                      <asp:CheckBoxList ID="chkListSBScience" runat="server">
                          <asp:ListItem Value="AAS201">AAS-201</asp:ListItem>
                          <asp:ListItem Value="ANT102">ANT-102</asp:ListItem>
                          <asp:ListItem Value="ECO221">ECO-221</asp:ListItem>
                          <asp:ListItem Value="ECO222">ECO-222</asp:ListItem>
                          <asp:ListItem Value="GEG101">GEG-101</asp:ListItem>
                          <asp:ListItem Value="GEG103">GEG-103</asp:ListItem>
                          <asp:ListItem Value="GIS101">GIS-101</asp:ListItem>
                          <asp:ListItem Value="GIS200">GIS-200</asp:ListItem>
                          <asp:ListItem Value="GIS320">GIS-320</asp:ListItem>
                          <asp:ListItem Value="PSY101">PSY-101</asp:ListItem>
                          <asp:ListItem Value="SOC101">SOC-101</asp:ListItem>
                          <asp:ListItem Value="WST101">WST-101</asp:ListItem>
                      </asp:CheckBoxList>
                  </td>
              </tr>
              <tr>
                  <td style="padding: 10px; border: medium solid #333333; background-color: #CCCCCC;">
                      <asp:CheckBoxList ID="chkListArt" runat="server">
                          <asp:ListItem Value="AAS204">AAS-204</asp:ListItem>
                          <asp:ListItem Value="ATH101">ATH-101</asp:ListItem>
                          <asp:ListItem Value="ATH105">ATH-105</asp:ListItem>
                          <asp:ListItem Value="ATH106">ATH-106</asp:ListItem>
                          <asp:ListItem Value="MUS110">MUS-110</asp:ListItem>
                          <asp:ListItem Value="THE161">THE-161</asp:ListItem>
                          <asp:ListItem Value="THE170">THE-170</asp:ListItem>
                      </asp:CheckBoxList>

                  </td>
                  <td style="padding: 10px; border: medium solid #333333; background-color: #CCCCCC;">
                      <asp:CheckBoxList ID="chkListCSMain" runat="server">
                          <asp:ListItem Value="CSC150">CSC-150</asp:ListItem>
                          <asp:ListItem Value="CSC200">CSC-200</asp:ListItem>
                          <asp:ListItem Value="CSC210">CSC-210</asp:ListItem>
                          <asp:ListItem Value="CSC234">CSC-234</asp:ListItem>
                          <asp:ListItem Value="CSC238">CSC-238</asp:ListItem>
                          <asp:ListItem Value="CSC300">CSC-300</asp:ListItem>
                          <asp:ListItem Value="CSC310">CSC-310</asp:ListItem>
                          <asp:ListItem Value="CSC321">CSC-321</asp:ListItem>
                          <asp:ListItem Value="CSC421">CSC-421</asp:ListItem>
                          <asp:ListItem Value="CSC511">CSC-511</asp:ListItem>
                          <asp:ListItem Value="CSC530">CSC-530</asp:ListItem>
                          <asp:ListItem Value="CSC540">CSC-540</asp:ListItem>
                          
                      </asp:CheckBoxList>

                  </td>
              </tr>
          </table>
          
                
                  
              
              

              

          
          
          

            <asp:Panel ID="Panel2" runat="server" Height="85px">
                <asp:Button ID="btnAdvise" runat="server" Text="Advise" OnClick="btnAdvise_Click" />
                <asp:Label ID="Label2" runat="server" Text="Recommended"></asp:Label>
                <asp:ListBox ID="RecommendedListBox" runat="server"></asp:ListBox>
                <asp:ListBox ID="TakenListBox" runat="server"></asp:ListBox>
                <asp:ListBox ID="TestBox" runat="server"></asp:ListBox>
          </asp:Panel>
          
                
                  
              
              

              

          
          
          

            </asp:Panel>
    
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .auto-style1 {
            width: 150px;
        }
        .auto-style4 {
            width: 150px;
            height: 146px;
        }
        .auto-style5 {
            height: 146px;
        }
    </style>
</asp:Content>
