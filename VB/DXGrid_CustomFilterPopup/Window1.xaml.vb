Imports DevExpress.Data.Filtering
Imports System
Imports System.Collections.ObjectModel
Imports System.Windows
Imports System.Windows.Data

Namespace DXGrid_CustomFilterPopup

    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = GridData.GetData()
        End Sub
    End Class

    Public Class GridData

        Shared Public Function GetData() As ObservableCollection(Of DataObject)
            Dim data As ObservableCollection(Of DataObject) = New ObservableCollection(Of DataObject)()
            For i As Integer = 0 To 100 - 1
                data.Add(New DataObject() With {.Index = i})
            Next

            Return data
        End Function
    End Class

    Public Class DataObject

        Public Property Index As Integer
    End Class

    Public Class IntToCriteriaOperatorConverter
        Implements IValueConverter

        Private Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As Globalization.CultureInfo) As Object Implements IValueConverter.Convert
            Dim binaryOperator As BinaryOperator = TryCast(value, BinaryOperator)
            If ReferenceEquals(binaryOperator, Nothing) Then Return Nothing
            Dim operandValue As OperandValue = TryCast(binaryOperator.RightOperand, OperandValue)
            Return operandValue.Value
        End Function

        Private Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return New BinaryOperator("Index", System.Convert.ToInt32(value), BinaryOperatorType.GreaterOrEqual)
        End Function
    End Class
End Namespace
