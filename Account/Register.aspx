<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Account_Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <form runat="server">
     <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2><asp:Label ID="Label1" runat="server" Font-Size="XX-Large" ForeColor="#009933" Text="Please register here!"></asp:Label>
&nbsp;.</h2>
    </hgroup>

    <asp:Label ID="Label2" runat="server" ForeColor="#009933" Text="Already have and account? "></asp:Label>
     <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Account/Login.aspx">Log in</asp:HyperLink>

    <asp:CreateUserWizard runat="server" ID="RegisterUser" ViewStateMode="Disabled" OnCreatedUser="RegisterUser_CreatedUser" ForeColor="#009933" FinishDestinationPageUrl="~/About.aspx">
        <HeaderStyle BackColor="Black" />
        <LayoutTemplate>
            <asp:PlaceHolder runat="server" ID="wizardStepPlaceholder" />
            <asp:PlaceHolder runat="server" ID="navigationPlaceholder" />
        </LayoutTemplate>
        <TitleTextStyle ForeColor="#009933" />
        <WizardSteps>
            <asp:CreateUserWizardStep runat="server" ID="RegisterUserWizardStep">
                <ContentTemplate>
                    <p class="message-info">
                        Passwords are required to be a minimum of <%: Membership.MinRequiredPasswordLength %> characters in length.
                    </p>

                    <p class="validation-summary-errors">
                        <asp:Literal runat="server" ID="ErrorMessage" />
                    </p>

                    <fieldset>
                        <legend>Registration Form</legend>
                        <ol>
                            <li>
                                <asp:Label runat="server" AssociatedControlID="UserName">User name</asp:Label>
                                <asp:TextBox runat="server" ID="UserName" Font-Names="Arial Black" MaxLength="25" BackColor="White" BorderColor="White" Font-Size="Medium" ForeColor="Black"/>
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName"
                                    CssClass="field-validation-error" ErrorMessage="The user name field is required." />
                            </li>
                            <li>
                                <asp:Label runat="server" AssociatedControlID="Email">Email address</asp:Label>
                                <asp:TextBox runat="server" ID="Email" Font-Names="Arial Black" MaxLength="25" BackColor="White" BorderColor="White" Font-Size="Medium" ForeColor="Black" TextMode="Email" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                                    CssClass="field-validation-error" ErrorMessage="The email address field is required." />
                            </li>
                            <li>
                                <asp:Label runat="server" AssociatedControlID="Password">Password</asp:Label>
                                <asp:TextBox runat="server" ID="Password" Font-Names="Arial Black" MaxLength="25" BackColor="White" BorderColor="White" Font-Size="Medium" ForeColor="Black" TextMode="Password" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
                                    CssClass="field-validation-error" ErrorMessage="The password field is required." />
                            </li>
                            <li>
                                <asp:Label runat="server" AssociatedControlID="ConfirmPassword">Confirm password</asp:Label>
                                <asp:TextBox runat="server" ID="ConfirmPassword" Font-Names="Arial Black" MaxLength="25" BackColor="White" BorderColor="White" Font-Size="Medium" ForeColor="Black" TextMode="Password" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmPassword"
                                     CssClass="field-validation-error" Display="Dynamic" ErrorMessage="The confirm password field is required." />
                                <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword"
                                     CssClass="field-validation-error" Display="Dynamic" ErrorMessage="The password and confirmation password do not match." />
                            </li>
                        </ol>
                        <asp:Button runat="server" CommandName="MoveNext" Text="Register" BackColor="#006600" Font-Names="Arial Black" />
                    </fieldset>
                </ContentTemplate>
                <CustomNavigationTemplate />
            </asp:CreateUserWizardStep>
<asp:CompleteWizardStep runat="server"></asp:CompleteWizardStep>
        </WizardSteps>
        <StepNextButtonStyle ForeColor="Black" />
        <StepStyle ForeColor="#009933" />
    </asp:CreateUserWizard>

   </form>
</asp:Content>