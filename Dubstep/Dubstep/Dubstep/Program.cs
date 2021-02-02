using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Dubstep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Dubstep.SongDecoder("WUBWEWUBAREWUBWUBTHEWUBCHAMPIONSWUBMYWUBFRIENDWUB"));
            
        }

        public class Dubstep
        {
            public static string SongDecoder(string input)
            {
                Regex regex = new Regex(@"WUB");

                var splitedArr = regex.Split(input);
                var output = string.Join("  ", splitedArr)

                return output;

            }
        }
    }
}
