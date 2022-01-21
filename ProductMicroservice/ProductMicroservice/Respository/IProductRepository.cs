using ProductMicroservice.Models.Product;
using System.Collections.Generic;

namespace ProductMicroservice.Respository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductByID(int ProductId);
        void InsertProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int ProductId);
        void Save();
    }
}
