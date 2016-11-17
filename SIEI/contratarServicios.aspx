<%@ Page Title="Contratar servicios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ContratarServicios.aspx.cs" Inherits="SIEI.contratarServicios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2 style="text-align: center"><%: Title %> </h2>
    <asp:ValidationSummary runat="server" CssClass="text-danger" />
    <div class="row">
        <div class="col-md-6 col-md-offset-3 box_finder">
            <asp:Label runat="server" AssociatedControlID="DDLCriterio" CssClass="col-md-5 col-md-offset-2 control-label"><span style="color:white">Criterio de busqueda</span></asp:Label>
            <div class="col-md-4">
                <asp:DropDownList ID="DDLCriterio" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
        </div>

    </div>



    <div class="row">
        <div class="col-md-6 col-md-offset-3 " style ="">
           <asp:GridView ID="gridDisenos" runat="server" CssClass="dataGridTable" Style="width: 980px; text-align: center" Font-Size="14px" AutoGenerateColumns="true" OnRowCommand="gridPuestos_RowCommand" HeaderStyle-BackColor="#444444" HeaderStyle-ForeColor="White" AlternatingRowStyle-BackColor="#dddddd">
                    <Columns>
                        <asp:TemplateField HeaderText="">

                            <ItemTemplate>
                                <asp:LinkButton runat="server" ID="lnkConsulta" CommandName="seleccionarPuesto" CommandArgument='<%#Eval("Identificador") %>'> Contratar </asp:LinkButton>
                            </ItemTemplate>

                        </asp:TemplateField>


                    </Columns>
                </asp:GridView>
    </div>
        </div>



    
</asp:Content>
