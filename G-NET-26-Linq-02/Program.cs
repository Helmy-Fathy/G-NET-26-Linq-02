using LINQ.DataSources;
using LINQ.Helpers;
using LINQ.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Net.WebSockets;
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


            ////9. Using QUERY SYNTAX, group customers by Country, and for each group select { Country, Count, TotalOrderValue }.
            //var result = from c in CustomerList
            //             group c by c.Country into g
            //             select new
            //             {
            //                 Country = g.Key,
            //                 Count = g.Count(),
            //                 TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
            //             };


            ////10. Calculate the total number of units in stock across all products
            //var totalUnitsInStock = ProductList.Sum(p => p.UnitsInStock);


            ////11. Find the CHEAPEST and MOST EXPENSIVE product prices
            //var cheapestPrice = ProductList.Min(p => p.UnitPrice);
            //var mostExpensivePrice = ProductList.Max(p => p.UnitPrice);


            ////12. Get a distinct list of all product categories
            //var result = ProductList.Select(p => p.Category).Distinct().ToList();


            ////13. find product IDs that are in setA but NOT in setB
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };
            //var result = setA.Except(setB);


            ////14. Find countries that appear in list1 but NOT in list2 (case -insensitive).
            //    string[] list1 = { "Germany", "France", "UK", "Spain" };
            //    string[] list2 = { "france", "SPAIN", "Italy" };
            //var result = list1.Except(list2, StringComparer.OrdinalIgnoreCase);


            ////15. Build a Dictionary<int, Product> keyed by ProductID. Then retrieve and print the product with ID = 18.
            //var result = ProductList.ToDictionary(p => p.ProductID, p => p);
            //Console.WriteLine(result[18]);


            ////16. Get the first product whose price is greater than $50.
            //var result = ProductList.First(p => p.UnitPrice > 50);



















        }
    }
}
