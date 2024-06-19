using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class StringData
    {
        public static bool IsUpperCase(string s)
        {
            if(s.Length <= 0)
            {
                return false;
            }
            return s.All(char.IsUpper);
        }

        public static bool IsPasswordComplex(string s)
        {
            return s.Any(char.IsDigit) && s.Any(char.IsLower) && s.Any(char.IsUpper) && s.Any(char.IsSymbol) && s.Length > 15;
        }

        public static string Reverse(string word)
        {
            char[] characters = word.ToCharArray();
            Array.Reverse(characters);
            string reversedWord = new(characters);
            return reversedWord;
        }

        public static string ReverseSentence(string sentence)
        {
            //Solution1
            //StringBuilder sb = new StringBuilder(sentence.Length);
            //foreach (var eachchar in sentence.Split(" "))
            //{
            //    sb.Append(Reverse(eachchar));
            //    sb.Append(" ");
            //}
            //return sb.ToString().Trim();

            //Solution2
            string[] myarray = sentence.Split(' ');
            return string.Join(" ", myarray.Select(Reverse).ToArray());
        }
    }
}
