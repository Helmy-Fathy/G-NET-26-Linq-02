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


        }
    }
}
