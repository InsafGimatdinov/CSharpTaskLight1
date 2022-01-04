﻿//Вывести на экран числа 14, 11, 90 одно под другим. Или попробовать сгенерировать случайные числа.

// Очень простой способ вывести числа программа составляет одну строку.
// System.Console.WriteLine($"{14},\n{11},\n{90},");

// Возможен и другой способ но по длиннее.
// int A = 14;
// int B = 11;
// int C = 90;

// System.Console.WriteLine($"{A}\n{B}\n{C}");

// Задача аналогичная предыдущей только количество чисел отдличается.
// Результат при обеих случаях одинаковый.

// Так же можно воспользовать генератором случайных чисел с помощью функции.

int A = new Random().Next(1, 20);
int B = new Random().Next(1, 20);
int C = new Random().Next(1, 20);

System.Console.WriteLine($"{A}\n{B}\n{C}");