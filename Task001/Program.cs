﻿/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("Введите число A : ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В : ");
int B = Convert.ToInt32(Console.ReadLine());
int step = A;

for (int i = 1; i < B; i++)
{
    step = step * A;
}
Console.WriteLine(" A в степени B равно: " + step);