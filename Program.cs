// Задача 27 Напишите функцию и запустите ее, которая принимает на вход число и выдает сумму цифр в числе

int Roma(int R)
{
    int res = 0;

    while (R > 0)
    {
        res = res + (R % 10);
        R = R / 10;
    }
    return res;
}
Console.Clear();
Console.Write ("Введите число: ");
int R = int.Parse (Console.ReadLine ()!);
Console.WriteLine($"Сумма цифр числа {R} равна {Roma(R)}");