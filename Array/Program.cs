using System.Diagnostics;
using System.Xml.Linq;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            int[] numbers = { 2, 5, 3, 1, 7, 9 };
            int max = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];

                }
            }
            Console.WriteLine(max);
            #endregion

            #region Task2

            var product1 = new{ Id = 1, Name = "Test1", Price = 5, StockCount = 100};
            var product2 = new { Id = 2, Name = "Test2", Price = 10, StockCount = 200};
            var product3 = new { Id = 3, Name = "Test3", Price = 15, StockCount = 300};
            var product4 = new { Id = 4, Name = "Test4", Price = 20, StockCount = 400};
            var product5 = new { Id = 5, Name = "Test5", Price = 25, StockCount = 500};

            var Products = new[] { product1, product2, product3, product4, product5 };

            int sum = 0;
            int count = 0;

            for(int i=0; i<Products.Length; i++)
            {
                if (Products[i].Id % 2 == 1)
                {
                    sum += Products[i].Price;
                    count++;
                }
            }
            int average = sum / count;
            Console.WriteLine(average);
            #endregion
        }
    }
}
