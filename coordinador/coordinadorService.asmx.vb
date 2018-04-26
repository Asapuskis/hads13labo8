Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
<System.Web.Script.Services.ScriptService()>
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class coordinadorService
    Inherits System.Web.Services.WebService

    <WebMethod()>
    Public Function comprobarMediaAsignatura(ByVal asignatura As String) As Double
        Dim accesoDatosSQL As New accesoDatosSQL.accesoDatosSQL
        Dim dataset As New DataSet
        Dim media As Double
        dataset = accesoDatosSQL.getHRealesTareas(asignatura)
        Dim datatable As New DataTable
        datatable = dataset.Tables(0)
        If datatable.Rows.Count > 0 Then
            For Each row In datatable.Rows
                media += row(0)
            Next
            media = media / datatable.Rows.Count
        Else
            media = 0
        End If

        Return media
    End Function

End Class