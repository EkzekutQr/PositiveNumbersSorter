// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;


// Создаем массив из 15 элементов и заполняем его случайными числами от -100 до 99
int[] numbers = new int[15];
Random random = new Random();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(-100, 100); // Случайное число от -100 до 99
}

// Выводим массив в консоль
Console.WriteLine("Сгенерированный массив очков:");
Console.WriteLine(string.Join(", ", numbers));

// Фильтруем положительные элементы
var positiveNumbers = numbers.Where(n => n > 0).ToArray();

// Выводим положительные элементы в обратном порядке
Console.WriteLine("Положительные элементы в обратном порядке:");
for (int i = positiveNumbers.Length - 1; i >= 0; i--)
{
    Console.Write(positiveNumbers[i] + ", ");
}
