/*
Дана сторона квадрата. Найти его периметр.
*/

// Сгенерируем значение стороны квадрата.

// double a = new Random().Next(1,10);

// System.Console.WriteLine($"a = {a}");

// // У периметра квадрата есть уже известная формула P = 4a.

// double P = 4 * a;

// System.Console.WriteLine($"P = {P}");

// В решебнике предлагается ввести значение длины из консоли давайте попробуем.

System.Console.WriteLine("Введите значение длины");

// Преобразовали строку в число с плавающей точкой.
float a = float.Parse(System.Console.ReadLine());

// Задали условие при котором возможно решить задачу и данные не противоречать логике. 
if (a > 0)
{
    float P;
    P = a * 4;
    System.Console.WriteLine($"P = {P}");
}

// Конечно же сторона квадрата или любой фигуры не может быть отрицательным или 0.
else
{
    System.Console.WriteLine("Введенное значение неверное");
    System.Console.ReadKey();
}