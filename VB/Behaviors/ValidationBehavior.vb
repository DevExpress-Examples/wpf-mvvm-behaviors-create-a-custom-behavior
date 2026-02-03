Imports DevExpress.Mvvm.UI.Interactivity
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Media

Namespace Example.Behaviors

    Public Class ValidationBehavior
        Inherits Behavior(Of TextBox)

        Public Shared ReadOnly ValidForegroundProperty As DependencyProperty = DependencyProperty.Register("ValidForeground", GetType(Brush), GetType(ValidationBehavior), New PropertyMetadata(New SolidColorBrush(Colors.Black), Sub(d, e) CType(d, ValidationBehavior).Update()))

        Public Shared ReadOnly InvalidForegroundProperty As DependencyProperty = DependencyProperty.Register("InvalidForeground", GetType(Brush), GetType(ValidationBehavior), New PropertyMetadata(New SolidColorBrush(Colors.Red), Sub(d, e) CType(d, ValidationBehavior).Update()))

        Public Shared ReadOnly InvalidValueProperty As DependencyProperty = DependencyProperty.Register("InvalidValue", GetType(String), GetType(ValidationBehavior), New PropertyMetadata(String.Empty, Sub(d, e) CType(d, ValidationBehavior).Update()))

        Public Property ValidForeground As Brush
            Get
                Return CType(GetValue(ValidForegroundProperty), Brush)
            End Get

            Set(ByVal value As Brush)
                SetValue(ValidForegroundProperty, value)
            End Set
        End Property

        Public Property InvalidForeground As Brush
            Get
                Return CType(GetValue(InvalidForegroundProperty), Brush)
            End Get

            Set(ByVal value As Brush)
                SetValue(InvalidForegroundProperty, value)
            End Set
        End Property

        Public Property InvalidValue As String
            Get
                Return CStr(GetValue(InvalidValueProperty))
            End Get

            Set(ByVal value As String)
                SetValue(InvalidValueProperty, value)
            End Set
        End Property

        Protected Overrides Sub OnAttached()
            MyBase.OnAttached()
            AddHandler AssociatedObject.TextChanged, AddressOf OnAssociatedObjectTextChanged
            Update()
        End Sub

        Protected Overrides Sub OnDetaching()
            RemoveHandler AssociatedObject.TextChanged, AddressOf OnAssociatedObjectTextChanged
            MyBase.OnDetaching()
        End Sub

        Private Sub OnAssociatedObjectTextChanged(ByVal sender As Object, ByVal e As TextChangedEventArgs)
            Update()
        End Sub

        Private Sub Update()
            If AssociatedObject Is Nothing Then Return
            If Equals(AssociatedObject.Text, InvalidValue) Then
                AssociatedObject.Foreground = InvalidForeground
            Else
                AssociatedObject.Foreground = ValidForeground
            End If
        End Sub
    End Class
End Namespace
