using LINQ_1.Data;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.Metrics;
using System.Threading;
using static LINQ_1.ListGenerator;
namespace LINQ_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators

            #region Question1
            ////1)Find all products that are out of stock.
            //var result = ProductList.Where(p => p.UnitsInStock == 0);
            //foreach (var item in result)
            //{
            //        Console.WriteLine(item);
            //}
            #endregion

            #region Question2
            ////2)Find all products that are in stock and cost more than 3.00 per unit.
            //var result = ProductList.Where(p =>p.UnitsInStock > 0 && p.UnitPrice >3.00);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question3
            ////3) Returns digits whose name is shorter than their value.
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.Where(A =>A.Length);
            //foreach(var item in result) {
            //    Console.WriteLine( item);
            //} 
            #endregion

            #endregion

            #region LINQ - Element Operators
            #region Question1
            //1) Get first Product out of Stock

            //var Result = ProductList.FirstOrDefault(P => P.UnitsInStock == 0);
            //Console.WriteLine(Result); 
            #endregion

            #region Question2
            //2)Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var Result = ProductList.FirstOrDefault(P => P.UnitPrice >1000);
            //Console.WriteLine(Result); 
            #endregion

            #region Question3
            //3)Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Where(n => n > 5).Skip(1).FirstOrDefault();
            //Console.WriteLine($"Second number greater than 5: {Result}"); 
            #endregion


            #endregion

            #region LINQ - Aggregate Operators

            #region Question1
            //1)Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(A => A % 2 != 0).Count();
            //Console.WriteLine(result);

            #endregion

            #region Question2
            //2)Return a list of customers and how many orders each has
            // var result=CustomerList.GroupBy(o => o.CustomerID) 
            #endregion

            #region Question3
            //3)Return a list of categories and how many products each has

            //var result = ProductList.GroupBy(p => p.Category).Select(c=> new
            //{
            //   categoryname = c.Key,
            //    ProductCount = c.Count()}).ToList();

            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Question4
            //4)Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            // var result=Arr.Sum();
            // Console.WriteLine(result);

            #endregion

            #region Question5
            //5)Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] word = { "dictionary_english.txt" };
            //var result = word.Sum(w=>w.Length);
            //Console.WriteLine(result); 
            #endregion

            #region Question6
            ////6) Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] word = { "dictionary_english.txt" };
            //int result = word.Min(w=>w.Length);
            //Console.WriteLine( result); 
            #endregion

            #region Question7
            //7)Get the total units in stock for each product category.
            //var result = ProductList.GroupBy(p => p.Category).Select(c => new
            //{
            //    CategoryId = c.Key,
            //    TotalStock = c.Sum(p => p.UnitsInStock)
            //});

            //Console.WriteLine(result);

            //foreach (var item in result) { 
            //    Console.WriteLine(item);
            //    }


            #endregion

            #region Question8
            //8)Get the cheapest price among each category's products

            //var result = ProductList.GroupBy(p => p.Category).Select(c => new
            //{
            //    Categoryname = c.Key,
            //    CheapestPrice = c.Min(p => p.UnitPrice)
            //});

            //foreach (var item in result)
            //{
            //     Console.WriteLine(item);
            //       } 
            #endregion

            #region Question9
            //9)Get the most expensive price among each category's products.
            //var result = ProductList.GroupBy(p => p.Category).Select(c => new
            //{
            //    CategoryName = c.Key,
            //    ExpensivePrice = c.Max(p => p.UnitPrice)
            //});
            //foreach (var item in result)
            //{
            //        Console.WriteLine(item);
            //} 
            #endregion

            #region Question10
            //10) Get the products with the most expensive price in each category.
            //var result = ProductList.GroupBy(p => p.Category).Select(c => new
            //{
            //    category = c.Key,
            //    expensive = c.OrderByDescending(p => p.UnitPrice).FirstOrDefault()
            //}) ;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #endregion

            #region LINQ - Ordering Operators

            #region Question1
            ////1)Sort a list of products by name
            //var result = ProductList.OrderBy(p => p.ProductName);
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Question2
            ////2)Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(A => A, StringComparer.OrdinalIgnoreCase).ToArray();
            //foreach ( var item in result )
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Question3
            ////3)Sort a list of products by units in stock from highest to lowest.
            //var result = ProductList.OrderByDescending(p => p.UnitsInStock);
            //foreach (var item in result)
            //{
            //        Console.WriteLine(item);
            //}
            #endregion

            #region Question4
            // //4)Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            // string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            // var result = Arr.OrderBy(A => A.Length).ThenBy(A => A);
            //foreach( var item in result)
            // {
            //     Console.WriteLine(item);
            // } 
            #endregion

            #region Question5
            ////5)Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var result = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Question6
            // //6)Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            // var result = Arr.Where(i => i.Length > 1 && i[1] == 'i').Reverse();
            // foreach( var i in result)
            // {
            //         Console.WriteLine(i);
            // }
            #endregion


            #endregion

            #region LINQ – Transformation Operators

            #region Question1
            ////1)Return a sequence of just the names of a list of products.
            //var result = ProductList.Select(p => p.ProductName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question2
            ////2). Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var result= words.Select(w=> new { upper = w.ToUpper(), Lower = w.ToLower() });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Question3
            ////3) Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var result = ProductList.Select(p => new { p.ProductName, Price = p.UnitPrice, p.Category }); // إعادة تسمية UnitPrice إلى Price

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question4
            //4). Determine if the value of int in an array matches their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Select((v, index) => new { Value = v, Index = index })
            //    .Where(item => item.Value == item.Index);
            //Console.WriteLine("Number_In place");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            //}


            #endregion

            #region Question5
            ////5)Select all orders where the order total is less than 500.00.

            //var result = CustomerList.Count(c=>c.Orders<500.00);
            //Console.WriteLine( result);
            #endregion

            #region Question6
            ////5)Select all orders where the order was made in 1998 or later.
            //var result = from c in CustomerList
            //             from o in c.Orders
            //             where o.OrderDate >= 1998
            //             select o;
            //foreach (var o in result)
            //{
            //    Console.WriteLine(o);
            //}
            #endregion

            #endregion

            #region LINQ - Set Operators
            #region Question1 
            ////1) Find the unique Category names from Product List
            //var result=ProductList.Select(p=>p.Category).Distinct();
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question2

            #endregion
            #endregion

            #region LINQ - Quantifiers
            #region Question1
            //1)Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

            //string[] words ={"dictionary_english.txt"};
            //bool result = words.Any(w => w.Contains("ei"));
            //Console.WriteLine($"Does any word contain 'ei'? {result}");

            #endregion

            #region Question2
            //2)Return a grouped a list of products only for categories that have at least one product that is out of stock.
            //var result = ProductList.Where(p => p.Category.Any(p => p.).Select(c => new
            //{
            //    Category = c.Name,
            //    Products = c.Products
            //}); 
            #endregion


            #endregion

            #region LINQ - Partitioning Operators

            #region Question1
            //  //1) Get the first 3 orders from customers in Washington

            //var result = CustomerList.Where(c => c.Address == "Washington").SelectMany(c => c.Orders).Take(3);
            //  foreach(var item in result)
            //  {
            //      Console.WriteLine(item);
            //  }

            #endregion

            #region Question2
            ////2)Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.TakeWhile((num, index) => num >= index);
            //foreach ( var i in result)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Question3
            //.Get the elements of the array starting from the first element divisible by 3.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile(num => num % 3 != 0);
            //foreach ( var i in result)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #endregion

            #region LINQ – Grouping Operators


            #region question1
            //1)Use group by to partition a list of numbers by their remainder when divided by 5

            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var result = numbers.GroupBy(n => n % 5);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Numbers with remainder of {item.Key} when divided by 5 is {item}");
            //}

            #endregion


            #endregion
        }
    }
}

