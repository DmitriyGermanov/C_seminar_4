// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int GetNumber(string message)
{
    Console.Write($"{message} ");
    return int.Parse(Console.ReadLine()!);
}

int Multiplication(int a)
{
    int b = 1;
    for (int i = 1; i <= a; i++)
        b = b * i;
    return b;
}

int num = GetNumber("Введите число:");
int mult = Multiplication(num);
Console.WriteLine($"Произведение чисел от 1 до {num} = {mult}");
