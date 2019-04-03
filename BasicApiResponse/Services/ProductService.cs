using BasicApiResponse.Models.Dto;
using BasicApiResponse.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicApiResponse.Services
{
    public class ProductService : IProductService
    {
        private List<ProductResponse> ProductList = new List<ProductResponse>();

        public ProductService()
        {
            LoadProducts();
        }

        public void LoadProducts()
        {
            ProductResponse product1 = new ProductResponse()
            {
                Id = 231,
                Name = "Ahorros"
            };

            ProductResponse product2 = new ProductResponse()
            {
                Id = 232,
                Name = "CTS"
            };

            ProductResponse product3 = new ProductResponse()
            {
                Id = 233,
                Name = "Plazo Fijo"
            };

            ProductResponse product4 = new ProductResponse()
            {
                Id = 234,
                Name = "Créditos"
            };

            ProductList.Add(product1);
            ProductList.Add(product2);
            ProductList.Add(product3);
            ProductList.Add(product4);
        }

        public ProductResponse GetProduct(int productid)
            => ProductList.FirstOrDefault(x => x.Id == productid);

        public ErrorResponse ValidateProduct(int productid)
        {
            var product = GetProduct(productid);

            if (product == null)
            {
                var errorResponse = new ErrorResponse()
                {
                    Code = -1,
                    Title = "Productos",
                    UserMessage = "Producto no válido"
                };
                return errorResponse;
            }

            return null;
        }
    }
}