using System;
using System.Linq;
using DotNetPractices.Data;
using DotNetPractices.Models;

namespace DotNetPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            using PetStoreContext context = new PetStoreContext();

            //Product squeakyBone = new Product()
            //{
            //    Name = "Squeaky Dog Bone",
            //    Price = 4.99M
            //};
            //context.Products.Add(squeakyBone);

            //Product tennisBalls = new Product()
            //{
            //    Name = "Tennis Ball 3-Pack",
            //    Price = 9.99M
            //};
            //context.Add(tennisBalls);

            //context.SaveChanges();

            var squeakyBone = context.Products
                                .Where(p => p.Name == "Squeaky Dog Bone")
                                .FirstOrDefault();
            if (squeakyBone is Product)
            {
                //squeakyBone.Price = 7.99M;
                context.Remove(squeakyBone);
            }
            context.SaveChanges();


            var products = context.Products
                .Where(p => p.Price >= 5.00M)
                .OrderBy(p => p.Name);

            foreach (Product p in products)
            {
                Console.WriteLine($"Id: {p.Id}");
                Console.WriteLine($"Name: {p.Name}");
                Console.WriteLine($"Price: {p.Price}");
                Console.WriteLine(new string('-', 20));
            }
        }
    }
}
