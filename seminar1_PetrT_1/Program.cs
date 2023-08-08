// задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число: ");
    int numbA = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int numbB = int.Parse(Console.ReadLine());
if (numbA == numbB)
{
    Console.WriteLine("Введите неодинаковые числа!");
    return;
}


Console.WriteLine(numbA > numbB ? "первое число больше второго числа" : "первое чиcло меньше второго числа");
