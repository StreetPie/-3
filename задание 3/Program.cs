﻿// See https://aka.ms/new-console-template for more information

while (true)//нахождение положения точки в 1 секторе единичной окружности
{
    Console.WriteLine("Введите значение по x");
    double x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение по y");
    double y = double.Parse(Console.ReadLine());
    const double radius = 1;

    if ((x >= 0) && (y >= 0) && (x * x + y * y <= radius * radius))
    {
        Console.WriteLine("Точка принадлежит первой четверти");
    }
    else
        Console.WriteLine("Точка не принадлежит первой четверти");
}