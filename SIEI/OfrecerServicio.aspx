<%@ Page Title="Ofrecer servicios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OfrecerServicio.aspx.cs" Inherits="SIEI.OfrecerServicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="padding-top: 0em; text-align: center"><%: Title %> </h2>
    <div class="row">
         <hr />
        <div class="form-horizontal col-md-8 col-md-offset-1">
           
            <asp:ValidationSummary runat="server" CssClass="text-danger" />

           

             <div class="row">
        <div class="col-md-8 col-md-offset-2" style = "text-align:center;">
            <div id="check" runat="server" class="alert alert-success" >
                <strong>Éxito!</strong> Nuevo servicio insertado en el sistema
            </div>

        </div>
    </div>

            <div class="row">
                <div class="col-md-8 col-md-offset-3">
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="comboServicio" CssClass="col-md-2 control-label">Tipo de servicio:</asp:Label>

                        <div class="col-md-10">

                            <asp:DropDownList runat="server" ID="comboServicio" CssClass="form-control">
                            </asp:DropDownList>
                        </div>


                    </div>
                </div>
            </div>


            <div class="row">
                <div class="col-md-8 col-md-offset-3">

                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtDesc" CssClass="col-md-2  control-label"> Descripción:</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtDesc" CssClass="form-control" TextMode="MultiLine" MaxLength="200" style="height:8em"/>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtDesc"
                                CssClass="text-danger" ErrorMessage="La descripción es un campo requerido." />
                        </div>
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="col-md-8 col-md-offset-3">

                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtCosto" CssClass="col-md-2  control-label"> Costo monetario:</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtCosto" CssClass="form-control" MaxLength="20"/>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtCosto"
                                CssClass="text-danger" ErrorMessage="El costo es un campo requerido." />
                        </div>
                    </div>
                </div>
            </div>



            <div class="row">
                <div class="col-md-8 col-md-offset-3">

                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="FileUploadImage" CssClass="col-md-2  control-label"> Imagen:</asp:Label>
                        <div class="col-md-10">
                            <asp:FileUpload ID="FileUploadImage" runat="server" onchange="this.form.submit()" />

                        </div>
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="col-md-8 col-md-offset-3">

                    <div class="form-group">

                        <div class="col-md-10">

                            <asp:Image ID="ImgUploaded" runat="server" />

                        </div>
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="col-md-12" style="float: right">
                    <div class=" col-md-9">
                        <div style="float: right">
                            <asp:Button runat="server" Text="Actualizar" CssClass="btn btn-default" OnClick="actualizarServicio"/>
                        </div>
                    </div>
                </div>
            </div>

        </div>

    </div>
</asp:Content>
