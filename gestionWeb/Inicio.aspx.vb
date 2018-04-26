Public Class Inicio
    Inherits System.Web.UI.Page

    Protected Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        Page.Validate()
        If Page.IsValid Then
            Dim accesoDatosSQL = New accesoDatosSQL.accesoDatosSQL
            If accesoDatosSQL.iniciarSesion(txtUsu.Text, txtContr.Text) Then
                Dim tipoUsuario As String = accesoDatosSQL.tipo(txtUsu.Text)
                Session("tipoUsuario") = tipoUsuario
                Session("usuario") = txtUsu.Text
                If Session("usuario") = "vadillo@ehu.es" Then
                    Application("numProfesores") += 1
                    Dim lista As ListBox
                    lista = Application("listaProfesores")
                    lista.Items.Add(Session("usuario"))
                    Application("listaProfesores") = lista
                    System.Web.Security.FormsAuthentication.SetAuthCookie(Session("usuario"), True)
                    Response.Redirect("Profesores/profesor.aspx", True)
                Else
                    System.Web.Security.FormsAuthentication.SetAuthCookie(Session("tipoUsuario"), True)
                    If (tipoUsuario = "Profesor") Then
                        Application("numProfesores") += 1
                        Dim lista As ListBox
                        lista = Application("listaProfesores")
                        lista.Items.Add(Session("usuario"))
                        Application("listaProfesores") = lista
                        Response.Redirect("Profesores/profesor.aspx", True)
                    ElseIf tipoUsuario = "Alumno" Then
                        Application("numAlumnos") += 1
                        Dim lista As ListBox
                        lista = Application("listaAlumnos")
                        lista.Items.Add(Session("usuario"))
                        Application("listaAlumnos") = lista
                        Response.Redirect("Alumnos/alumno.aspx", True)
                    ElseIf tipoUsuario = "Admin" Then
                        Response.Redirect("Admin/gestionUsuarios.aspx", True)
                    End If
                End If
                lblError.Visible = False
            Else
                lblError.Visible = True
            End If
        End If

    End Sub

End Class