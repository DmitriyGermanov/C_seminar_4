// Решение в группах задач:
// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5 

int GetNumber(string message)
{
    Console.Write($"{message} ");
    return int.Parse(Console.ReadLine()!);
}

int FindRazryad(int findRazryad) // Функция нахождения разряда
{
    int razryadNumber = 0;
    while (findRazryad > 0)
    {
        findRazryad = findRazryad / 10;
        razryadNumber++;
    }
    return razryadNumber;
}
int num = GetNumber("Введите число:");
Console.WriteLine(FindRazryad(num));