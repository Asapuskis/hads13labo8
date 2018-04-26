Imports System.ServiceModel
Imports System.ServiceModel.Activation
Imports System.ServiceModel.Web

<ServiceContract(Namespace:="")>
<AspNetCompatibilityRequirements(RequirementsMode:=AspNetCompatibilityRequirementsMode.Allowed)>
Public Class gestionServicio

    <OperationContract()>
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

    ' Agregue aquí más operaciones y márquelas con <OperationContract()>

End Class
