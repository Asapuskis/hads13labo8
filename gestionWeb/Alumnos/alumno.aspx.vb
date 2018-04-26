Public Class alumnos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblUsuario.Text = Session("usuario")
    End Sub

    Protected Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Application("numUsuarios") -= 1
        Application("numAlumnos") -= 1
        Dim list As ListBox = Application("listaAlumnos")
        Dim item As New ListItem
        For Each it As ListItem In list.Items
            If it.Value = Session("usuario") Then
                item = it
            End If
        Next

        If Not item.Value = "" Then
            list.Items.Remove(item)
            Application("listaAlumnos") = list
        End If

        Session.Remove("usuario")
        Session.Remove("tipoUsuario")

        System.Web.Security.FormsAuthentication.SignOut()
        Response.Redirect("~/Inicio.aspx")
    End Sub

    Protected Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
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
    End Sub
End Class