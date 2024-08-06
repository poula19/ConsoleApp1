namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>
        {
            new Product { Name = "Widget", UnitsInStock = 0, UnitPrice = 2.50m, Category = "Gadgets" },
            new Product { Name = "Gadget", UnitsInStock = 10, UnitPrice = 5.00m, Category = "Gadgets" },
            new Product { Name = "Doodad", UnitsInStock = 3, UnitPrice = 3.50m, Category = "Gizmos" }
        };

            var outOfStockProducts = products
                .Where(p => p.UnitsInStock == 0)
                .ToList();

            Console.WriteLine("Out of Stock Products:");
            foreach (var product in outOfStockProducts)
            {
                Console.WriteLine($"{product.Name}");
            }
            var inStockAndExpensiveProducts = products
                .Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00m)
                .ToList();

            Console.WriteLine("In Stock and Expensive Products:");
            foreach (var product in inStockAndExpensiveProducts)
            {
                Console.WriteLine($"{product.Name}");
            }
            var sortedByName = products
                .OrderBy(p => p.Name)
                .ToList();

            Console.WriteLine("Products Sorted by Name:");
            foreach (var product in sortedByName)
            {
                Console.WriteLine($"{product.Name}");
            }
            var sortedByUnitsInStock = products
                .OrderByDescending(p => p.UnitsInStock)
                .ToList();

            Console.WriteLine("Products Sorted by Units in Stock:");
            foreach (var product in sortedByUnitsInStock)
            {
                Console.WriteLine($"{product.Name}: {product.UnitsInStock}");
            }
            string[] arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var sortedByLengthAndName = arr
                .OrderBy(name => name.Length)
                .ThenBy(name => name)
                .ToList();

            Console.WriteLine("Digits Sorted by Length and Then by Name:");
            foreach (var name in sortedByLengthAndName)
            {
                Console.WriteLine(name);
            }
            var arrWords = new[] { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var sortedCaseInsensitive = arrWords
                .OrderBy(word => word, StringComparer.OrdinalIgnoreCase)
                .ToList();

            Console.WriteLine("Case-Insensitive Sorted Words:");
            foreach (var word in sortedCaseInsensitive)
            {
                Console.WriteLine(word);
            }
            var reversedDigitsWithI = arr
                .Where(name => name.Length > 1 && name[1] == 'i')
                .Reverse()
                .ToList();

            Console.WriteLine("Digits Whose Second Letter is 'i' (Reversed):");
            foreach (var name in reversedDigitsWithI)
            {
                Console.WriteLine(name);
            }
        }
        }
}
