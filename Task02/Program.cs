//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
double firstValue, secondValue;


Console.Write("Введите первое число: ");
firstValue = double.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
secondValue = double.Parse(Console.ReadLine());

if(firstValue > secondValue)
{
    Console.Write(firstValue);
    Console.Write(" > ");
    Console.Write(secondValue);
}
else
{
    Console.Write(firstValue);
    Console.Write(" < ");
    Console.Write(secondValue);
}