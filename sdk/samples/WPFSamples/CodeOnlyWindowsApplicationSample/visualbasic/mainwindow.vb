Imports System
Imports System.Runtime.CompilerServices
Imports System.Windows
Imports System.Windows.Controls

' MainWindow derives from Window to inherit the ability to show
' a window. Developers who derive from Window need to define both
' appearance and behavior in code. Appearance is set by filling the
' Window.Content property, while behavior is created by handling events,
' overriding methods, setting properties, and adding further custom
' behavior code.
' 
' NOTE: Since MainWindow is code-only (no markup) there is no need to
'       call the InitializeComponent method eg:
' 
'       Partial Public Class MainWindow
'          Inherits Window
'          Public Sub New()
'            Me.InitializeComponent()
'          End Sub
'       End Class
' 
'       InitializeComponent is a method that is generated by the 
'       compiler when markup exists to apply the MainWindow XAML to 
'       the actual MainWindow instance, eg to register event handlers. 
'       If XAML were used, this class would also need to be a partial 
'       class, to merge with the partial class definition that implements 
'       the InitializeComponent, method that's generated by the compiler.

Namespace CodeOnlyWindowsApplicationSample
    Public Class MainWindow
        Inherits Window

        Protected Overrides Sub OnInitialized(ByVal e As EventArgs)
            MyBase.OnInitialized(e)

            ' Create appearance
            Dim closeButton As New Button
            closeButton.Content = "Close"
            MyBase.Content = closeButton

            ' Define behavior
            AddHandler closeButton.Click, New RoutedEventHandler(AddressOf Me.closeButton_Click)

        End Sub

        Private Sub closeButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            MyBase.Close()
        End Sub

    End Class

End Namespace

