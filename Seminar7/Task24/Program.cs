﻿// Задача 24 Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int ReadInt()
{
    Console.WriteLine("Введите целое число");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int SumFrom1ToA(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum = sum + i;
    }
    return sum;
}

int number = ReadInt();
int summa = SumFrom1ToA(number);
Console.WriteLine($"Сумма числе от 1 до {number} = {summa}");
