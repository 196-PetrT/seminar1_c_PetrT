// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");
    String strA = Console.ReadLine();
    int argA = int.Parse(strA);

    Console.WriteLine("Введите второе число: ");
    String strB = Console.ReadLine();
    int argB = int.Parse(strB);

    Console.WriteLine("Введите второе число: ");
    String strC = Console.ReadLine();
    int argC =  int.Parse(strC);

int Max(int argA, int argB, int argC)
{
    int result = argA;
    if (argB > result) result = argB;
    if (argC > result) result = argC;
    return result;
}

Console.WriteLine("Максимальное из этих чисел: {0}", Max(argA, argB, argC));
