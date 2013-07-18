Imports System.Web.Mvc


<TestClass()>
Public Class LoginControllerTest

    <TestMethod()>
    Public Sub VerifyLoginControllerExists()

        Dim controller As New LoginController
        Dim result As ViewResult = controller.Login
        Assert.AreEqual("Login Page", result.ViewData("Title"))

    End Sub

    <TestMethod()>
    Public Sub FormSubmitTest()

        Dim controller As New LoginController
        controller.Name = "Username"
        controller.Password = "MyPass"

        Dim name = controller.Name
        Dim pass = controller.Password
        Dim result As ViewResult = controller.FormSubmit(name, pass)

        Assert.AreEqual("Username", result.ViewData("Name"))
        Assert.AreEqual("MyPass", pass)

    End Sub

End Class