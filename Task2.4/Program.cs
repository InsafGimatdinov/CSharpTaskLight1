/*
Считая, что Земля - идеальная сфера с радиусом R = 6350 км, определить
расстояние до линии горизонта от точки С заданной высотой Н над Землёй.
*/

System.Console.WriteLine("У нас есть вычисленное растояние от точки до высоты наблюдателя.\nРасстояние зависит от высоты наблюдателя");
System.Console.WriteLine("Радиус земли постоянен и равняется 6350 км.\nИтак, следует ввести значение высоты наблюдателя в км: ");

double observeHight = Convert.ToDouble(System.Console.ReadLine());

if (observeHight > 0)
{
    double meterObserver = Convert.ToDouble(System.Console.ReadLine());
    double meterHorizon = Convert.ToDouble(System.Console.ReadLine());
    const double radiusEarth = 6350;
    double distanceHorizon = Math.Pow((Math.Pow((radiusEarth + observeHight), 2) - Math.Pow(radiusEarth, 2)), 0.5);
    System.Console.WriteLine($"Расстояние плоскости в метрах: высота наблюдателя {meterObserver} метры и\nПлоскость видимости {meterHorizon} в метрах. ");
    System.Console.WriteLine("Пожалуйста нажмите ОК чтобы продолжить. ");
    System.Console.ReadLine();
}
else
{
    System.Console.WriteLine("Неправильно введено значение. Попробуйте снова. ");
    System.Console.ReadLine();
}