using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Products
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
    }
    public class PhoneRepo
    {
        public static List<Product> AllProducts => getAll();

        public static List<Product> getAll()
        {
            List<Product> product = new List<Product>();
            product.Add(new Product
            {
                ProductId=1,
                ProductName ="iPhone 14 Pro Max",
                ProductPrice =175000,
                Image = @".\Images\iPhone14.jfif"
            });

            product.Add(new Product
            {
                ProductId = 2,
                ProductName = "Samsung S22",
                ProductPrice = 180000,
                Image = @".\Images\Samsung.jfif"
            });

            product.Add(new Product
            {
                ProductId = 3,
                ProductName = "Google Pixel",
                ProductPrice = 155000,
                Image = @".\Images\googlepixel.jfif"
            });

            product.Add(new Product
            {
                ProductId = 4,
                ProductName = "Moto",
                ProductPrice = 95000,
                Image = @".\Images\moto.jfif"
            });

            product.Add(new Product
            {
                ProductId = 5,
                ProductName = "Samsung Flip",
                ProductPrice = 125000,
                Image = @".\Images\flip.jfif"
            });

            product.Add(new Product
            {
                ProductId = 6,
                ProductName = "Oneplus",
                ProductPrice = 100000,
                Image = @".\Images\oneplus.jfif"
            });

            product.Add(new Product
            {
                ProductId = 7,
                ProductName = "iPad",
                ProductPrice = 180000,
                Image = @".\Images\iPad.jpg"
            });

            return product;
        }
    }
}