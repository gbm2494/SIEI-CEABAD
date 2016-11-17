<%@ Page Title="Inicio de sesión" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SIEI.Account.Login" Async="true" %>

<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class=" text-center">
        <h2 style="padding-top: 0em"><%: Title %></h2>
        <p class="text-danger">
            <asp:Literal runat="server" ID="Literal1" Visible="false" />
        </p>
    </div>

    <div class="row" style="padding-top: 2em">

        <div class="col-md-8 col-md-offset-2" style = "text-align:center;">
            <div id="errorPassword" runat="server" class="alert alert-danger" style = " display:none">
                <strong>Error!</strong> Los datos no son correctos.
            </div>

        </div>
    </div>

    <section id="loginForm">
        <div class="form-horizontal text-center">


            <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                <p class="text-danger">
                    <asp:Literal runat="server" ID="FailureText" />
                </p>
            </asp:PlaceHolder>

            <div class="row">
                <div class="col-md-8 col-md-offset-3">
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-md-2 control-label">Correo:</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                                CssClass="text-danger" ErrorMessage="The email field is required." />
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-8 col-md-offset-3">
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="Password" CssClass="col-md-2 control-label">Contraseña:</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" CssClass="text-danger" ErrorMessage="The password field is required." />
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-8 col-md-offset-3">
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="comboRol" CssClass="col-md-2 control-label">Rol:</asp:Label>
                        <div class="col-md-5">
                            <asp:DropDownList runat="server" ID="comboRol" CssClass="form-control">
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
            </div>


            <div class="row">
                <div class="col-md-8 col-md-offset-3">
                    <div class="form-group">
                        <div class="col-md-8">
                            <asp:Button runat="server" OnClick="LogIn" Text="Iniciar sesión" CssClass="btn btn-default" />
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <p class="text-center">
            <%-- Enable this once you have account confirmation enabled for password reset functionality
                    <asp:HyperLink runat="server" ID="ForgotPasswordHyperLink" ViewStateMode="Disabled">Forgot your password?</asp:HyperLink>
            --%>
        </p>
    </section>

</asp:Content>
