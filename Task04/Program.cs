//Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (max < b) max = b;
if (max < c) max = c;

System.Console.WriteLine("Максимальное из этих чисел = " + max);