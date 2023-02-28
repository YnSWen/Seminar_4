// Задача 27: Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int GetSum (int num)
{
    int sum = 0;
    int num_0 = 0;
    while (num > 9)
    {
    num_0 = num % 10;
    sum = sum + num_0;
    num /= 10;
    }
    return sum + num;
}
Console.WriteLine($"{GetSum(number)}");

