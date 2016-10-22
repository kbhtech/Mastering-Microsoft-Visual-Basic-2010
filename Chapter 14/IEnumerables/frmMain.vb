Public Class frmMain

    Dim ArrayOfPersons() = {New With {.SSN = "555-00-9001", .First = "Peter", .Last = "Evans", .Age = 27},
                         New With {.SSN = "555-00-9002", .First = "James", .Last = "Dobs", .Age = 42},
                         New With {.SSN = "555-00-9003", .First = "Richard", .Last = "Manning", .Age = 33},
                         New With {.SSN = "555-00-9004", .First = "Rob", .Last = "Johnson", .Age = 52},
                         New With {.SSN = "555-00-9005", .First = "Peter", .Last = "Smith", .Age = 38},
                         New With {.SSN = "555-00-9006", .First = "John", .Last = "Tall", .Age = 22},
                         New With {.SSN = "555-00-9007", .First = "Mike", .Last = "Johnson", .Age = 33},
                         New With {.SSN = "555-00-9008", .First = "Peter", .Last = "Larson", .Age = 43},
                         New With {.SSN = "555-00-9009", .First = "James", .Last = "Smith", .Age = 37}}

    Dim PersonsCollection As Collection = New Collection From {
                     New With {.SSN = "555-00-9001", .First = "Peter", .Last = "Evans", .Age = 27},
                     New With {.SSN = "555-00-9002", .First = "James", .Last = "Dobs", .Age = 42},
                     New With {.SSN = "555-00-9003", .First = "Richard", .Last = "Manning", .Age = 33},
                     New With {.SSN = "555-00-9004", .First = "Rob", .Last = "Johnson", .Age = 52},
                     New With {.SSN = "555-00-9005", .First = "Peter", .Last = "Smith", .Age = 38},
                     New With {.SSN = "555-00-9006", .First = "John", .Last = "Tall", .Age = 22},
                     New With {.SSN = "555-00-9007", .First = "Mike", .Last = "Johnson", .Age = 33},
                     New With {.SSN = "555-00-9008", .First = "Peter", .Last = "Larson", .Age = 43},
                     New With {.SSN = "555-00-9009", .First = "James", .Last = "Smith", .Age = 37}}

    Dim XmlPersons As XElement = <Persons>
                                     <Person>
                                         <SSN>555-00-9001</SSN>
                                         <First>Peter</First>
                                         <Last>Evans</Last>
                                         <Age>27</Age>
                                     </Person>
                                     <Person>
                                         <SSN>555-00-9002</SSN>
                                         <First>James</First>
                                         <Last>Dobs</Last>
                                         <Age>42</Age>
                                     </Person>
                                     <Person>
                                         <SSN>555-00-9003</SSN>
                                         <First>Richard</First>
                                         <Last>Manning</Last>
                                         <Age>33</Age>
                                     </Person>
                                     <Person>
                                         <SSN>555-00-9004</SSN>
                                         <First>Rob</First>
                                         <Last>Johnson</Last>
                                         <Age>52</Age>
                                     </Person>
                                     <Person>
                                         <SSN>555-00-9005</SSN>
                                         <First>Peter</First>
                                         <Last>Smith</Last>
                                         <Age>38</Age>
                                     </Person>
                                     <Person>
                                         <SSN>555-00-9006</SSN>
                                         <First>John</First>
                                         <Last>Tall</Last>
                                         <Age>22</Age>
                                     </Person>
                                     <Person>
                                         <SSN>555-00-9007</SSN>
                                         <First>Mike</First>
                                         <Last>Johnson</Last>
                                         <Age>33</Age>
                                     </Person>
                                     <Person>
                                         <SSN>555-00-9008</SSN>
                                         <First>Peter</First>
                                         <Last>Larson</Last>
                                         <Age>43</Age>
                                     </Person>
                                     <Person>
                                         <SSN>555-00-9009</SSN>
                                         <First>James</First>
                                         <Last>Smith</Last>
                                         <Age>37</Age>
                                     </Person>
                                 </Persons>

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnPersons.Click
        TextBox1.Clear()
        TextBox1.AppendText("The average age in the collection is " &
                            ArrayOfPersons.Average(Function(p) p.Age).ToString("#.00") & vbCrLf)
        TextBox1.AppendText("The minimum age in the collection is " &
                            ArrayOfPersons.Min(Function(p) p.Age).ToString & vbCrLf)
        TextBox1.AppendText("The maximum age in the collection is " &
                            ArrayOfPersons.Max(Function(p) p.Age).ToString & vbCrLf)

        ' young persons
        Dim youngPersons = From p In ArrayOfPersons Where p.Age < 30 Select p
        TextBox1.AppendText("There are " & youngPersons.Count.ToString & " young persons in collection" & vbCrLf)
        ' not so young persons
        Dim notSoYoungPersons = From p In ArrayOfPersons Where p.Age >= 30 Select p
        TextBox1.AppendText("There are " & notSoYoungPersons.Count.ToString & " not so young persons in collection" & vbCrLf)
        ' combine young and not so young persons
        Dim allPersons = youngPersons.Concat(notSoYoungPersons)
        TextBox1.AppendText("There are " & allPersons.Count.ToString & " persons in new collection" & vbCrLf)
        ' An alternate method of calculating the average age person"
        ' TextBox1.AppendText("The average person age is: " & persons.Sum(Function(p) p.Age) / persons.Count(Function(p) p.Age) & vbCrLf)
        TextBox1.AppendText(vbCrLf)
        TextBox1.AppendText(vbCrLf)
        ' group persons by age
        Dim grouped = ArrayOfPersons.GroupBy(Function(p) Math.Floor(p.Age / 10) * 10)
        ' sort the list of groups

        grouped = From grp In grouped
                  Order By grp.Key
                  Select grp
        ' and print the groups and their counts
        For Each grp In grouped
            TextBox1.AppendText("Group: " & grp.Key & " contains " & grp.Count.ToString & " persons" & vbCrLf)
        Next

        ' print each group's header (age group)
        TextBox1.AppendText(vbCrLf)
        TextBox1.AppendText("GROUPS AND THEIR MEMBERS" & vbCrLf)
        For Each group In grouped
            TextBox1.AppendText("GROUP OF " & group.Key.ToString & vbCrLf)
            TextBox1.AppendText("Group Members:" & vbCrLf)
            ' and the members in each age group sorted by age
            For Each person In group.OrderBy(Function(p) p.Age)
                TextBox1.AppendText(vbTab & person.First & " " & person.Last & " : " & person.Age.ToString & vbCrLf)
            Next
        Next

        ' an alternate method of grouping persons according to age
        ' First create a new anonymous type with the same fields as the Person type
        ' and add a field that corresponds to the age group
        Dim tmpGroups = From person In ArrayOfPersons
                      Select New With {.SSN = person.SSN, .First = person.First, .Last = person.Last, .Age = person.Age,
                                          .ageGroup = Math.Floor(person.Age / 10) * 10}

        ' and now group persons by age
        Dim ageGroups = From P In tmpGroups
                    Order By P.ageGroup
                    Group By P.ageGroup Into G = Group, AgeGroupCount = Count(),
                        ageGroupAverage = Average(System.Convert.ToDecimal(P.Age))

        ' print the age groups
        TextBox1.AppendText("AGE GROUPS" & vbCrLf)
        For Each grp In ageGroups
            TextBox1.AppendText("AGE GROUP: " & grp.ageGroup.ToString & vbTab &
                                "COUNT: " & grp.AgeGroupCount.ToString & vbTab &
                                "AVERAGE AGE IN GROUP: " & grp.ageGroupAverage.ToString("#.00") & vbCrLf)
        Next


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim allBooks As New List(Of Books.Book)

        allBooks.Add(New Books.Book With {.ISBN = "1000000100", .Title = "Book 100", .Publisher = "Wiley",
                           .Stock = New Books.Stock With {.InStock = 14, .OnOrder = 20},
                           .Authors = {New Books.Author With {.FirstName = "Richard", .LastName = "Dobson"}},
                           .Price = New Books.Prices With {.StorePrice = 12.95, .RetailPrice = 15.95}})


        allBooks.Add(New Books.Book With {.ISBN = "1000000101", .Title = "Book 101", .Publisher = "Sybex",
                   .Stock = New Books.Stock With {.InStock = 8, .OnOrder = 25},
                   .Authors = {New Books.Author With {.FirstName = "Bob", .LastName = "Smith"}},
                   .Price = New Books.Prices With {.StorePrice = 24.95, .RetailPrice = 29.99}})

        allBooks.Add(New Books.Book With {.ISBN = "1000000101", .Title = "Book 101", .Publisher = "Sybex",
                   .Stock = New Books.Stock With {.InStock = 8, .OnOrder = 25},
                   .Authors = {New Books.Author With {.LastName = "Mike", .FirstName = "Sonders"},
                                         New Books.Author With {.LastName = "Emilia", .FirstName = "Tramp"}},
                   .Price = New Books.Prices With {.StorePrice = 24.95, .RetailPrice = 29.99}})

        Dim bookAuthors() As Books.Author = {New Books.Author With {.LastName = "Mike", .FirstName = "Tyler"},
                                         New Books.Author With {.LastName = "Jack", .FirstName = "Simpson"},
                                         New Books.Author With {.LastName = "Margot", .FirstName = "Stapp"}}
        allBooks.Add(New Books.Book With {.ISBN = "1000000102", .Title = "Book 102", .Publisher = "Sybex",
                   .Stock = New Books.Stock With {.InStock = 2, .OnOrder = 35},
                   .Price = New Books.Prices With {.StorePrice = 14.95, .RetailPrice = 29.99},
                   .Authors = bookAuthors})

        Dim allAuthors = From bk In allBooks
                         Where bk.Authors IsNot Nothing
                         Select bk.Authors

        Dim Q = From bk In allBooks
                Select New With {.ISBN = bk.ISBN,
                                 .AuthorCount = bk.Authors.Length.ToString & IIf(bk.Authors.Count = 1, " Author", " Authors")}

        Dim AuthorCount = From bk In allBooks
              Select New With {.ISBN = bk.ISBN,
                               .AuthorCount = IIf(bk.Authors Is Nothing, "no", bk.Authors.Count.ToString)}

        Dim QQ = From bk In allBooks
               Select New With {.ISBN = bk.ISBN,
                                .AuthorCount = Convert.ToString(IIf(bk.Authors Is Nothing, " no authors",
                                bk.Authors.Length.ToString & IIf(bk.Authors.Count = 1, " Author", " Authors")))}

        Dim html = <html>
                       <h2>List of Books</h2>
                       <table border="all">
                           <tr>
                               <td margin="10" width="90px">ISBN</td><td margin="10" width="280px">Title</td><td margin="10" width="140px">Author(s)</td><td margin="10" width="70px">Price</td>
                           </tr>
                           <%= From bk As Books.Book In allBooks
                               Select <tr>
                                          <td><%= bk.ISBN %></td>
                                          <td><%= bk.Title %></td>
                                          <td><table><%= From au As Books.Author In bk.Authors Order By au.LastName, au.FirstName
                                                         Select <tr><td><%= au.LastName & ", " & au.FirstName %></td></tr> %></table></td>
                                          <td align="right" valign="middle"><%= bk.Price.RetailPrice.ToString %></td>

                                      </tr>
                           %>
                       </table>
                   </html>
        html.Save("Books.html")
        Process.Start("Books.html")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' create an HTML document with the persons
        Dim html = <html>
                       <h3>List of Contacts</h3>
                       <table>
                           <tr><td><b>Name</b></td><td><b>SSN</b></td><td><b>Age</b></td></tr>
                           <%= From p In ArrayOfPersons _
                               Select <tr>
                                          <td><b><%= p.Last %></b></td>
                                          <td><%= p.SSN %></td>
                                          <td align="right"><%= p.Age %></td>
                                      </tr> %>
                       </table>
                   </html>


        html.Save("contacts.htm")
        Process.Start("contacts.htm")
    End Sub

    ' This subroutine doesn't correspond to any button, but it demonstrates
    ' how to use a Books class that stores its authors to a List(Of Author) objects
    ' The code uses the Books1 class to represent books, which differs from the Books class
    ' in that the Authors property is a List(of Author), instead of an array of Author objects.
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim allBooks As New List(Of Books1.Book)
        allBooks.Add(New Books1.Book With {.ISBN = "1000000100", .Title = "Book 100", .Publisher = "Wiley",
                     .Stock = New Books1.Stock With {.InStock = 14, .OnOrder = 20},
                     .Authors = New List(Of Books1.Author)(
                         {New Books1.Author With {.FirstName = "Richard", .LastName = "Dobson"}}),
                     .Price = New Books1.Prices With {.StorePrice = 12.95, .RetailPrice = 15.95},
                     .PublicationDate = #2/11/1993#})
        allBooks.Add(New Books1.Book With {.ISBN = "1000000101", .Title = "Book 101", .Publisher = "Sybex",
                   .Stock = New Books1.Stock With {.InStock = 8, .OnOrder = 25},
                   .Authors = New List(Of Books1.Author),
                   .Price = New Books1.Prices With {.StorePrice = 24.95, .RetailPrice = 29.99},
                   .PublicationDate = #4/18/2001#})
        allBooks.Add(New Books1.Book With {.ISBN = "1000000101", .Title = "Book 101", .Publisher = "Sybex",
                   .Stock = New Books1.Stock With {.InStock = 8, .OnOrder = 25},
                   .Authors = New List(Of Books1.Author)(
                       {New Books1.Author With {.LastName = "Mike", .FirstName = "Sonders"},
                        New Books1.Author With {.LastName = "Emilia", .FirstName = "Tramp"}}),
                   .Price = New Books1.Prices With {.StorePrice = 24.95, .RetailPrice = 29.99},
                   .PublicationDate = #9/22/2008#})

        Dim bookAuthors As New List(Of Books1.Author)({New Books1.Author With {.LastName = "Mike", .FirstName = "Tyler"},
                                         New Books1.Author With {.LastName = "Jack", .FirstName = "Simpson"},
                                         New Books1.Author With {.LastName = "Margot", .FirstName = "Stapp"}})
        allBooks.Add(New Books1.Book With {.ISBN = "1000000102", .Title = "Book 102", .Publisher = "Sybex",
                   .Stock = New Books1.Stock With {.InStock = 2, .OnOrder = 35},
                   .Price = New Books1.Prices With {.StorePrice = 14.95, .RetailPrice = 29.99},
                   .Authors = bookAuthors,
                   .PublicationDate = #1/10/2000#})

        Dim BooksWithAuthorCount = From bk In allBooks
              Select New With {.ISBN = bk.ISBN,
                               .AuthorCount = Convert.ToString(IIf(bk.Authors.Count = 0, " no authors",
                               bk.Authors.Count.ToString & IIf(bk.Authors.Count = 1, " Author", " Authors")))}
        TextBox1.AppendText("Books with Author Count" & vbCrLf)
        For Each bk In BooksWithAuthorCount
            TextBox1.AppendText(bk.ISBN & vbTab & bk.AuthorCount & vbCrLf)
        Next
        TextBox1.AppendText(vbCrLf)
        Dim BooksWithAuthors = From bk In allBooks
              Select New With {.ISBN = bk.ISBN, .Title = bk.Title, .Price = bk.Price.RetailPrice.ToString,
                               .BooksInStock = bk.Stock.InStock & "/" & bk.Stock.OnOrder,
                               .AuthorCount = IIf(bk.Authors Is Nothing, "Book has no authors", bk.Authors.Count.ToString),
                               .BookAuthors =
                                        From au In bk.Authors
                                        Select New With {.BookAuthorName = au.LastName & ", " & au.FirstName}
                               }

        TextBox1.AppendText("Books with Authors" & vbCrLf)

        For Each itm In BooksWithAuthors
            TextBox1.AppendText(itm.ISBN & vbTab & itm.Title & vbTab & itm.Price.ToString & vbTab & itm.BooksInStock & vbCrLf)
            If itm.BookAuthors.Count = 0 Then
                TextBox1.AppendText(vbTab & "There are no authors for this book" & vbCrLf)
            Else
                TextBox1.AppendText(vbTab & "Book author(s)" & vbCrLf)
                For Each au In itm.BookAuthors
                    TextBox1.AppendText(vbTab & au.BookAuthorName & vbCrLf)
                Next
            End If
        Next

        Dim html = <html>
                       <h2>List of Books</h2>
                       <table border="all">
                           <tr>
                               <td margin="10" width="90px">ISBN</td><td margin="10" width="280px">Title</td><td margin="10" width="140px">Author(s)</td><td margin="10" width="70px">Price</td>
                           </tr>
                           <%= From bk As Books1.Book In allBooks
                               Select <tr>
                                          <td><%= bk.ISBN %></td>
                                          <td><%= bk.Title %></td>
                                          <td><table><%= From au As Books1.Author In bk.Authors Order By au.LastName, au.FirstName
                                                         Select <tr><td><%= au.LastName & ", " & au.FirstName %></td></tr> %></table></td>
                                          <td align="right" valign="middle"><%= bk.Price.RetailPrice.ToString %></td>

                                      </tr>
                           %>
                       </table>
                   </html>
    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Persons = From p In XmlPersons.Descendants("Person")
                      Select New With {
                          .SSN = p.Element("SSN"),
                          .Name = New With {.NameLast = p.Element("Last"),
                                            .NameFirst = p.Element("First")},
                          .Age = p.Element("Age").Value}

        Dim youngPersons = From p In Persons
                          Where p.Age < 40
                          Select New With {.Name = p.Name.NameFirst.Value & " " & p.Name.NameLast.Value}

        TextBox1.Clear()
        TextBox1.AppendText("Distinct Names" & vbCrLf)
        For Each p In youngPersons
            TextBox1.AppendText(vbTab & p.Name & vbCrLf)
        Next

        ' Note the use of the successive operators for grouping and sorting 
        Dim grouped = (ArrayOfPersons.GroupBy(Function(p) Math.Floor(p.Age / 10) * 10)).OrderBy(Function(p) p.Key)
        TextBox1.AppendText(vbCrLf)
        TextBox1.AppendText("GROUPS AND THEIR MEMBERS" & vbCrLf)
        For Each group In grouped
            TextBox1.AppendText("GROUP OF " & group.Key.ToString & vbCrLf)
            TextBox1.AppendText("Group Members:" & vbCrLf)
            ' and the members in each age group sorted by age
            For Each person In group.OrderBy(Function(p) p.Age)
                TextBox1.AppendText(vbTab & person.First & " " & person.Last & " : " & person.Age.ToString & vbCrLf)
            Next
        Next
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim numbers = {1.01, 31.93, 8.12, 5.05, 21.81, 17.33, 2.45}
        Dim sumOfSquares = numbers.Sum(Function(n) n ^ 2)
        TextBox1.Clear()
        TextBox1.AppendText("The sum of squares is: " & sumOfSquares.ToString & vbCrLf)

        Dim sumOfLogarithms = numbers.Sum(Function(n) Math.Log(n))
        TextBox1.AppendText("The sum of logarithms is: " & sumOfLogarithms.ToString & vbCrLf)

        Dim averageOfLogarithms = numbers.Average(Function(n) Math.Log(n))
        TextBox1.AppendText("The average of logarithms is: " & averageOfLogarithms.ToString & vbCrLf)
        Dim points() = {New PointF(2.15, 9.75), New PointF(43.11, -3.1), New PointF(19.1, 4.2)}

        Dim words() = "The quick brown fox jumped over the lazy dog".Split(" "c)
    End Sub
End Class
