﻿//Задача 10: Напишите программу,
// которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число    ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Вторая цифра вашего числа = {(num/10)%10}");