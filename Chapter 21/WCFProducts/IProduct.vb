Imports System.ServiceModel

<ServiceContract()>
        Public Interface IProduct
    <OperationContract()> Function GetAllCategories() As List(Of Product.Category)
    <OperationContract()> Function GetAllProducts() As List(Of Product)
    <OperationContract()> Function AddProduct(ByVal prod As Product) As Product
    <OperationContract()> Function RemoveProduct(ByVal ID As Integer) As Boolean
    <OperationContract()> Function GetCategoryProducts(ByVal ID As Integer) As List(Of Product)

End Interface
