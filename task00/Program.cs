// Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int GetNumber(string message)
{
    Console.Write($"{message} ");
    return int.Parse(Console.ReadLine()!);
}

void GetSumNumber(int a)
{
    int summ = 0;
    for (int i = 1; i <= a; i++)
    {
        summ += i;
    }

    Console.WriteLine($"Сумма чисел от 1 до {a} = {summ}");
}

int num = GetNumber("Введите число:");
GetSumNumber(num);


