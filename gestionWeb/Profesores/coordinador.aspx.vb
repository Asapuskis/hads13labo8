Public Class coordinador
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        actualizarDatos()
    End Sub

    Protected Sub listAsignaturas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listAsignaturas.SelectedIndexChanged
        actualizarDatos()
    End Sub

    Protected Sub actualizarDatos()
        Dim coordinador As New coordinadorAzure.coordinadorService
        Dim accesoDatosSQL As New accesoDatosSQL.accesoDatosSQL
        gridTareasAlumnos.DataSource = accesoDatosSQL.getAsignaturasTareas(listAsignaturas.SelectedValue)
        gridTareasAlumnos.DataBind()

        lblHoraMedia.Text = coordinador.comprobarMediaAsignatura(listAsignaturas.SelectedValue).ToString("0.00")
    End Sub

End Class