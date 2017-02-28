Public Class Form1

    Public Sub New()
        Dim text As String = System.IO.File.ReadAllText("svg.svg")
        InitializeComponent()
        WebBrowser1.DocumentText = text
    End Sub

End Class
