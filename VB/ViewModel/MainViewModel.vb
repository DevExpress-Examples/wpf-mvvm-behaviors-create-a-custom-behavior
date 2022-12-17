Imports DevExpress.Mvvm.DataAnnotations
Imports System.Windows.Media

Namespace Example.ViewModel

    <POCOViewModel>
    Public Class MainViewModel

        Public Overridable Property InvalidValue As String

        Public Overridable Property ValidBrush As Brush

        Public Overridable Property InvalidBrush As Brush

        Public Sub SetRedValidBrush()
            ValidBrush = New SolidColorBrush(Colors.Red)
        End Sub

        Public Sub SetBlueValidBrush()
            ValidBrush = New SolidColorBrush(Colors.Blue)
        End Sub

        Public Sub SetBlackValidBrush()
            ValidBrush = New SolidColorBrush(Colors.Black)
        End Sub

        Public Sub SetRedInvalidBrush()
            InvalidBrush = New SolidColorBrush(Colors.Red)
        End Sub

        Public Sub SetBlueInvalidBrush()
            InvalidBrush = New SolidColorBrush(Colors.Blue)
        End Sub

        Public Sub SetBlackInvalidBrush()
            InvalidBrush = New SolidColorBrush(Colors.Black)
        End Sub

        Public Sub New()
            InvalidValue = "Error"
            SetBlackValidBrush()
            SetRedInvalidBrush()
        End Sub
    End Class
End Namespace
