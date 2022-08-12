﻿// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

Console.Write("Введите координату x для первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y для первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату z для первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату x для второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y для второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату z для второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y1 - y2) * (y1 - y2) + (z2 - z1) * (z2 - z1));
Console.WriteLine("Расстояние между точками равно {0: #.##}", result);

