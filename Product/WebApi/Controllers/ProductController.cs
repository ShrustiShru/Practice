using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApi.Models.Database;

namespace WebApi.Controllers
{

    [EnableCors("*", "*", "*", "*")]
    public class ProductController : ApiController
    {
        public List<Product> GetAllProducts()
        {
            var context = new ProductsEntities();
            return context.Products.ToList();
        }

        public Product GetProduct(string id)
        {
            var Id = int.Parse(id);
            var context = new ProductsEntities();
            return context.Products.FirstOrDefault((m) => m.ProductId == Id);
        }

        [HttpPost]
        public void AddNewProduct(Product product)
        {
            try
            {
                var context = new ProductsEntities();
                context.Products.Add(product);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public void UpdateProduct(Product product)
        {
            
            var context = new ProductsEntities();
            var found = context.Products.FirstOrDefault((m)=>m.ProductId==product.ProductId);

            if (found != null)
            {
                found.ProductName = product.ProductName;
                found.ProductPrice = product.ProductPrice;
                found.ProductImage = product.ProductImage;
                found.Quantity = product.Quantity;
                context.SaveChanges();
            }
        }

        [HttpDelete]
        public void DeleteProduct(string id)
        {
            var ID = int.Parse(id);
            var context = new ProductsEntities();
            var found = context.Products.FirstOrDefault((m) => m.ProductId == ID);
            if (found != null)
                context.Products.Remove(found);
            context.SaveChanges();
        }
    }
}
