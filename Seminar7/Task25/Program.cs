// задача 25 Напишите функцию, которая принимает на вход два числа (А и В) и возводит число в натуральную степень

// 3,5 -> 243 
// 2,4 -> 16

int ReadInt()
{
Console.WriteLine("Введите для начала свое число");
int value = Convert.ToInt32(Console.ReadLine());
return value;
}

int degree(int a)
{ 
    Console.WriteLine("Введите  первое число");
    int b = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите  второе число");
    int c = Convert.ToInt32(Console.ReadLine());
    
    int result = 1;

    for (int i = 0; i < c; i++)
    {
    result = result *= b;
    }
    return result;
}

int number = ReadInt();
int result1 = degree(number);
Console.WriteLine(result1); 

