﻿// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.
Console.Write("Введите трехзначное число: ");

int a = Convert.ToInt32(Console.ReadLine());
int b = a % 10;

Console.Write("Последняя цифра нашего числа: ");
Console.WriteLine(b);


