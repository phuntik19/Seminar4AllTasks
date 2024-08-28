// задача 27 Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int firstDigit = number / 100;
Console.WriteLine(firstDigit);
int secondDigit = number / 10 % 10;
Console.WriteLine(secondDigit);
int ThirdDigit = number % 10;
Console.WriteLine(ThirdDigit);
int lastDigit = (firstDigit + secondDigit + ThirdDigit);
Console.WriteLine(lastDigit);


