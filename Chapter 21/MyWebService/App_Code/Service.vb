Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://mywebservice.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class Service
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function ServerTime() As String
        ServerTime = Left(Now.TimeOfDay().ToString(), 8)
    End Function
    <WebMethod()>
        Public Function CalculatePercentage(
               ByVal myTotal As Integer, ByVal myValue As Integer) As Integer
        CalculatePercentage = CInt(myValue * 100 / myTotal)
    End Function


End Class