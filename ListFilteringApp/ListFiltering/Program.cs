using System;
using System.Collections.Generic;
using System.Linq;

namespace ListFiltering
{

    // In this kata you will create a function that takes a list of non-negative integers 
    //and strings and returns a new list with the strings filtered out.
    // Example:
    // ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b"}) => { 1, 2}
    // ListFilterer.GetIntegersFromList(new List<object>() { 1, 2, "a", "b", 0, 15 }) => { 1, 2, 0, 15}
    // ListFilterer.GetIntegersFromList(new List<object>() { 1, 2, "a", "b", "aasf", "1", "123", 231 }) => { 1, 2, 231}

    // BEST SOLUTION:

    //public class ListFilterer
    //{
    //    public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
    //    {
    //        return listOfItems.OfType<int>();
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {

            var number = ListFilterer.GetIntegersFromList(new List<object>() { 1, 2, "a", "b", 0, 15 });

            foreach (var item in number)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Hello World!");
        }

        public class ListFilterer
        {
            public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
            {
                var intList = new List<int>();

                foreach (var item in listOfItems)
                {
                    if (item is int)
                    {
                        intList.Add((int)item);
                    }
                }

                return intList.ToList();
            }
        }
    }
}
