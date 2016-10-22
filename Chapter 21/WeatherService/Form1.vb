Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Cursor = Cursors.WaitCursor
        Application.DoEvents()
        Dim client As New WeatherService.WeatherForecastSoapClient
        Dim forecast = client.GetWeatherByPlaceName("Santa Barbara")
        Label1.Text = "Forecast for " & forecast.PlaceName & vbCrLf &
            "(" & forecast.Latitude.ToString & " ," & forecast.Longitude.ToString & ")"
        PictureBox1.ImageLocation = forecast.Details(0).WeatherImage
        PictureBox2.ImageLocation = forecast.Details(1).WeatherImage
        PictureBox3.ImageLocation = forecast.Details(2).WeatherImage
        PictureBox4.ImageLocation = forecast.Details(3).WeatherImage
        PictureBox5.ImageLocation = forecast.Details(4).WeatherImage
        PictureBox6.ImageLocation = forecast.Details(5).WeatherImage

        lblMax1.Text = forecast.Details(0).MaxTemperatureF.ToString
        lblMax2.Text = forecast.Details(1).MaxTemperatureF.ToString
        lblMax3.Text = forecast.Details(2).MaxTemperatureF.ToString
        lblMax4.Text = forecast.Details(3).MaxTemperatureF.ToString
        lblMax5.Text = forecast.Details(4).MaxTemperatureF.ToString
        lblMAx6.Text = forecast.Details(5).MaxTemperatureF.ToString

        lblMin1.Text = forecast.Details(0).MinTemperatureF.ToString
        lblMin2.Text = forecast.Details(1).MinTemperatureF.ToString
        lblMin3.Text = forecast.Details(2).MinTemperatureF.ToString
        lblMin4.Text = forecast.Details(3).MinTemperatureF.ToString
        lblMin5.Text = forecast.Details(4).MinTemperatureF.ToString
        lblMin6.Text = forecast.Details(5).MinTemperatureF.ToString

        lblDate1.Text = forecast.Details(0).Day
        lblDate2.Text = forecast.Details(1).Day
        lblDate3.Text = forecast.Details(2).Day
        lblDate4.Text = forecast.Details(3).Day
        lblDate5.Text = forecast.Details(4).Day
        lblDate6.Text = forecast.Details(5).Day
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Cursor = Cursors.WaitCursor
        Application.DoEvents()
        Dim rq As System.Net.WebRequest = System.Net.WebRequest.Create("http://www.webservicex.net/WeatherForecast.asmx/GetWeatherByPlaceName?PlaceName=Santa Barbara")
        Dim rs As System.Net.WebResponse = rq.GetResponse
        Dim strm As IO.Stream = rs.GetResponseStream
        Dim rdr As New IO.StreamReader(strm, System.Text.Encoding.UTF8)
        Dim xmlData = rdr.ReadToEnd
        rdr.Close()
        strm.Close()
        Dim xml As XElement = XElement.Parse(xmlData)
        Dim ns As XNamespace = "http://www.webservicex.net"
        Label1.Text = "Forecast for " & xml.Descendants(ns + "PlaceName").Value & vbCrLf &
             "(" & xml.Descendants(ns + "Latitude").Value & " ," & xml.Descendants(ns + "Longitude").Value & ")"
        Dim day As Integer = 1
        For Each forecast In xml.Descendants(ns + "Details").Descendants(ns + "WeatherData")
            If forecast.Descendants.Count > 0 Then
                Me.Controls("lblDate" & day.ToString).Text = forecast.Descendants(ns + "Day").Value
                Me.Controls("lblMin" & day.ToString).Text = forecast.Descendants(ns + "MinTemperatureF").Value
                Me.Controls("lblMax" & day.ToString).Text = forecast.Descendants(ns + "MaxTemperatureF").Value
                CType(Me.Controls("PictureBox" & day.ToString), PictureBox).ImageLocation = forecast.Descendants(ns + "WeatherImage").Value
                day += 1
            End If
        Next
        Me.Cursor = Cursors.Default
    End Sub
End Class
