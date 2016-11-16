<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DatosEmpresa.aspx.cs" Inherits="SIEI.DatosEmpresa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <h2 style="padding-top: 3em"><%: Title %> </h2>
    <div class="row">
        <div class="form-horizontal col-md-6">
            <h4>Datos de la empresa</h4>
            <hr />
            <asp:ValidationSummary runat="server" CssClass="text-danger" />

            <script type="text/javascript">
                function removeHeader() {
                    document.getElementById("aNav").className =
                        document.getElementById("aNav").className.replace(/\bmyNav\b/, '');
                    document.getElementById("imgHeader").style.display = "none";
                    document.getElementById("regPers").style.fontSize = "1em";
                    document.getElementById("regEmp").style.fontSize = "1em";
                }
                removeHeader();
            </script>




            <div class="form-group">

                <div class="row">
                    <div class="col-md-12">
                        <div id="check" runat="server" class="alert alert-success" style="display: none">
                            <strong>Éxito!</strong> Sus datos fueron actualizados.
                        </div>
                        <asp:Label runat="server" AssociatedControlID="txtIdentificacion" CssClass="col-md-3 control-label">Identificación:</asp:Label>
                        <div class="col-md-6">
                            <asp:TextBox runat="server" ID="txtIdentificacion" CssClass="form-control" MaxLength="15" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtIdentificacion"
                                CssClass="text-danger" ErrorMessage="La identificación es un campo requerido." />
                        </div>
                    </div>
                </div>


                <div class="row">
                    <div class="col-md-12">
                        <asp:Label runat="server" AssociatedControlID="txtNombre" CssClass="col-md-3 control-label">Nombre:</asp:Label>
                        <div class="col-md-6">
                            <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control" MaxLength="15" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtNombre"
                                CssClass="text-danger" ErrorMessage="El nombre es un campo requerido." />
                        </div>
                    </div>
                </div>


                <div class="row">
                    <div class="col-md-12">
                        <asp:Label runat="server" AssociatedControlID="txtAutenticacion" CssClass="col-md-3 control-label">Autenticación:</asp:Label>
                        <div class="col-md-6">
                            <asp:TextBox runat="server" ID="txtAutenticacion" CssClass="form-control" MaxLength="15" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtAutenticacion"
                                CssClass="text-danger" ErrorMessage="El campo no funciona" />
                        </div>
                    </div>
                </div>



                <div class="row">
                    <div class="col-md-12">
                        <asp:Label runat="server" AssociatedControlID="txtCertificacion" CssClass="col-md-3 control-label">Certificacion:</asp:Label>
                        <div class="col-md-6">
                            <asp:TextBox runat="server" ID="txtCertificacion" CssClass="form-control" MaxLength="15" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtCertificacion"
                                CssClass="text-danger" ErrorMessage="El campo no funciona" />
                        </div>
                    </div>
                </div>

                <asp:UpdatePanel ID="Update_Telefonos" runat="server" UpdateMode="conditional" ChildrenAsTriggers="false">
                    <ContentTemplate>
                        <div class="form-group">
                            <div class="row">
                                <div class="col-md-12">
                                    <strong>
                                        <asp:Label ID="lblTelefono" runat="server" Text="Teléfono:" CssClass="col-md-3 control-label"></asp:Label></strong>
                                    <div class="col-md-6 ">
                                        <asp:TextBox runat="server" ID="txtTelefono" PlaceHolder="Ej: 88888888" CssClass="form-control" TextMode="Phone" MaxLength="11"></asp:TextBox>
                                        <asp:RegularExpressionValidator ID="REV2" runat="server" ControlToValidate="txtTelefono" ErrorMessage="*Ingrese Valores Numéricos"
                                            ForeColor="Red" ValidationExpression="^[0-9]*"> </asp:RegularExpressionValidator>
                                    </div>

                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <strong>
                                        <asp:Label ID="lbl2Telefono" runat="server" Text="Teléfono 2:" CssClass="col-md-3 control-label"></asp:Label></strong>
                                    <div class="col-md-6 ">
                                        <asp:TextBox runat="server" ID="txtTelefono2" PlaceHolder="Ej: 88888888" CssClass="form-control" TextMode="Phone" MaxLength="11"></asp:TextBox>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtTelefono2" ErrorMessage="*Ingrese Valores Numéricos"
                                            ForeColor="Red" ValidationExpression="^[0-9]*"> </asp:RegularExpressionValidator>
                                    </div>

                                </div>
                            </div>
                        </div>
                        </div>

                    </ContentTemplate>
                </asp:UpdatePanel>



            </div>
            <div class="form-horizontal col-md-6">
                <h4>&nbsp;</h4>
                <hr />
                <asp:ValidationSummary runat="server" CssClass="text-danger" />
                <div class="row">
                    <div class="col-md-12">
                        <asp:Label runat="server" AssociatedControlID="txtCorreo" CssClass="col-md-3 control-label">Correo:</asp:Label>
                        <div class="col-md-6">
                            <asp:TextBox runat="server" ID="txtCorreo" CssClass="form-control" MaxLength="15" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtCorreo"
                                CssClass="text-danger" ErrorMessage="El correo es un campo requerido." />
                        </div>
                    </div>

                </div>
                <div class="row">
                    <div class="col-md-12">
                        <asp:Label runat="server" AssociatedControlID="txtPassword" CssClass="col-md-3 control-label">Contraseña:</asp:Label>
                        <div class="col-md-6">
                            <asp:TextBox runat="server" ID="txtPassword" CssClass="form-control" MaxLength="15" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPassword"
                                CssClass="text-danger" ErrorMessage="La contraseña es un campo requerido." />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <asp:Label runat="server" AssociatedControlID="txtChangePassword" CssClass="col-md-3 control-label">Cambiar contraseña:</asp:Label>
                        <div class="col-md-6">
                            <asp:TextBox runat="server" ID="txtChangePassword" CssClass="form-control" MaxLength="15" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPassword"
                                CssClass="text-danger" ErrorMessage="Necesita confimar contraseña" />
                        </div>
                    </div>
                </div>

                <div class="row">

                    <div class="col-md-12">

                        <asp:UpdatePanel ID="Update_Ubicaciones" runat="server" UpdateMode="conditional" ChildrenAsTriggers="false">
                            <ContentTemplate>
                                <div class="form-group">
                                    <div class="row">
                                        <div class="col-md-12">
                                            <strong>
                                                <asp:Label ID="Label1" runat="server" Text="Ubicaciones:" CssClass="col-md-3 control-label"></asp:Label></strong>
                                            <div class="col-sm-6 ">
                                                <asp:DropDownList runat="server" ID="comboAreaTrabajo" AutoPostBack="True" CssClass="form-control" OnSelectedIndexChanged="areaSeleccionada" EnableViewState="true"></asp:DropDownList>
                                            </div>
                                            <div class="col-md-1">
                                                <asp:LinkButton runat="server" ID="LinkButton1" CssClass="glyphicon.glyphicon-plus-sign">
                                        <span aria-hidden="true" class="glyphicon glyphicon-plus-sign blueColor"></span>
                                                </asp:LinkButton>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                </div>
                    <div class="form-group">
                        <div class="row">
                            <strong>
                                <asp:Label ID="Label2" runat="server" Text="Teléfonos agregados" CssClass="col-md-3 control-label"></asp:Label></strong>


                            <div class="col-md-6 ">
                                <asp:ListBox runat="server" ID="ListBox1" CssClass="form-control"></asp:ListBox>
                            </div>
                            <div class="col-md-1">
                                <asp:LinkButton runat="server" ID="LinkButton2" Style="height: 100px" CssClass="">
                                        <span aria-hidden="true" class="glyphicon glyphicon-minus-sign blueColor"></span>
                                </asp:LinkButton>
                            </div>
                        </div>

                    </div>



                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>




                <div class="row">
                    <div class="col-xs-6 col-lg-4">

                        <div style="float: right">
                            <asp:Button runat="server" Text="Actualizar" CssClass="btn btn-default" />


                        </div>

                    </div>
                </div>

            </div>

        </div>



    </div>


</asp:Content>
