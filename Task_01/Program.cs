// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Console.WriteLine("Введите значение к1");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b1");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение к2");
int k2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b2");
int b2 = int.Parse(Console.ReadLine());

if (k1 == k2)
Console.WriteLine("Прямые параллельны ");

else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Координаты точки пересечения: x ={x}, y = {y}");
}