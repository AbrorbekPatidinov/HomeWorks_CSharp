using System;
using System.Collections;
using System.Collections.Generic;

namespace Console_C_ 
{
   class Program 
   {
      // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
      static void power() {
      System.Console.WriteLine("Enter the number: ");
      int number = Convert.ToInt32(Console.ReadLine());
      System.Console.WriteLine("Enter the power: ");
      int power = Convert.ToInt32(Console.ReadLine());
      int num = 1;
      for (int i = 0; i < power; i++) num *= number;
      System.Console.WriteLine("Answer: " + num);   
     }/////////

       // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
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
     }///////
     
     // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
     static void create_array_8() {
      int size = 8;
      int[] array = new int[size];
      Random random = new Random();
      for (int i = 0; i < size; i++) {
        array[i] = random.Next(0, size);
        System.Console.WriteLine(" {0} ", array[i]);
      }
     }////////
     // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве
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
     }////////

     // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях
     static void create_array_with_rand_numbers_count_uneven_nums() {
       int size = 3, k = 0, sum = 0;
       int[] array = new int[size];
       Random random = new Random();
       System.Console.WriteLine("Array is: ");
       for (int i = 0; i < size; i++) {
        array[i] = random.Next(0, 50);
        System.Console.WriteLine("{0} ", array[i]);
       }
       System.Console.WriteLine();
       foreach (int numbers in array) {
        if (numbers % 2 == 1) { k++; sum += numbers; }
       }
       System.Console.WriteLine("Count of uneven numbers: {0}", k);
     }///

     // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива
     static void create_array_find_max_and_min_elements() {
       int i, n;
       int[] m = new int[100];
       Random random = new Random();
       n = 11;
       System.Console.WriteLine("Array is: ");
       for (i = 0; i < n; i++)
       {
          m[i] = random.Next(0, 50);
          Console.Write(m[i] + " ");
       }
       var min = m[0];
       var max = m[0];
       for (i = 0; i < n; i++) {
        if (m[i] < min) min = m[i];
        else if (m[i] > max) max = m[i];
       }
       System.Console.WriteLine();
       System.Console.WriteLine("Minimal element of array: " + min);
       System.Console.WriteLine("Maximal element of array: " + max);
     }

     // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
     static void read_numbers_and_count_if_numbers_higher_than_0() {
      Console.Write("Enter the numbers (with pass): ");
      int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
      int count = arr.Count(x => x > 0);
      Console.WriteLine($"Кол-во элементов > 0: " + count);
     }
     static void Main(string[] args) 
     {
       read_numbers_and_count_if_numbers_higher_than_0();
     }
   }
}

