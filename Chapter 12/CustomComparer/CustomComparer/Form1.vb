Public Class frmCustomComparer
    Structure Person
        Dim Name As String
        Dim BDate As Date
        Dim EMail As String
    End Structure

    Private Sub TestComparers(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnComparerTest.Click
        Dim AList As New ArrayList
        Dim p As Person
        ' POPULATE COLLECTION
        p.Name = "C Person"
        p.EMail = "PersonC@sybex.com"
        p.BDate = #1/1/1961#
        ' ADD FIRST PERSON
        If Not AList.Contains(p) Then AList.Add(p)
        p.Name = "A Person"
        p.EMail = "PersonA@sybex.com"
        p.BDate = #3/23/1961#
        ' ADD SECOND PERSON
        If Not AList.Contains(p) Then AList.Add(p)
        p.Name = "B Person"
        p.EMail = "PersonB@sybex.com"
        p.BDate = #4/13/1961#
        ' ADD THIRD PERSON
        If Not AList.Contains(p) Then AList.Add(p)
        ' PRINT COLLECTION AS IS
        p.Name = "D Person"
        p.EMail = "PersonD@sybex.com"
        p.BDate = #6/2/1961#
        ' ADD FOURTH PERSON
        If Not AList.Contains(p) Then AList.Add(p)
        ' Now sort the collection in all possible ways
        Dim PEnum As IEnumerator
        PEnum = AList.GetEnumerator
        ListBox1.Items.Clear()
        ListBox1.Items.Add("Original Collection")
        While PEnum.MoveNext
            ListBox1.Items.Add(CType(PEnum.Current, Person).Name & _
                        vbTab & CType(PEnum.Current, Person).BDate)
        End While
        ' SORT BY NAME, THEN PRINT COLLECTION
        ListBox1.Items.Add(" ")
        ListBox1.Items.Add("Collection Sorted by Name")
        ' USE THE PersonNameComparer TO SORT ARRAYLIST BY NAME FIELD
        AList.Sort(New PersonNameComparer)
        PEnum = AList.GetEnumerator
        While PEnum.MoveNext
            ListBox1.Items.Add(CType(PEnum.Current, Person).Name & _
                        vbTab & CType(PEnum.Current, Person).BDate)
        End While
        ' SORT BY AGE, THEN PRINT COLLECTION
        ListBox1.Items.Add(" ")
        ListBox1.Items.Add("Collection Sorted by Age")
        ListBox1.Items.Add(" (younger to older)")
        ' USE THE PersonAgeComparer TO SORT ARRAYLIST BY BDATE FIELD
        AList.Sort(New PersonAgeComparer)
        PEnum = AList.GetEnumerator
        While PEnum.MoveNext
            ListBox1.Items.Add(CType(PEnum.Current, Person).Name & _
                        vbTab & CType(PEnum.Current, Person).BDate)
        End While

    End Sub

    ' This Class contains a single method, which is a function that
    ' implements the IComparer interface and compares two objects of the Person type.
    ' The comparison is based on the BDate field
    ' Notice that the two objects passed to the function are casted to the Person type,
    ' to make sure that they expose a BDate field. If not, the code will fail
    Class PersonAgeComparer : Implements IComparer
        Public Function Compare(ByVal o1 As Object, _
                                  ByVal o2 As Object) As Integer _
                                  Implements IComparer.Compare
            Dim person1, person2 As Person
            Try
                person1 = CType(o1, Person)
                person2 = CType(o2, Person)
            Catch compareException As System.Exception
                Throw (compareException)
                Exit Function
            End Try
            If person1.BDate > person2.BDate Then
                Return -1
            Else
                If person1.BDate < person2.BDate Then
                    Return 1
                Else
                    Return 0
                End If
            End If
        End Function
    End Class

    ' This Class contains a single method, which is a function that
    ' implements the IComparer interface and compares two objects of the Person type.
    ' The comparison is based on the Name field
    ' Notice that the two objects passed to the function are casted to the Person type,
    ' to make sure that they expose a Name field. If not, the code will fail

    Class PersonNameComparer : Implements IComparer
        Public Function Compare(ByVal o1 As Object, _
                                  ByVal o2 As Object) As Integer _
                                  Implements IComparer.Compare
            Dim person1, person2 As Person
            Try
                person1 = CType(o1, Person)
                person2 = CType(o2, Person)
            Catch compareException As System.Exception
                Throw (compareException)
                Exit Function
            End Try
            If person1.Name < person2.Name Then
                Return -1
            Else
                If person1.Name > person2.Name Then
                    Return 1
                Else
                    Return 0
                End If
            End If
        End Function
    End Class
End Class
