﻿// задача 26 Напишите программу, которая принимает на вход число и выдает количество цифп в числе.

//456 -> 3
//78 -> 2
//89126 -> 5

int ReadInt()
{
    Console.WriteLine("Введите целое число");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int func(int number)
{
    int colvo = 0;
    while (number > 0)
    {
        number = number/10;
        colvo++;
    }
    return colvo;
}

int number = ReadInt();
int colvo1 = func(number);

Console.WriteLine($"{colvo1} цифр в числе");
