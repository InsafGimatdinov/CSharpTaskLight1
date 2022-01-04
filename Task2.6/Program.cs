// Дан радиус окружности. Найти длину окружности и площадь курга.

System.Console.WriteLine("введите значение радиуса окружности");

double radius = Convert.ToDouble(System.Console.ReadLine());

if (radius > 0)
{
    double length, square;
    length = 2 * Math.PI * radius;
    square = Math.PI * Math.Pow(radius, 2);
    System.Console.WriteLine($"length = {length};\nsquare = {square};");
}
else
{
    System.Console.WriteLine("Введено некорректное значение ");
    System.Console.ReadLine();
}