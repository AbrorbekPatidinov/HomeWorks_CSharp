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
     static void create_array_8() {
      int size = 8;
      int[] array = new int[size];
      Random random = new Random();
      for (int i = 0; i < size; i++) {
        array[i] = random.Next(0, size);
        System.Console.WriteLine(" {0} ", array[i]);
      }
     }
     static void create_array_with_three_digits() {
       int size = 3, k = 0, sum = 0;
       int[] array = new int[size]; 
       Random random = new Random();
       System.Console.WriteLine("Array is: ");
       for (int i = 0; i < size; i++) {
        array[i] = random.Next(100, 999);
        System.Console.Write("{0} ", array[i]);
       }
       System.Console.WriteLine();
       foreach (int numbers in array) {
         if (numbers % 2 == 0) { k++; sum += numbers; }
       }
       System.Console.WriteLine("Count of even numbers: {0}", k);
     }
     static void Main(string[] args) 
     {
       create_array_with_three_digits();
     }
   }
}

