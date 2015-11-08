<%@ Page Async="true" Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MainWebsite._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
            <p>
                <asp:Label ID="LoggedinLabel" runat="server" Text="Please log in"></asp:Label>
            </p>
        <h1>&nbsp;</h1>
        <p class="lead">&nbsp;<asp:Label ID="Label1" runat="server"></asp:Label>
        &nbsp;
        </p>
        <p><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        </p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                &nbsp;
                </p>
            <p>
                &nbsp;<asp:Button ID="loginButton" runat="server" OnClick="loginButton_Click" Text="Login" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
