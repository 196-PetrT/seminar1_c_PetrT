// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
    String strNumb = Console.ReadLine();
    int numb = int.Parse(strNumb);

/*if (numb == 0)
{
   Console.WriteLine("число не должно равнятся 0");
   return;
}*/

Console.WriteLine(numb % 2 == 0 ? "четное" : "нечетное");
