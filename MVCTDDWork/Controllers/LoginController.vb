
Public Class LoginController : Inherits Controller

    Property Name As String

    Property Password As String

    Function Login() As ViewResult

        ViewData("Title") = "Login Page"
        Return View()

    End Function

    Function FormSubmit(name As String, pass As String) As ViewResult

        ViewData("Name") = "Username"
        ViewData("Welcome") = "Welcome"
        Return View("Welcome")

    End Function



End Class
