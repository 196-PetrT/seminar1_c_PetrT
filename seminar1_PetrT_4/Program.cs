// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите N: ");
    String strN = Console.ReadLine();

int N = int.Parse(strN);
Console.Write("все чётные числа от 1 до N: ");
for (int i = 1; i <= N; i++)
{
    if (i % 2 == 0)
    {
        Console.Write( i + " ");
    }
}
