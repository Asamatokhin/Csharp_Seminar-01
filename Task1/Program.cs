﻿// Задание 1. 
// Семинар 1. 
// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

Console.Write("Введите первое число: ");
int numbrer1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numbrer2 = Convert.ToInt32(Console.ReadLine());

if (numbrer1 == numbrer2 * numbrer2) 
{
    System.Console.WriteLine("Да");
}
else {
    System.Console.WriteLine("Нет");
}

// = - присваивание данных
// == - сравнение данных