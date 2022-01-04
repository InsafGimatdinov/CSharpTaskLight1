// Дана длина ребра куба. Найти объём и площатдь его боковой поверхности.

// Задали вручную длину ребра.
System.Console.WriteLine("Введите длину ребра куба");

// сконвертировали строку в число с плавающей точкой.
double a = Convert.ToDouble(System.Console.ReadLine());

// Задали условие при котором решается данная задача.
if (a > 0)
{
    double square = Math.Pow(a, 2); // Формула для расчета площади грани куба.
    double volume = Math.Pow(a, 3); // Формула для расчета объёма куба.
    System.Console.WriteLine($"Square of quad = {square};\nVolume of quad = {volume}");
}
else
{
    System.Console.WriteLine("Введено неверное значение, попробуйте ещё, ");
    System.Console.ReadLine();
}