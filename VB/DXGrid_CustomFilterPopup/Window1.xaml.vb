Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Data
Imports System.Windows.Markup
Imports DevExpress.Data.Filtering

Namespace DXGrid_CustomFilterPopup

    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = GridData.GetData()
        End Sub
    End Class

    Public Class GridData

        Shared Public Function GetData() As List(Of DataObject)
            Dim data As List(Of DataObject) = New List(Of DataObject)()
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
        Inherits MarkupExtension
        Implements IValueConverter

        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return Me
        End Function

'#Region "IValueConverter Members"
        Private Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As Globalization.CultureInfo) As Object Implements IValueConverter.Convert
            Dim op As BinaryOperator = TryCast(value, BinaryOperator)
            If ReferenceEquals(op, Nothing) Then Return Nothing
            Dim operandValue As OperandValue = TryCast(op.RightOperand, OperandValue)
            Return operandValue.Value
        End Function

        Private Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return New BinaryOperator("Index", System.Convert.ToInt32(value), BinaryOperatorType.Greater)
        End Function
'#End Region
    End Class
End Namespace
