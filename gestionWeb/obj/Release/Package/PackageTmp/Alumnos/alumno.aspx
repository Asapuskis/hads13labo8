<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="alumno.aspx.vb" Inherits="gestionWeb.alumnos" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 462px;
            width: 1214px;
        }
    </style>
</head>
<body style="margin:20px; font-family:Calibri; height: 519px;">
    <div style="position:relative; width:20%">
        <form id="form1" runat="server" dir="ltr"  >
            <asp:Button ID="btnCerrarSesion" runat="server" Text="Cerrar sesión" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:HyperLink ID="hyprTarGen" runat="server" NavigateUrl="~/Alumnos/tareasAlumnos.aspx">Tareas Genéricas</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="hyprTarPro" runat="server">Tareas Propias</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="hyprGrup" runat="server">Grupos</asp:HyperLink>
            <br />
            <br />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
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
                <asp:Timer ID="Timer1" runat="server" Interval="1000">
                </asp:Timer>
            </ContentTemplate>
        </asp:UpdatePanel>
            <ajaxToolkit:UpdatePanelAnimationExtender ID="UpdatePanel1_UpdatePanelAnimationExtender" runat="server" BehaviorID="UpdatePanel1_UpdatePanelAnimationExtender" TargetControlID="UpdatePanel1">
            </ajaxToolkit:UpdatePanelAnimationExtender>
        </form>
    </div>
    <div style="position:relative; width:80%; left: -344px; left: 271px; width: 926px; height: 341px; text-align:center; margin-top:20px; top: -476px;">
     <h1>Gestión Web de Tareas-Dedicación</h1>
        <h1>Alumno: 
            <asp:Label ID="lblUsuario" runat="server"></asp:Label>
        </h1>
    </div>            
    </body>
</html>
