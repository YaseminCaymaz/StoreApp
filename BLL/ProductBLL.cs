using StoreApp.DAL;
using StoreApp.Models;

public class ProductBLL
{
    private readonly ProductDAL _productDAL;
    

    public ProductBLL(ProductDAL productDAL)
    {
        _productDAL = productDAL;
        
    }

    public void NewProduct(Product product)
    {
    
        if (product==null)
        {
            throw new Exception("Ürün bilgileri eksik veya hatalıdır.Lütfen tekrar deneyiniz.");
        }    

        _productDAL.AddProduct(product);
    }

    // Diğer BLL metotları buraya eklenebilir.

}