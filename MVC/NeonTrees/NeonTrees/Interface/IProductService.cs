using NeonTrees.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeonTrees.Interface
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProduct();
        Product GetProductById(int id);
        void AddProduct(Product product);
        void AddProductJ(string name, string description, string InventoryValue, string Parttype, string url);
        void EditProduct(Product product);
        void DeleteProduct(Product product);
        public IEnumerable<Product> FilterProduct(string product_category);
        public IEnumerable<Product> GetBuildComponents(string build_comp);
        public string GetProductPrice(int id);
    }
}
