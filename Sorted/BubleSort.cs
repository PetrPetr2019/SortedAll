using System;
using System.Collections.Generic;
using System.Text;

namespace Sorted
{
    internal class BubleSort
    {
        public void Show()
        {
            Console.WriteLine("Сколько элементов будем сравнивать ?");
            var N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа для сортировки");
            var massiv = new int[N];
            for (var i = 0; i < massiv.Length; i++) massiv[i] = Convert.ToInt32(Console.ReadLine());
            BubbleSort(massiv);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Числа после сортировки");
            for (var i = 0; i < massiv.Length; i++) Console.WriteLine(massiv[i]);
        }

        public static int[] BubbleSort(int[] arr) // Функция алгоритма сорировки BubbleSort
        {
            for (var i = 0; i < arr.Length; i++) // Сколько пцзырьков надо нам нужно отсортировать
            for (var j = i + 1; j < arr.Length; j++) // непосредственно каждый пузырек
                if (arr[i] > arr[j])
                {
                    var temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }

            return arr;
        }
    }
}


