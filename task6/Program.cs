﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
Console.WriteLine("Введите число ");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA%2==0)
    Console.WriteLine("четное");
else Console.WriteLine("нечетное");

