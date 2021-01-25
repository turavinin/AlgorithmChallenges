﻿using System;

namespace TenMinuteWalk
{
    // You live in the city of Cartesia where all roads are laid out in a perfect grid. 
    //You arrived ten minutes too early to an appointment, so you decided to take the 
    //opportunity to go for a short walk. The city provides its citizens with a Walk 
    //Generating App on their phones -- everytime you press the button it sends you an 
    //array of one-letter strings representing directions to walk (eg. ['n', 's', 'w', 'e']). 
    //You always walk only a single block for each letter (direction) and you know it takes 
    //you one minute to traverse one city block, so create a function that will return true if 
    //the walk the app gives you will take you exactly ten minutes (you don't want to be early or late!) 
    //and will, of course, return you to your starting point. Return false otherwise.

    //Note: you will always receive a valid array containing a random assortment of direction 
    //letters ('n', 's', 'e', or 'w' only). It will never give you an empty array (that's not a walk, that's standing still!).



    //BEST SOLUTION

    //public static bool IsValidWalk(string[] walk)
    //{
    //    if (walk.Length != 10) return false;
    //    var x = 0; var y = 0;
    //    foreach (var dir in walk)
    //    {
    //        if (dir == "n") x++;
    //        else if (dir == "s") x--;
    //        else if (dir == "e") y++;
    //        else if (dir == "w") y--;
    //    }
    //    return x == 0 && y == 0;
    //}

    class Program
    {
        static void Main(string[] args)
        {
            string[] walk = new string[] { "n", "n", "n", "n", "n", "s", "s", "s", "s", "s" };
            var result = Kata.IsValidWalk(walk);

            Console.WriteLine($"The result is: {result}");



            Console.ReadLine();
        }
    }

    public class Kata
    {
        public static bool IsValidWalk(string[] walk)
        {
            var output = false;

            if (walk.Length != 10)
            {
                return output;
            }

            var s = 0;
            var n = 0;
            var e = 0;
            var w = 0;

            foreach (var dir in walk)
            {
                if (dir == "n") n++;
                else if (dir == "s") s++;
                else if (dir == "e") e++;
                else if (dir == "w") w++;
            }

            if (n == s && e == w) output = true;

            return output;
        }
    }
}
