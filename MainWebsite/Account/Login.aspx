<%@ Page Title="Log in" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MainWebsite.Account.Login" Async="true" %>

<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>

    <div class="row">
        <div class="col-md-8">
            <section id="loginForm">
                <div class="form-horizontal">
                    <h4>Please enter credentials</h4>
                    <p>&nbsp;</p>
            <p>
                <asp:Label ID="usernameLabel" runat="server" Text="Username:"></asp:Label>
            </p>
                    <p>
                <asp:TextBox ID="usernameTextBox" runat="server"></asp:TextBox>
                <asp:Label ID="LoggedinLabel" runat="server" Text="Label" Visible="False"></asp:Label>
            </p>
                    <p>
                <asp:Label ID="passwordLabel" runat="server" Text="Password:"></asp:Label>
            </p>
                    <p>
                <asp:TextBox ID="passwordTextBox" runat="server"></asp:TextBox>
            </p>
                    <p>
                        &nbsp;</p>
                    <p><asp:Button ID="loginButton" runat="server" OnClick="loginButton_Click" Text="Login" />
                <asp:Button ID="checkLoginInfo" runat="server" OnClick="checkLoginInfo_Click" Text="Button" />
                <asp:Button ID="logoutButton" runat="server" Text="Log ud" Visible="False" OnClick="logoutButton_Click" />
                    </p>
                    <hr />
                      <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                        <p class="text-danger">
                            <asp:Literal runat="server" ID="FailureText" />
                        </p>
                    </asp:PlaceHolder>
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
        <div class="col-md-4">
            <p>
                &nbsp;</p>
        </div>
                        </div>
                    </div>
                </div>
                <p>
                    <%-- Enable this once you have account confirmation enabled for password reset functionality
                    <asp:HyperLink runat="server" ID="ForgotPasswordHyperLink" ViewStateMode="Disabled">Forgot your password?</asp:HyperLink>
                    --%>
                </p>
                <p>
                    &nbsp;</p>
                <p>
                    &nbsp;</p>
                <p>
                    &nbsp;</p>
            </section>
        </div>

    </div>
</asp:Content>
