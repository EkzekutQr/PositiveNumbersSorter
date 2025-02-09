// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

// Пример массива целых чисел
int[] numbers = { -5, 10, -3, 8, -1, 15, 0, 7, -2, 12 };

// Фильтруем положительные элементы
var positiveNumbers = numbers.Where(n => n > 0).ToArray();

// Выводим положительные элементы в обратном порядке
Console.WriteLine("Положительные элементы в обратном порядке:");
for (int i = positiveNumbers.Length - 1; i >= 0; i--)
{
    Console.WriteLine(positiveNumbers[i]);
}
