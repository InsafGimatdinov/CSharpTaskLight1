﻿//Составить программу вывода на экран консоли в одну строку четырёх любых чисел с одним пробелом между ними.

//Задали четыре переменные как требует задача и задали их рандомно с помощью функции.
int numberA = new Random().Next(1, 20);
int numberB = new Random().Next(1, 20);
int numberC = new Random().Next(1, 20);
int numberD = new Random().Next(1, 20);

//Вывели на экран консоли случайные числа с одним пробелами между ними. 
System.Console.WriteLine($"{numberA} {numberB} {numberC} {numberD}");

//Аналогичная задача предыдущей только с четыремя числами и одним пробелом между ними.