using System;

namespace CSharpD02
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "the fox jumped over the lazy dog";
            Console.WriteLine("Size of this string is {0}", str.Length);
            Console.WriteLine("Index of \"lazy\" string in string is {0}", str.IndexOf("lazy"));
            Console.WriteLine("Substring start with \"lazy\" to the end is {0}", str.Substring(str.IndexOf("lazy")));
            Console.WriteLine("Substring start with \"j\", end with \"r\" is {0}", str.Substring(str.IndexOf("j"), str.IndexOf("r") - str.IndexOf("j") + 1));
            Console.WriteLine("Replace \"dog\" by \"cat\", string now is {0}", str.Replace("dog", "cat"));
            string[] splitStrs = str.Split(' ');
            Console.WriteLine("Question 7 answer is:");
            foreach (var slitStr in splitStrs)
            {
                Console.Write($"{slitStr}" + ",");
            }
            Console.WriteLine("");
            Console.WriteLine("Question 8 answer is:");
            foreach (var slitStr in splitStrs)
            {
                Console.Write($"\"{slitStr}\"" + ",");
            }
        }
    }
}
