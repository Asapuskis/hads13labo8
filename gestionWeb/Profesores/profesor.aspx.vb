Public Class profesor
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        lblUsuario.Text = Session("usuario")
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Application("numUsuarios") -= 1
        Application("numProfesores") -= 1
        Dim list As ListBox = Application("listaProfesores")
        Dim item As New ListItem
        For Each it As ListItem In list.Items
            If it.Value = Session("usuario") Then
                item = it
            End If
        Next

        If Not item.Value = "" Then
            list.Items.Remove(item)
            Application("listaProfesores") = list
        End If

        Session.Remove("usuario")
        Session.Remove("tipoUsuario")

        System.Web.Security.FormsAuthentication.SignOut()
        Response.Redirect("~/Inicio.aspx")
    End Sub

    Protected Sub TimerUsuariosConectados_Tick(sender As Object, e As EventArgs) Handles TimerUsuariosConectados.Tick
        lblUsuariosConectados.Text = Application("numUsuarios").ToString

        lblProfesoresConectados.Text = Application("numProfesores").ToString
        listProfesores.Items.Clear()
        For Each it As ListItem In Application("listaProfesores").Items
            listProfesores.Items.Add(it)
        Next

        listAlumnos.Items.Clear()
        lblAlumnosConectados.Text = Application("numAlumnos").ToString
        For Each it As ListItem In Application("listaAlumnos").Items
            listAlumnos.Items.Add(it)
        Next

        Dim Prof As New AjaxControlToolkit.PieChartValue
        Prof.Category = "Profesores"
        Prof.Data = Application("numProfesores")
        Prof.PieChartValueColor = "RED"
        Prof.PieChartValueStrokeColor = "WHITE"
        PieChart1.PieChartValues.Add(Prof)

        Dim Alu As New AjaxControlToolkit.PieChartValue
        Alu.Category = "Alumnos"
        Alu.Data = Application("numAlumnos")
        Alu.PieChartValueColor = "BLUE"
        Alu.PieChartValueStrokeColor = "GREEN"

        PieChart1.PieChartValues.Add(Alu)
        PieChart1.DataBind()

    End Sub
End Class