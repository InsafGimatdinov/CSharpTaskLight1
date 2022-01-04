// Составить программу вывода столбиком четртыех любых чисел.

// Сгененрировали четыре случайных числа.
int A = new Random().Next(1, 50);
int B = new Random().Next(1, 40);
int C = new Random().Next(1, 50);
int D = new Random().Next(1, 40);

// Вывод одинаковый с предыдущими числами.
System.Console.WriteLine($"{A}\n{B}\n{C}\n{D}");