<%@ Page Title="Contratar servicios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ContratarServicios.aspx.cs" Inherits="SIEI.contratarServicios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2 style="padding: 3em 0 1em 0; text-align: center"><%: Title %> </h2>
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
        <div class="col-md-6 col-md-offset-3 box_finder">
            <asp:Label runat="server" AssociatedControlID="DDLCriterio" CssClass="col-md-5 col-md-offset-2 control-label"><span style="color:white">Criterio de busqueda</span></asp:Label>
            <div class="col-md-4">
                <asp:DropDownList ID="DDLCriterio" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
        </div>

    </div>
    <div class="row">
        <div class="col-md-6 col-md-offset-3 box_finder">

            <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
           
        </div>
    </div>
</asp:Content>
