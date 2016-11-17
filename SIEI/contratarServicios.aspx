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

            <asp:GridView ID="gridSample" runat="server" AutoGenerateColumns="False" ShowFooter="True"
                CssClass="grid" OnRowCommand="gridSample_RowCommand"
                DataKeyNames="identificacion" CellPadding="4" ForeColor="#333333"
                GridLines="None" OnRowCancelingEdit="gridSample_RowCancelingEdit"
                OnRowEditing="gridSample_RowEditing"
                OnRowUpdating="gridSample_RowUpdating"
                OnRowDataBound="gridSample_RowDataBound"
                OnRowDeleting="gridSample_RowDeleting">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:TemplateField HeaderText="">
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkEdit" runat="server" Text="" CommandName="Edit" ToolTip="Edit"
                                CommandArgument=''><img src="../Images/show.png" /></asp:LinkButton>
                            <asp:LinkButton ID="lnkDelete" runat="server" Text="Delete" CommandName="Delete"
                                ToolTip="Delete" OnClientClick='return confirm("Are you sure you want to delete this entry?");'
                                CommandArgument=''><img src="../Images/icon_delete.png" /></asp:LinkButton>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:LinkButton ID="lnkInsert" runat="server" Text="" ValidationGroup="editGrp" CommandName="Update" ToolTip="Save"
                                CommandArgument=''><img src="../Images/icon_save.png" /></asp:LinkButton>
                            <asp:LinkButton ID="lnkCancel" runat="server" Text="" CommandName="Cancel" ToolTip="Cancel"
                                CommandArgument=''><img src="../Images/refresh.png" /></asp:LinkButton>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:LinkButton ID="lnkInsert" runat="server" Text="" ValidationGroup="newGrp" CommandName="InsertNew" ToolTip="Add New Entry"
                                CommandArgument=''><img src="../Images/icon_new.png" /></asp:LinkButton>
                            <asp:LinkButton ID="lnkCancel" runat="server" Text="" CommandName="CancelNew" ToolTip="Cancel"
                                CommandArgument=''><img src="../Images/refresh.png" /></asp:LinkButton>
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="First Name">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtFirstName" runat="server" Text='<%# Bind("FirstName") %>' CssClass="" MaxLength="30"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="valFirstName" runat="server" ControlToValidate="txtFirstName"
                                Display="Dynamic" ErrorMessage="First Name is required." ForeColor="Red" SetFocusOnError="True"
                                ValidationGroup="editGrp">*</asp:RequiredFieldValidator>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblFirstName" runat="server" Text='<%# Bind("FirstName") %>'></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtFirstNameNew" runat="server" CssClass="" MaxLength="30"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="valFirstNameNew" runat="server" ControlToValidate="txtFirstNameNew"
                                Display="Dynamic" ErrorMessage="First Name is required." ForeColor="Red" SetFocusOnError="True"
                                ValidationGroup="newGrp">*</asp:RequiredFieldValidator>
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Last Name">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtLastName" runat="server" Text='<%# Bind("LastName") %>' CssClass="" MaxLength="30"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="valLastName" runat="server" ControlToValidate="txtLastName"
                                Display="Dynamic" ErrorMessage="Last Name is required." ForeColor="Red" SetFocusOnError="True"
                                ValidationGroup="editGrp">*</asp:RequiredFieldValidator>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblLastName" runat="server" Text='<%# Bind("LastName") %>'></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtLastNameNew" runat="server" CssClass="" MaxLength="30"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="valLastNameNew" runat="server" ControlToValidate="txtLastNameNew"
                                Display="Dynamic" ErrorMessage="Last Name is required." ForeColor="Red" SetFocusOnError="True"
                                ValidationGroup="newGrp">*</asp:RequiredFieldValidator>
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Email">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtEmail" runat="server" Text='<%# Bind("Email") %>' CssClass="" MaxLength="30"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="valEmail" runat="server" ControlToValidate="txtEmail"
                                Display="Dynamic" ErrorMessage="Email is required." ForeColor="Red" SetFocusOnError="True"
                                ValidationGroup="editGrp">*</asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="valRegEmail" runat="server" ErrorMessage="Invalid Email" ValidationGroup="editGrp"
                                SetFocusOnError="true" Display="Dynamic" ControlToValidate="txtEmail" ForeColor="Red"
                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblEmail" runat="server" Text='<%# Bind("Email") %>'></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtEmailNew" runat="server" CssClass="" MaxLength="30"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="valEmailNew" runat="server" ControlToValidate="txtEmailNew"
                                Display="Dynamic" ErrorMessage="Email is required." ForeColor="Red" SetFocusOnError="True"
                                ValidationGroup="newGrp">*</asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="valRegEmailNew" runat="server" ErrorMessage="Invalid Email" ValidationGroup="newGrp"
                                SetFocusOnError="true" Display="Dynamic" ControlToValidate="txtEmailNew" ForeColor="Red"
                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Category">
                        <EditItemTemplate>
                            <asp:DropDownList ID="ddlCategory" runat="server">
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="valCategory" runat="server" ControlToValidate="ddlCategory"
                                Display="Dynamic" ErrorMessage="Category is required." ForeColor="Red" SetFocusOnError="True"
                                ValidationGroup="editGrp">*</asp:RequiredFieldValidator>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblCategory" runat="server" Text='<%# Bind("Category.Name") %>'></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:DropDownList ID="ddlCategoryNew" runat="server">
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="valCategoryNew" runat="server" ControlToValidate="ddlCategoryNew"
                                Display="Dynamic" ErrorMessage="Category is required." ForeColor="Red" SetFocusOnError="True"
                                ValidationGroup="newGrp">*</asp:RequiredFieldValidator>
                        </FooterTemplate>
                    </asp:TemplateField>
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>

        </div>
    </div>
</asp:Content>
