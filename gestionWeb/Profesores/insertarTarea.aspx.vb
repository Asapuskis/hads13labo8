Public Class insertarTarea
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblUsuario.Text = Session("usuario")
    End Sub

    Protected Sub btnInsertarTarea_Click(sender As Object, e As EventArgs) Handles btnInsertarTarea.Click
        Dim accesoDatosSQL = New accesoDatosSQL.accesoDatosSQL

        Page.Validate()
        If Page.IsValid Then
            'insertar la tarea
            Dim servicioGestion As New gestionServicioAzure.ServicioClient
            'Dim servicioGestion As New ServiceReference1.ServicioClient
            If servicioGestion.comprobarTarea(txtCodigo.Text) Then
                Dim res As String = accesoDatosSQL.insertarTarea(txtCodigo.Text, txtDescripcion.Text, ListaAsignaturas.SelectedItem.Text, txtHestimadas.Text, True, listaTipoTareas.SelectedItem.Text)

                lblInsertTarea.Text = res
            Else
                lblInsertTarea.Text = "El código de tarea que quiere introducir ya existe."
            End If


        End If
    End Sub
End Class