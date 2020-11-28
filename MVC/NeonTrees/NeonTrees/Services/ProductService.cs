using Microsoft.Extensions.Configuration;
using NeonTrees.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using NeonTrees.Interface;

namespace NeonTrees.Services
{
    public class ProductService : IProductService
    {
        private readonly string _connectionString;

        public ProductService(IConfiguration _configuration)
        {
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public IEnumerable<Product> GetAllProduct()
        {
            List<Product> productList = new List<Product>();

            try
            {
                using(OracleConnection con = new OracleConnection(_connectionString))
                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.CommandText = "Select * from Product";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        Product _product = new Product
                        {
                            ID = reader.GetValue(0).ToString(),
                            Name = reader.GetValue(1).ToString(),
                            Description = reader.GetValue(2).ToString(),
                            InventoryValue = reader.GetValue(3).ToString(),
                            PartType = reader.GetValue(4).ToString(),
                            URL = reader.GetValue(5).ToString()
                        };
                        productList.Add(_product);
                    }
                }
            }
            catch(Exception ex)
            {
                string error = ex.ToString();
            }
            return productList;
        }

        public Product GetProductById(int id)
        {
            Product product = new Product();
            using(OracleConnection con = new OracleConnection(_connectionString))
            {
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "Select * from Product Where ProductID = "+ id +"";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    Product _product = new Product
                    {
                        ID = reader.GetValue(0).ToString(),
                        Name = reader.GetValue(1).ToString(),
                        Description = reader.GetValue(2).ToString(),
                        InventoryValue = reader.GetValue(3).ToString(),
                        PartType = reader.GetValue(4).ToString(),
                        URL = reader.GetValue(5).ToString()
                    };
                    product = _product;
                }
            }
            return product;
        }

        public void AddProduct(Product product)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(_connectionString))
                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand(); 
                    cmd.CommandText = "INSERT INTO PRODUCT(productname,description,inventoryvalue,parttype,url) VALUES('" + product.Name + "','" + product.Description + "','" + product.InventoryValue + "','" + product.PartType + "','" + product.URL + "')";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                string error = ex.ToString();
            }

        }

        public void AddProductJ(string[] data)
        {
            Console.WriteLine("!HELLLO" + data);
           /* try
            {
                using (OracleConnection con = new OracleConnection(_connectionString))
                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.CommandText = "INSERT INTO PRODUCT(productid,productname,description,inventoryvalue,parttype,url) VALUES('" + product.ID + "','" + product.Name + "','" + product.Description + "','" + product.InventoryValue + "','" + product.PartType + "','" + product.URL + "')";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
            }*/

        }

        public void EditProduct(Product product)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(_connectionString))
                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.CommandText = "Update Product Set ProductName = '"+product.Name+"',Description='"+product.Description+"',InventoryValue="+
                        product.InventoryValue+ ",PartType='" + product.PartType+ "',URL='" + product.URL+"' Where ProductID = "+product.ID+"";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                }
            }
            catch(Exception ex)
            {
                string error = ex.ToString();
            }
        }

        public void DeleteProduct(Product product)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(_connectionString))
                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.CommandText = "Delete From Product Where ProductID ="+product.ID+"";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                string error = ex.ToString();
            }
        }
    }
}
