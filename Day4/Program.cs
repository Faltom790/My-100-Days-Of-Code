using System;
using System.Text;

namespace TestProject
{
    class Program
    {
        public static void Main(string[] args)
        {


            //Slicing strings into substrings
            // string example = "abc";
            // Console.WriteLine(example.Substring(0,1));

            //String Escape Sequences

            // " \ " symbol
            //   Console.WriteLine("Bobby said \"Go write some code\"");

            // "\\"
            //Console.WriteLine("a\\b");

            // "\t" (Tab Command)
            //   Console.WriteLine("Hllo \t World");


            //FORMATTING STRINGS

            // "{0:c}" (displays currency)
            // int price1 = 50;
            // int price2 = 150;
            // int price3 = 200;
            // Console.WriteLine(string.Format("{0:c}",price1));

            // "{0:p}" (displays percentage %)
            // float percent = 0.5f;
            // Console.WriteLine(string.Format("The task is {0:P}",percent));


            //STRING BUILDER 
            //  StringBuilder stringBuilder = new StringBuilder();
            //  stringBuilder.Append("nice to see you");

            //  string call = stringBuilder.ToString();
            //  Console.WriteLine(call);

             StringBuilder sb = new StringBuilder("I am a boy");   
             
        }
    }
}