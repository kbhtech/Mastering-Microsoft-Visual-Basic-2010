Imports System.Net
Imports System.IO
Imports System.Linq
Imports System.Xml.Linq
Imports <xmlns="urn:yahoo:maps">
Imports System.Collections.Specialized


Public Class Form1
    'Yahoo geocode id: BPdn3S7V34GMfMZ5ukBuHAMYujAPFGN10xYiHINOslptpcZsrgFbzsTHKr8HgBk7EA81QRe_

    'If this Yahoo App ID does not work, replace with your Id obtained from:
    'http://developer.yahoo.com/maps/rest/V1/geocode.html (follow "Get an App ID" link)
    Private Shared YahooAppId As String = "BPdn3S7V34GMfMZ5ukBuHAMYuj" &
                        "APFGN10xYiHINOslptpcZsrgFbzsTHKr8HgBk7EA81QRe_"

    Private Shared YahooGeocodeServiceUrl = "http://local.yahooapis.com" &
                                            "/MapsService/V1/geocode"

    Private Shared googleMapsHtmlTemplate As String

    Private Shared applicationDirectory = My.Application.Info.DirectoryPath.ToString()

    Private Shared googleMapsHtmlTemplatePath = applicationDirectory & "\gmapsTemplate.html"

    Private googleMapsHtml As String

    Private addressLocation As Coordinates

    Private yahooResponse As XDocument

    Dim yahooGeoCodeParameters As NameValueCollection

    Public Sub New()

        InitializeComponent()
        googleMapsHtmlTemplate = My.Computer.FileSystem.ReadAllText(
                 googleMapsHtmlTemplatePath)
        Console.WriteLine(googleMapsHtmlTemplate)
    End Sub

    Private Sub bttnShow_Click(ByVal sender As System.Object,
            ByVal e As System.EventArgs) Handles
            bttnShow.Click, txtZip.Leave

        lblError.Text = ""
        GenerateYahooGeoCodeParameters(txtStreet.Text.Trim(), txtCity.Text.Trim(),
                                txtState.Text.Trim(), txtZip.Text.Trim())
        FindLocation()
    End Sub

    Private Sub GenerateYahooGeoCodeParameters(ByVal street As String,
            ByVal city As String, ByVal state As String,
            ByVal zip As String)

        yahooGeoCodeParameters = New NameValueCollection
        yahooGeoCodeParameters.Add("appid", YahooAppId)
        yahooGeoCodeParameters.Add("street", street.Replace(" "c, "+"c))
        yahooGeoCodeParameters.Add("city", city.Replace(" "c, "+"c))
        yahooGeoCodeParameters.Add("zip", zip)
        yahooGeoCodeParameters.Add("state", state)
    End Sub

    Private Sub FindLocation()
        Dim client As New WebClient()
        client.QueryString = yahooGeoCodeParameters
        AddHandler client.DownloadStringCompleted,
            AddressOf webClient_DownloadStringCompleted
        client.DownloadStringAsync(New Uri(YahooGeocodeServiceUrl))
    End Sub

    Sub webClient_DownloadStringCompleted(ByVal sender As Object,
        ByVal e As DownloadStringCompletedEventArgs)

        If e.Error IsNot Nothing Then
            lblError.Text = "Address could not be located on a map"
            Return
        End If
        yahooResponse = XDocument.Parse(CStr(e.Result))
        ValidateResponseAndProceede()
    End Sub

    Private Sub ValidateResponseAndProceede()
        If (yahooResponse...<Result>.Count = 0) Then
            lblError.Text = "Address could not be located on a map"
            Return
        End If
        If (yahooResponse...<Result>.Count > 1) Then
            lblError.Text = "Multiple locations found - showing first." &
                " Correct the address and press Refresh"
        End If
        GenerateLocation()
        ShowLocationOnMap()
    End Sub

    Private Sub GenerateLocation()
        addressLocation.Latitude = yahooResponse...<Result>.First.<Latitude>.Value
        addressLocation.Longitude = yahooResponse...<Result>.First.<Longitude>.Value
    End Sub

    Private Sub ShowLocationOnMap()
        GenerateMapsHtml()
        mapBrowser.DocumentText = googleMapsHtml
    End Sub

    Private Sub GenerateMapsHtml()
        googleMapsHtml = googleMapsHtmlTemplate.
            Replace("replace_me_latitude", addressLocation.Latitude).
            Replace("replace_me_longitude", addressLocation.Longitude)
    End Sub

    Private Sub bttnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSave.Click
        MsgBox("Does nothing yet!")
    End Sub
End Class