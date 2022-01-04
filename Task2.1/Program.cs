/*
Составить программу вычисления:
а)Y= 7X^2+3X+6, при любом значении x
б)X=12a^2+7a+12, при любом значении а
*/

// a

//Задали для переменной Х случайное число с помощью генератора.
double X = new Random().Next(1, 5);

// Вывели сгенерированное значение.
System.Console.WriteLine($"X = {X}");


// Задали новую переменную result для внесения туда расчета
double result = 7 * Math.Pow(X, 2) + 3 * X + 6;


// Вывели результат расчета
System.Console.WriteLine($"Y = {result}");


// б

double a = new Random().Next(1, 10);

System.Console.WriteLine($"a = {a}");

double result = 12 * Math.Pow(a, 2) + 7 * a + 12;

System.Console.WriteLine($"X = {result}");