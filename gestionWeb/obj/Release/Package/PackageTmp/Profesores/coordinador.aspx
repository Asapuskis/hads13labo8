<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="coordinador.aspx.vb" Inherits="gestionWeb.coordinador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                Seleccione una asignatura:&nbsp;
                <asp:DropDownList ID="listAsignaturas" runat="server" AutoPostBack="True" DataSourceID="dsAsignaturas" DataTextField="codigo" DataValueField="codigo">
                </asp:DropDownList>
                <asp:SqlDataSource ID="dsAsignaturas" runat="server" ConnectionString="<%$ ConnectionStrings:hads13ConnectionString %>" SelectCommand="SELECT [codigo] FROM [Asignaturas]"></asp:SqlDataSource>
                <br />
                Tareas realizadas por los alumnos por asignatura:<br />
                <br />
                <asp:GridView ID="gridTareasAlumnos" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#000066" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#00547E" />
                </asp:GridView>
                <br />
                Hora media de las tareas realizadas por los alumnos:&nbsp;&nbsp;
                <asp:Label ID="lblHoraMedia" runat="server" Font-Bold="True"></asp:Label>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <asp:HyperLink ID="hprMenu" runat="server" NavigateUrl="~/Profesores/profesor.aspx">Volver al menú</asp:HyperLink>
        <br />
    
    </div>
    </form>
</body>
</html>
