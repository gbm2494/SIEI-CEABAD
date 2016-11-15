<%@ Page Title="Registro de personas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="SIEI.Account.Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %></h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" Visible="false" />
    </p>

    <div class="form-horizontal">
        <h4>Crea tu cuenta</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtIdentificacion" CssClass="col-md-2 control-label">Identificación:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtIdentificacion" CssClass="form-control" MaxLength="15"/>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtIdentificacion"
                    CssClass="text-danger" ErrorMessage="La cédula es un campo requerido." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtEmail" CssClass="col-md-2 control-label">Correo:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" TextMode="Email" MaxLength="50"/>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtEmail"
                    CssClass="text-danger" ErrorMessage="El correo electrónico es un campo requerido." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtPassword" CssClass="col-md-2 control-label">Contraseña:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" CssClass="form-control" MaxLength="50"/>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPassword"
                    CssClass="text-danger" ErrorMessage="La contraseña es un campo requerido." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtconfirmPassword" CssClass="col-md-2 control-label">Confirme contraseña:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtconfirmPassword" TextMode="Password" CssClass="form-control" MaxLength="50"/>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtconfirmPassword"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="La confirmación de contraseña es un campo requerido." />
                <asp:CompareValidator runat="server" ControlToCompare="txtPassword" ControlToValidate="txtconfirmPassword"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="La contraseña y la confirmación de contraseña no son iguales." />
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClick="CreateUser_Click" Text="Registrar" CssClass="btn btn-default" />
            </div>
        </div>
    </div>
</asp:Content>
