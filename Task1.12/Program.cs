/* 
Составить программу вывода на экран консоли следующей информации
5 10
7 см
*/

// Задали переменные с целочисленным и строковым типом данных.
int numberA = 5;
int numberB = 10;
int numberC = 7;
string length = "см";

/* 
После первых двух переменных поставили \n для того чтобы перевести последующие на новую строку
это удобно для написания программу в одной строке.
*/
System.Console.WriteLine($"{numberA} {numberB} \n{numberC} {length}");