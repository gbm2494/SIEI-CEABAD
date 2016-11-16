<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InformacionPersonal.aspx.cs" Inherits="SIEI.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="padding-top: 3em"><%: Title %> </h2>
    <div class="row">
        <div class="form-horizontal col-md-6">
            <h4>Datos personales</h4>
            <hr />
            <asp:ValidationSummary runat="server" CssClass="text-danger" />

            <script type="text/javascript">
                function removeHeader() {
                    document.getElementById("aNav").className =
                        document.getElementById("aNav").className.replace(/\bmyNav\b/, '');
                    document.getElementById("imgHeader").style.display = "none";
                    document.getElementById("regPers").style.fontSize = "1em";
                    document.getElementById("bscEmpleo").style.fontSize = "1em";
                    document.getElementById("contServ").style.fontSize = "1em";
                    document.getElementById("ofrecerServ").style.fontSize = "1em";
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
                        <asp:Label runat="server" AssociatedControlID="txtApellido" CssClass="col-md-3 control-label">Primer apellido:</asp:Label>
                        <div class="col-md-6">
                            <asp:TextBox runat="server" ID="txtApellido" CssClass="form-control" MaxLength="15" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtApellido"
                                CssClass="text-danger" ErrorMessage="El Apellido es un campo requerido." />
                        </div>
                    </div>
                </div>


                <div class="row">
                    <div class="col-md-12">
                        <asp:Label runat="server" AssociatedControlID="txtApellido2" CssClass="col-md-3 control-label">Segundo apellido:</asp:Label>
                        <div class="col-md-6">
                            <asp:TextBox runat="server" ID="txtApellido2" CssClass="form-control" MaxLength="15" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtApellido2"
                                CssClass="text-danger" ErrorMessage="El segundo apellido es un campo requerido." />
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
                                    <div class="col-sm-6 ">
                                        <asp:TextBox runat="server" ID="txtTelefono" PlaceHolder="Ej: 88888888" CssClass="form-control" TextMode="Phone" MaxLength="11"></asp:TextBox>
                                        <asp:RegularExpressionValidator ID="REV2" runat="server" ControlToValidate="txtTelefono" ErrorMessage="*Ingrese Valores Numéricos"
                                            ForeColor="Red" ValidationExpression="^[0-9]*"> </asp:RegularExpressionValidator>
                                    </div>
                                    <div class="col-md-1">
                                        <asp:LinkButton runat="server" ID="lnkNumero" CssClass="glyphicon.glyphicon-plus-sign" >
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
                                <asp:Label ID="lbltels" runat="server" Text="Teléfonos agregados" CssClass="col-md-3 control-label"></asp:Label></strong>


                            <div class="col-md-6 ">
                                <asp:ListBox runat="server" ID="listTelefonos" CssClass="form-control"></asp:ListBox>
                            </div>
                            <div class="col-md-1">
                                <asp:LinkButton runat="server" ID="lnkQuitar" Style="height: 100px" CssClass="">
                                        <span aria-hidden="true" class="glyphicon glyphicon-minus-sign blueColor"></span>
                                </asp:LinkButton>
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
                            <asp:TextBox runat="server" ID="txtPassword" CssClass="form-control" MaxLength="50" />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <asp:Label runat="server" AssociatedControlID="txtConfirm" CssClass="col-md-3 control-label">Confirmar:</asp:Label>
                        <div class="col-md-6">
                            <asp:TextBox runat="server" ID="txtConfirm" CssClass="form-control" MaxLength="50" />
                        </div>
                    </div>
                </div>
                 <div class="form-group">
                            <div class="row">
                               <strong> <asp:Label ID="disc" runat="server" Text="¿Presenta algún tipo de discapacidad física o cognoscitiva? La información no será suministrada a las empresas." CssClass="col-md-6 control-label"></asp:Label></strong>
                          <asp:CheckBox runat="server" CssClass="col-md-1  control-label" ID="chkDiscapacidad"></asp:CheckBox>

                            </div>

                        </div>
                <div class="row">
                    <div class="col-md-12">
                        <div class=" col-md-9">
                            <div style="float:right">
                            <asp:Button runat="server" Text="Actualizar" CssClass="btn btn-default" />
                        </div>

                        </div>

                    </div>
                </div>
                 
            </div>

         </div>



    </div>

</asp:Content>

