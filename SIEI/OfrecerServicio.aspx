<%@ Page Title="Ofrecer servicios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OfrecerServicio.aspx.cs" Inherits="SIEI.OfrecerServicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="padding-top: 3em; text-align:center"><%: Title %> </h2>
    <div class="row">
        <div class="form-horizontal col-md-8 col-md-offset-2">
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

            <div class="row">
                <div class="col-md-8 col-md-offset-3">
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="DDLTipo" CssClass="col-md-2 control-label">Tipo de servicio:</asp:Label>

                        <div class="col-md-10">

                            <asp:DropDownList runat="server" ID="DDLTipo" CssClass="form-control">
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
                            <asp:TextBox runat="server" ID="txtDesc" CssClass="form-control" TextMode="MultiLine" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtDesc"
                                CssClass="text-danger" ErrorMessage="La descripción es requerida." />
                        </div>
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="col-md-8 col-md-offset-3">

                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtCosto" CssClass="col-md-2  control-label"> Costo monetario:</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtCosto" CssClass="form-control" TextMode="MultiLine" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtCosto"
                                CssClass="text-danger" ErrorMessage="La descripción es requerida." />
                        </div>
                    </div>
                </div>
            </div>



             <div class="row">
                <div class="col-md-8 col-md-offset-3">

                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="FUImage" CssClass="col-md-2  control-label"> Imagen:</asp:Label>
                        <div class="col-md-10">
                            <asp:FileUpload ID="FUImage" runat="server" />
                      
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



        </div>

    </div>
</asp:Content>
