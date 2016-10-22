Imports System.Data.Services
Imports System.Linq
Imports System.ServiceModel.Web
Imports System.Linq.Expressions

Public Class NWWebDataService
    ' TODO: replace [[class name]] with your data class name
    Inherits DataService(Of NorthwindEntities)

    ' This method is called only once to initialize service-wide policies.
    Public Shared Sub InitializeService(ByVal config As IDataServiceConfiguration)
        ' TODO: set rules to indicate which entity sets and service operations are visible, updatable, etc.
        ' Examples:
        config.SetEntitySetAccessRule("*", EntitySetRights.All)
        'config.SetEntitySetAccessRule("Orders", EntitySetRights.AllRead Or EntitySetRights.WriteAppend Or EntitySetRights.WriteReplace)
        config.SetServiceOperationAccessRule("*", ServiceOperationRights.All)
    End Sub

    '<QueryInterceptor("Orders")> _
    'Public Function OnQueryOrders() As Expression(Of Func(Of Order, Boolean))
    '    Return Function(o) o.Customer.ContactName.Contains("antonio")  '  = HttpContext.Current.User.Identity.Name
    'End Function
    '<QueryInterceptor("Orders")> Public Function InterceptOrders(ByVal inQuery As IQueryable(Of Order)) As IQueryable(Of Order)
    '    Return inQuery
    'End Function
    ' ' = httpcontext.current.user.identity.name()


End Class
