// Дан радиус окружности. Нужно найти её диаметр.

// Пусть радиус задаст полдьзователь.
System.Console.WriteLine("Введите радиус");

float radius = float.Parse(System.Console.ReadLine());

// Так же кск и в предыдущей задаче значение радиуса не может быть отрицательным или 0.
// Поэтому задаём условие при котором наша задача решиться.
if (radius > 0)
{
    float diametr = 2 * radius; // Формуля для нахождения диаметра.
    System.Console.WriteLine($"diametr = {diametr}");
}
else
{
    System.Console.WriteLine("Вы ввели неверноле значение радиуса");
    System.Console.ReadKey();
}