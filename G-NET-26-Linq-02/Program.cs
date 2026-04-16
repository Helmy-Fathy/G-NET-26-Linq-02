using LINQ.Models;
using System.Collections.Generic;
using System.Diagnostics;
using static LINQ.DataSources.Source;
namespace G_NET_26_Linq_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1. Get top 3 most expensive products
            //var result = ProductList.OrderByDescending(p => p.UnitPrice).Take(3);


            ////2.show page 2 of products, with page size = 5
            //var result = ProductList.Skip(5).Take(5);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            ////3. Take products from the list as long as Their UnitPrice is less than $25(list is ordered by price).
            //var result = ProductList.OrderBy(p => p.UnitPrice).TakeWhile(p => p.UnitPrice < 25);
            //foreach (var item in result)
            //    Console.WriteLine(item);


            ////4. Check if ALL products in the "Seafood" category are in stock
            //var result = ProductList.Where(p => p.Category == "Seafood").All(p => p.UnitsInStock > 0);


            ////5. Check if the ID list contains 9
            //int[] ids = { 3, 9, 13, 18 };
            //var result = ids.Contains(9);


            ////5. Check if the ID list contains 9
            //var result = ProductList.Select(p => p.ProductID).Contains(9);
            //Console.WriteLine(result);


            ////6. Group all products by Category and print each group with its product count.
            //var result = ProductList.GroupBy(p => p.Category);
            //foreach (var group in result)
            //{
            //    Console.WriteLine($"{group.Key} - {group.Count()}");
            //}


            ////7. Group products by Category and project only product names per group
            //var result = ProductList.GroupBy(p => p.Category,p => p.ProductName);
            //foreach (var group in result)
            //{
            //    Console.WriteLine($"[{group.Key}]");
            //    foreach (var name in group)
            //        Console.WriteLine($"  - {name}");
            //}


            ////8. Find all categories that have MORE THAN 3 products
            //var result = ProductList.GroupBy(p => p.Category).Where(g => g.Count() > 3).Select(g => g.Key);
            //foreach (var category in result)
            //    Console.WriteLine(category);












        }
    }
}
