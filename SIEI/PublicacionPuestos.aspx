<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PublicacionPuestos.aspx.cs" Inherits="SIEI.PublicacionPuestos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ValidationSummary runat="server" CssClass="text-danger" />
            <div class =" text-center" style="margin-top: 2em">
            <h2 style="padding-top:3em"><%: Title %></h2>
            <p class="text-danger">
                 <asp:Literal runat="server" ID="ErrorMessage" Visible="false" />
            </p>
            </div>
            <h4>Crear puesto</h4>
            <hr />
            <script type="text/javascript">
                function removeHeader() {
                    document.getElementById("aNav").className =
                        document.getElementById("aNav").className.replace(/\bmyNav\b/, '');
                    document.getElementById("imgHeader").style.display = "none";
                    document.getElementById("empDatos").style.fontSize = "1em";
                    document.getElementById("solici").style.fontSize = "1em";
                    document.getElementById("personal").style.fontSize = "1em";
                    document.getElementById("ranking").style.fontSize = "1em";
                }
                removeHeader();
            </script>


            <div class = "row">
                 <div class="form-group">
                    <strong><asp:Label runat="server" ID="lblIdentificacion" CssClass="col-md-2 control-label">Identificación:</asp:Label></strong>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtIdentificacion" CssClass="form-control" MaxLength="30"/>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtIdentificacion"
                                CssClass="text-danger" ErrorMessage="Se requiere una identificación del puesto" />
                        </div>
                  </div>
            </div>

            <div class = "row">
                 <div class="form-group">
                    <strong><asp:Label runat="server" ID="lblNombre" CssClass="col-md-2 control-label">Nombre:</asp:Label></strong>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control" MaxLength="30"/>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtNombre"
                                CssClass="text-danger" ErrorMessage="Se requiere el nombre del puesto" />
                        </div>
                  </div>
            </div>


            <div class ="row">
                 <div class="form-group">
                    <strong><asp:Label runat="server" ID="lblDescripcion" CssClass="col-md-2 control-label" >Descripción:</asp:Label></strong>
                        <div class="col-xs-6 col-sm-4">
                            <asp:TextBox runat="server" ID="txtDescripcion" CssClass="form-control" TextMode="MultiLine" style="height:8em"/>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtDescripcion"
                                CssClass="text-danger" ErrorMessage="Se requiere brindar una descripción" />
                        </div>
                  </div>
            </div>
 
            <div class ="row">
                 <div class="form-group">
                    <strong><asp:Label runat="server" ID="lblAreaTrabajo" CssClass="col-md-2 control-label" >Area de trabajo:</asp:Label></strong>
                        <div class="col-xs-6 col-sm-4">
                            <asp:DropDownList runat="server" ID="comboAreaTrabajo" AutoPostBack="True" CssClass="form-control" OnSelectedIndexChanged="areaSeleccionada" EnableViewState="true"></asp:DropDownList>
                        </div>
                  </div>
            </div>


            <div class ="row">
                 <div class="form-group">
                    <strong><asp:Label runat="server" ID="lblRequerimientos" CssClass="col-md-2 control-label" >Requerimientos:</asp:Label></strong>
                     <br />
                        <div class="col-xs-6 col-sm-4 col-sm-offset-2">
                            <asp:UpdatePanel ID="Red_Disponibles" runat="server" UpdateMode="conditional" ChildrenAsTriggers="false" >
                            <ContentTemplate>
                                    <asp:ListBox runat="server" ID="listReqDisponibles" CssClass="form-control" style="height:15em"></asp:ListBox>
                             </ContentTemplate>
                             </asp:UpdatePanel>
                        </div>
                        <div class ="col-sm-1 icons">
                            <asp:LinkButton runat="server" ID="btnLogIn" Style="height: 100px" CssClass="">
                                <span class="glyphicon glyphicon-log-in icon"></span>
                            </asp:LinkButton>
                            <br />
                            <asp:LinkButton runat="server" ID="btnLogOut" Style="height: 100px" CssClass="">
                                <span class="glyphicon glyphicon-log-out icon"></span>
                            </asp:LinkButton>

                        </div>
                         
                        <div class="col-xs-6 col-sm-4">
                            <asp:UpdatePanel ID="Req_asignados" runat="server" UpdateMode="conditional" ChildrenAsTriggers="false">
                            <ContentTemplate>
                                    <asp:ListBox runat="server" ID="listAsignados" CssClass="form-control" style="height:15em"></asp:ListBox>
                             </ContentTemplate>
                             </asp:UpdatePanel>
                        </div>
                  </div>
            </div>

            <br />


            
        <div class="row">
            <div class="col-md-8 col-md-offset-4">
                <div class="form-group">
                    <div class="col-md-8">
                        <asp:Button runat="server" OnClick="CreatePuesto_Click" Text="Crear puesto" CssClass="btn btn-default" />
                    </div>
                </div>
            </div>
        </div>
            
            <br />

            <div class="row">
            <div class="col-xs-6 col-sm-4 col-sm-offset-3">
                <div id="scroll" style="height: 183px; width: 700px; overflow: auto;">
                    <asp:GridView ID="gridDisenos" runat="server" CssClass="dataGridTable" Style="width: 980px; text-align: center" Font-Size="14px" AutoGenerateColumns="true" OnRowCommand="gridPuestos_RowCommand" HeaderStyle-BackColor="#444444" HeaderStyle-ForeColor="White" AlternatingRowStyle-BackColor="#dddddd">
                        <Columns>
                            <asp:TemplateField HeaderText="">
                                <ItemTemplate>
                                    <asp:LinkButton runat="server" ID="lnkConsulta" CommandName="seleccionarPuesto" CommandArgument='<%#Eval("Identificador") %>'> Consultar </asp:LinkButton>

                                </ItemTemplate>

                            </asp:TemplateField>


                        </Columns>
                    </asp:GridView>
                </div>
            </div>
</div>
            

            

</asp:Content>
