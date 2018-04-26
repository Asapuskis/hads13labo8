<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="profesor.aspx.vb" Inherits="gestionWeb.profesor" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="margin:20px; font-family:Calibri">
    <form id="form1" runat="server">
    <div style="position:relative; top: 0px; left: 0px; width: 202px;">
    
        <asp:HyperLink ID="hyprAsignaturas" runat="server">Asignaturas</asp:HyperLink>
        <br />
        <asp:HyperLink ID="hyprTareas" runat="server" NavigateUrl="~/Profesores/tareasProfesor.aspx">Tareas</asp:HyperLink>
        <br />
        <asp:HyperLink ID="hprGrupos" runat="server">Grupos</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Profesores/importarTareasXML.aspx">Importar XML Document</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Profesores/exportarTareas.aspx">Exportar</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink3" runat="server">Importar DataSet</asp:HyperLink>
        <br />
        <asp:HyperLink ID="hprCoordinador" runat="server" NavigateUrl="~/Profesores/coordinador.aspx">Coordinador</asp:HyperLink>
        <br />
    
    </div>
    <div style="position:relative; top: -111px; left: 210px; width: 1074px;" >
        <h2 style="text-align:center">Gestión Web de Tareas-Dedicación</h2>
        <h2 style="text-align:center">Profesor: 
            <asp:Label ID="lblUsuario" runat="server"></asp:Label>
        </h2>
    </div>
        <asp:Button ID="btnCerrarSesion" runat="server" Text="Cerrar Sesión" />
        <br />
        <br />
        <asp:UpdatePanel ID="UpdatePanelUsuariosConectados" runat="server">
            <ContentTemplate>
                <asp:ScriptManager ID="ScriptManagerUsuariosConectados" runat="server">
                </asp:ScriptManager>
                Usuarios conectados:
                <asp:Label ID="lblUsuariosConectados" runat="server"></asp:Label>
                <br />
                <br />
                Profesores conectados:
                <asp:Label ID="lblProfesoresConectados" runat="server"></asp:Label>
                <br />
                <asp:ListBox ID="listProfesores" runat="server" Height="80px" Width="204px"></asp:ListBox>
                <br />
                <br />
                Alumnos conectados:
                <asp:Label ID="lblAlumnosConectados" runat="server"></asp:Label>
                <br />
                <asp:ListBox ID="listAlumnos" runat="server" Height="80px" Width="209px"></asp:ListBox>
                <asp:Timer ID="TimerUsuariosConectados" runat="server" Interval="5000">
                </asp:Timer>
                <br />
                <br />
                <ajaxToolkit:PieChart ID="PieChart1" runat="server" ChartHeight="300" ChartTitle="Usuarios Conectados" ChartTitleColor="Black" ChartWidth="300" Height="300px" Width="300px">
                </ajaxToolkit:PieChart>
                <br />
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
    </form>
    </body>
</html>
