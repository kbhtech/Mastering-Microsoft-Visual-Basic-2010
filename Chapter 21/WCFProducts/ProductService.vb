<ServiceBehavior()> Public Class ProductService : Implements IProduct

    Shared _products As New List(Of Product)
    Shared _categories As New List(Of Product.Category)

    Public Function AddProduct(ByVal prod As Product) As Product Implements IProduct.AddProduct
        ' grab the next ID in _products list
        prod.ProductID = (From p In _products Select p.ProductID Order By ProductID Descending).FirstOrDefault + 1
        ' If category field is not set to a valid category, ignore setting
        If (From c In _categories Where c.CategoryID = prod.ProductCategoryID).Count = 0 Then
            prod.ProductCategoryID = Nothing
        End If
        _products.Add(prod)
        Return prod
    End Function

    Public Function GetAllCategories() As System.Collections.Generic.List(Of Product.Category) Implements IProduct.GetAllCategories
        Return _categories
    End Function

    Public Function GetAllProducts() As System.Collections.Generic.List(Of Product) Implements IProduct.GetAllProducts
        Return _products
    End Function

    Public Function RemoveProduct(ByVal ID As Integer) As Boolean Implements IProduct.RemoveProduct
        ' _products.Remove((From p In _products Where p.ProductID = ID Select p).FirstOrDefault)
        _products.Remove(_products.Find(Function(p) p.ProductID = ID))
    End Function

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Public Function GetCategoryProduct(ByVal categoryID As Integer) As List(Of Product) Implements IProduct.GetCategoryProducts
        Return (From p In _products Where p.ProductCategoryID = categoryID).ToList
    End Function

    Public Sub New()
        _categories.Add(New Product.Category With {.CategoryID = 101, .CategoryName = "Electronics"})
        _categories.Add(New Product.Category With {.CategoryID = 102, .CategoryName = "Cameras"})
        _categories.Add(New Product.Category With {.CategoryID = 103, .CategoryName = "Software"})
    End Sub
End Class