Imports Microsoft.VisualBasic
Imports DevExpress.Mvvm
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Text
Imports System.Threading.Tasks

Namespace WpfApplication1
	Public Class SampleGalleryViewModel
        Public Overridable Property Groups() As ObservableCollection(Of GroupViewModel)
        Public Sub New()
			Groups = New ObservableCollection(Of GroupViewModel)()
			InitGroups()
		End Sub
		Private Sub InitGroups()
			For i As Integer = 0 To 9
				Groups.Add(New GroupViewModel() With {.Caption = String.Format("Group {0}", i)})
			Next i
		End Sub
	End Class
	Public Class GroupViewModel
		Inherits ViewModelBase
        Public Overridable Property Caption() As String	
        Public Overridable Property Items() As ObservableCollection(Of ItemViewModel)
		Public Sub New()
			Items = New ObservableCollection(Of ItemViewModel)()
			InitItems()
		End Sub
		Private Sub InitItems()
			For i As Integer = 0 To 2
				Items.Add(New ItemViewModel() With {.Caption = String.Format("Item {0}", i)})
			Next i
		End Sub
	End Class
	Public Class ItemViewModel
        Public Overridable Property Caption() As String
	End Class
End Namespace
