<DataContract()>
Public Class Product
    <DataMember()> Public ProductID As Integer
    <DataMember()> Public ProductName As String
    <DataMember()> Public ProductPrice As Decimal
    <DataMember()> Public ProductCategoryID As Integer

    Public Overrides Function ToString() As String
        Return ProductName & " (" & ProductID & ")"
    End Function

    <DataContract()> Public Class Category
        <DataMember()> Public CategoryID As Integer
        <DataMember()> Public CategoryName As String
        Public Overrides Function ToString() As String
            Return CategoryName & " (" & CategoryID.ToString & ")"
        End Function
    End Class
End Class