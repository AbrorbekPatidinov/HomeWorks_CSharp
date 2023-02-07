using System;
using System.Collections;
using System.Collections.Generic;

namespace Console_C_ 
{
   class Program 
   {
      static void power() {
      System.Console.WriteLine("Enter the number: ");
      int number = Convert.ToInt32(Console.ReadLine());
      System.Console.WriteLine("Enter the power: ");
      int power = Convert.ToInt32(Console.ReadLine());
      int num = 1;
      for (int i = 0; i < power; i++) num *= number;
      System.Console.WriteLine("Answer: " + num);   
     }
     static void Main(string[] args) 
     {
       power();
     }
   }
}

