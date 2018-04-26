Public Class tareasProfesor
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblUsuario.Text = Session("usuario")
    End Sub

    Protected Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
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

        Session.Remove("dataView")
        Session.Remove("dataSet")
        System.Web.Security.FormsAuthentication.SignOut()
        Response.Redirect("~/Inicio.aspx")
    End Sub

    Protected Sub btnInsTarea_Click(sender As Object, e As EventArgs) Handles btnInsTarea.Click
        Response.Redirect("insertarTarea.aspx")
    End Sub
End Class