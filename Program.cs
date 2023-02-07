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
       static int SumOfNumbersInDigits() {
       System.Console.WriteLine("Enter the numbers: "); 
       int numbers = Convert.ToInt32(Console.ReadLine());
       int limit = Convert.ToString(numbers).Length;
       int advance = 0, result = 0;
       for (int i = 0; i < limit; i++) {
        advance = numbers - numbers % 10;
        result = result + (numbers - advance);
        numbers = numbers / 10;
       }
       return result;
     }
     static void Main(string[] args) 
     {
       int summNumbers = SumOfNumbersInDigits();
       System.Console.WriteLine("Answer is: " + summNumbers); 
     }
   }
}

