Imports System.Data.Services
Imports System.Linq
Imports System.ServiceModel.Web

Public Class WebDataService1
    ' TODO: replace [[class name]] with your data class name
    Inherits DataService(Of NorthwindEntities)

    ' This method is called only once to initialize service-wide policies.
    Public Shared Sub InitializeService(ByVal config As IDataServiceConfiguration)
        ' TODO: set rules to indicate which entity sets and service operations are visible, updatable, etc.
        ' Examples:
        config.SetEntitySetAccessRule("*", EntitySetRights.AllRead)
        config.SetServiceOperationAccessRule("*", ServiceOperationRights.All)
    End Sub

End Class
