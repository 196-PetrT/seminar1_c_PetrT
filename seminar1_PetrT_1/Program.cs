// задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число: ");
    String strA = Console.ReadLine();
    int numbA = int.Parse(strA);

    Console.WriteLine("Введите второе число: ");
    String strB = Console.ReadLine();
    int numbB = int.Parse(strB);
   
if (numbA == numbB)
{
    Console.WriteLine("Введите неодинаковые числа!");
    return;
}

Console.WriteLine(numbA > numbB ? "первое число больше второго числа" : "первое чиcло меньше второго числа");
