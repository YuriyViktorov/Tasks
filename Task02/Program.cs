double firstValue;
double secondValue;

Console.Write("Введите первое число: ");
firstValue = double.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
secondValue = double.Parse(Console.ReadLine());

if(firstValue > secondValue)
{
    Console.Write(firstValue);
    Console.Write(">");
    Console.Write(secondValue);
}
else
{
    Console.Write(firstValue);
    Console.Write("<");
    Console.Write(secondValue);
}