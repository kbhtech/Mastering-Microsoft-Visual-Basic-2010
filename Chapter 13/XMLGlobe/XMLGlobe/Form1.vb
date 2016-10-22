Public Class Form1

    Dim Globe As XElement
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim countries = <Countries>
                            <Country>
                                <Code>IT</Code>
                                <Description>Italy</Description>
                                <Cities>
                                    <City>
                                        <Code>ROM</Code>
                                        <Description>Rome</Description>
                                    </City>
                                    <City>
                                        <Code>FLR</Code>
                                        <Description>Florence</Description>
                                    </City>
                                </Cities>
                            </Country>
                            <Country>
                                <Code>DE</Code>
                                <Description>Germany</Description>
                                <Cities>
                                    <City>
                                        <Code>BRL</Code>
                                        <Description>Berlin</Description>
                                    </City>
                                    <City>
                                        <Code>MUN</Code>
                                        <Description>Munich</Description>
                                    </City>
                                    <City>
                                        <Code>FRN</Code>
                                        <Description>Frankfurt</Description>
                                    </City>
                                </Cities>
                            </Country>
                        </Countries>


        Globe = <Globe>
                    <Continents>
                        <Continent>
                            <Code>EU</Code>
                            <Description>Europe</Description>
                            <%= countries %>
                        </Continent>
                        <Continent>
                            <Code>NA</Code>
                            <Description>N. America</Description>
                            <Countries>
                                <Country>
                                    <Code>USA</Code>
                                    <Description>U.S.A.</Description>
                                    <States>
                                        <State>
                                            <Code>CA</Code>
                                            <Description>California</Description>
                                            <Cities>
                                                <City>
                                                    <Code>LAX</Code>
                                                    <Description>Los Angeles</Description>
                                                </City>
                                                <City>
                                                    <Code>SD</Code>
                                                    <Description>San Diego</Description>
                                                </City>
                                                <City>
                                                    <Code>SF</Code>
                                                    <Description>San Francisco</Description>
                                                </City>
                                            </Cities>
                                        </State>
                                        <State>
                                            <Code>NY</Code>
                                            <Description>New York</Description>
                                            <Cities>
                                                <City>
                                                    <Code>NYC</Code>
                                                    <Description>New York City</Description>
                                                </City>
                                                <City>
                                                    <Code>ALB</Code>
                                                    <Description>Albany</Description>
                                                </City>
                                            </Cities>
                                        </State>
                                    </States>
                                </Country>
                                <Country>
                                    <Code>MX</Code>
                                    <Description>Mexico</Description>
                                    <Cities>
                                        <City>
                                            <Code>MXC</Code>
                                            <Description>Mexico City</Description>
                                        </City>
                                        <City>
                                            <Code>TIJ</Code>
                                            <Description>Tijuana</Description>
                                        </City>
                                        <City>
                                            <Code>GDJ</Code>
                                            <Description>Guadalajara</Description>
                                        </City>
                                    </Cities>
                                </Country>
                            </Countries>
                        </Continent>
                    </Continents>
                </Globe>

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        For Each continent In Globe.Elements("Continents").Elements("Continent")
            TextBox1.AppendText(continent.Element("Description").Value & vbCrLf)
            For Each country In continent.Elements("Countries").Elements("Country")
                TextBox1.AppendText(vbTab & country.Element("Description").Value & vbCrLf)
                For Each city In country.Descendants("Cities").Elements("City")
                    TextBox1.AppendText(vbTab & vbTab & _
                                         city.Elements("Description").Value & vbCrLf)
                Next
            Next
        Next

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        For Each continent In Globe.Descendants("Continents").Descendants("Continent")
            TextBox1.AppendText(continent.Element("Description").Value & vbCrLf)
            For Each country In continent.Descendants("Country")
                TextBox1.AppendText(vbTab & country.Element("Description").Value & vbCrLf)
                If country.Descendants("States").Count = 0 Then
                    Dim CountryCities = country.Descendants("Cities")
                    For Each city In CountryCities.Descendants("City")
                        TextBox1.AppendText(vbTab & vbTab & _
                                             city.Elements("Description").Value & vbCrLf)
                    Next
                Else
                    For Each state In country.Descendants("State")
                        TextBox1.AppendText(vbTab & vbTab & _
                                             state.Element("Description").Value & vbCrLf)
                        Dim CountryCities = state.Descendants("Cities")
                        For Each city In CountryCities.Descendants("City")
                            TextBox1.AppendText(vbTab & vbTab & vbTab & _
                                                city.Elements("Description").Value & vbCrLf)
                        Next
                    Next
                End If
            Next
        Next

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim Spain =
                New XElement("Country",
                New XElement("Code", "ES"),
                New XElement("Description", "Spain"),
                New XElement("Cities",
                   New XElement("City",
                         New XElement("Code", "MAD"),
                         New XElement("Description", "Madrid"))), _
                   New XElement("City",
                         New XElement("Code", "BCN"),
                         New XElement("Description", "Barcelona")))

        Dim europe = Globe.Descendants("Continents").Elements("Continent").Where(Function(continent) continent.Element("Code").Value = "EU").First

        europe.Elements("Countries").First.Add(Spain)

        Globe.Descendants("Continents").Elements("Continent").Where(Function(continent) continent.Element("Code").Value = "EU").First.Add(
            New XElement("Country",
                  New XElement("Code", "FR"),
                  New XElement("Description", "France"),
                  New XElement("Cities",
                      New XElement("City",
                          New XElement("Code", "PAR"),
                          New XElement("Description", "Paris")),
                      New XElement("City",
                          New XElement("Code", "NIC"),
                          New XElement("Description", "Nice")))))
        TextBox1.AppendText("The Globe tree after the insertion of France and Spain nodes")
        TextBox1.AppendText(vbCrLf)
        TextBox1.AppendText(Globe.ToString)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim price1 As Decimal = 11.95
        Dim price2 As Decimal = 10.25
        Dim xDoc = <Books>
                       <Book ISBN="0000000000001">
                           <Price><%= price1 %></Price>
                           <Title>Book Title 1</Title>
                           <Stock InStock="12" OnOrder="24"/>
                       </Book>
                       <Book ISBN="0000000000002">
                           <Price><%= price2 %></Price>
                           <Title>Book Title 2</Title>
                           <Stock InStock="7" OnOrder="10"/>
                       </Book>
                   </Books>
        TextBox1.Clear()
        TextBox1.AppendText(xDoc.ToString)
        TextBox1.AppendText(vbCrLf)
        For Each book In xDoc.Elements("Book")
            TextBox1.AppendText("ISBN " & book.Attribute("ISBN").Value.ToString & vbCrLf)
            TextBox1.AppendText("   Title: " & book.Element("Title").Value.ToString & vbCrLf)
            TextBox1.AppendText("   Price: " & book.Element("Price").Value.ToString & vbCrLf)
            Dim stock = book.Element("Stock")
            TextBox1.AppendText("      Books in stock " & stock.Attribute("InStock").Value & vbCrLf)
            TextBox1.AppendText("      Books on order " & stock.Attribute("OnOrder").Value & vbCrLf)
        Next

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim loanAmount As Decimal = 135000
        Dim loanInterest As Decimal = 8.75
        Dim loanDuration = 6
        Dim loanXML = <Loan>
                          <Amount><%= loanAmount %></Amount>
                          <Duration><%= loanDuration %>6</Duration>
                          <DurationUnit>Years</DurationUnit>
                          <Interest><%= loanInterest %></Interest>
                          <Payment><%= Financial.Pmt(loanInterest / 10 * 12, _
                                       loanDuration * 12, loanAmount) %></Payment>
                      </Loan>
        TextBox1.Text = loanXML.ToString
    End Sub
End Class
