using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LINQExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>()
            {
                new Product(){Id = 1, Name = "Nokia 33", Price = 22589, ProductType = "Mobile"},
                new Product(){Id = 1, Name = "apple oMac", Price = 45029, ProductType = "Mobile"},
                new Product(){Id = 1, Name = "Table", Price = 12587, ProductType = "Farnichair"},
                new Product(){Id = 1, Name = "Chair", Price = 75021, ProductType = "Farnichair"},
                new Product(){Id = 1, Name = "Monitor", Price = 10000, ProductType = "Computer"},
                new Product(){Id = 1, Name = "Laptop", Price = 70000, ProductType = "Computer"},
                new Product(){Id = 1, Name = "pen 33", Price = 1000, ProductType = "Stationary"},
            };



            // LINQ Clasical Style
            // Method 1
            //var retrieveProduct = from product in products
            //                    where product.Price > 5000 && product.Price < 20000
            //                    orderby product.Name descending 
            //                    select 
            //                    new
            //                    {
            //                        Name = product.Name,
            //                        Price = product.Price,
            //                        Code = product.Name+product.ProductType,
            //                    };



            //foreach (var p in retrieveProduct)
            //{
            //    Console.WriteLine(p.Name+ " "+p.Price);
            //}

            //Console.ReadKey();




            // LIND Lamda Style
            // Method 2
            var productList = products
                .Where(p => p.Price > 5000 && p.Price < 20000)
                .OrderByDescending(p => p.Name)
                .Select(p => new
                {
                    Name = p.Name,
                    Price = p.Price,
                    Code = p.Name + p.ProductType
                });

            foreach (var p in productList)
            {
                Console.WriteLine(p.Name+" "+p.Price+" "+p.Code);
            }

            Console.ReadKey();

        }
    }
}
