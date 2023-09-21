using System;
using System.Diagnostics;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args) {
                
        //VARIABLES

        //  Integers      
        // int  x = 5;                 
        // int  y = 3;  
        // int  z = -1;

         //Float
         // float y = -1.0f;
        // float x = 3.0f;        
        // float z = 0.8f;

        // String
        // string string1 ="a";
        // string string2 ="bird";
        // string string3 ="I eat pizza";

        // Char
            // char chart1 = '@';
            // char chart2 = '2';
            // char chart3 = '3';

        //Boolean
        // bool complete = false;
        // bool incomplete = true;


            //**********************************************************************************//

                        // CONDITIONAL STATEMENTS

      
       Console.Write("Please enter your age: ");
       int age = Convert.ToInt32(Console.ReadLine());

       if(age > 38)
       {
           Console.WriteLine("You are too old to sign up ");
       }
       else if (age < 0)
       {
           Console.WriteLine("You haven't been born yet");
       }
       else if
               (age >= 17)
               {
                   Console.WriteLine("You have now signed up! ");
               }                               
       else
       {
           Console.WriteLine("You must be 17+ to sign up");
            



        }
    }
  }
}
