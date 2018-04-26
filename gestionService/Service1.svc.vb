' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class ServicioGestion
    Implements IServicio

    Public Sub New()
    End Sub

    Public Function GetData(ByVal value As Integer) As String Implements IServicio.GetData
        Return String.Format("You entered: {0}", value)
    End Function

    Public Function GetDataUsingDataContract(ByVal composite As CompositeType) As CompositeType Implements IServicio.GetDataUsingDataContract
        If composite Is Nothing Then
            Throw New ArgumentNullException("composite")
        End If
        If composite.BoolValue Then
            composite.StringValue &= "Suffix"
        End If
        Return composite
    End Function

    Public Function comprobarTarea(ByVal codTarea) As Boolean
        Dim accesoDatosSQL As New accesoDatosSQL.accesoDatosSQL
        Dim ds As New DataSet
        ds = accesoDatosSQL.comprobarTarea(codTarea)
        Dim dt As New DataTable
        dt = ds.Tables(0)
        If dt.Rows.Count > 0 Then
            Return 0
        Else
            Return 1
        End If
    End Function

End Class
