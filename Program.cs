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
      // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
      static void intersection_of_two_lines_equations() {
      Console.Write("Введите k1: ");
      double k1 = Convert.ToDouble(Console.ReadLine());
      Console.Write("Введите b1: ");
      double b1 = Convert.ToDouble(Console.ReadLine());
      Console.Write("Введите k2: ");
      double k2 = Convert.ToDouble(Console.ReadLine());
      Console.Write("Введите b2: ");
      double b2 = Convert.ToDouble(Console.ReadLine());
 
      double x = -(b1 - b2) / (k1 - k2);
      double y = k1 * x + b1;
 
      x = Math.Round(x, 3);
      y = Math.Round(y, 3);
 
      Console.WriteLine($"Intersection of two lines answer: ({x};{y})");
     }
     // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. m = 3, n = 4.
     static void create_two_dimensional_array_with_random_numbers() {
      int[,] array = new int[3, 4];
      Random random = new Random();
      for (int y = 0; y < array.GetLength(0); y++)
      {
        for (int x = 0; x < array.GetLength(1); x++)
        {
          array[y, x] = random.Next(-100, 100);
        }
      }
      System.Console.WriteLine();
      for (int y = 0; y < array.GetLength(0); y++)
      {
        for (int x = 0; x < array.GetLength(1); x++)
        {
          System.Console.Write(array[y, x] + "\t");
        }
      } 
     }
     // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
     static void create_two_dimensional_array_and_read_positions() {
      int a, b;
      int[,] array = new int[5, 5];
      for (int y = 0; y < array.GetLength(0); y++) {
        for (int x = 0; x < array.GetLength(1); x++) {
          System.Console.WriteLine("Position Y: " + y + " Position X: " + x);
          array[y, x] = Convert.ToInt32(Console.ReadLine());
        }
      }
      for (int y = 0; y < array.GetLength(0); y++) {
        for (int x = 0; x < array.GetLength(1); x++) {
          System.Console.Write(array[x, y] + "\t  ");
          System.Console.WriteLine();
        }
      }
      System.Console.WriteLine("Enter coordinates: ");
      a = Convert.ToInt32(Console.ReadLine());
      b = Convert.ToInt32(Console.ReadLine());
      if (a > 5 && b > 5) System.Console.WriteLine("These numbers don't exists !");
      else { object? c = array.GetValue(a, b); System.Console.WriteLine("Answer: " + c); }
     }
     static void Main(string[] args) 
     {
       create_two_dimensional_array_and_read_positions();
     }
   }
}

