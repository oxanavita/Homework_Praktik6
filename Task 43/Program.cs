// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Введите количество прямых: ");
int count = int.Parse(Console.ReadLine());

double[] k = new double[count];
double[] b = new double[count];

Console.WriteLine("Введите значения k и b для каждой прямой:");

for (int i = 0; i < count; i++)
    {
        Console.Write($"k[{i + 1}]: ");
        k[i] = double.Parse(Console.ReadLine());

        Console.Write($"b[{i + 1}]: ");
        b[i] = double.Parse(Console.ReadLine());
    }

    double x = FindIntersectionX(k, b);
    double y = CalculateY(x, k[0], b[0]);

    Console.WriteLine("Точка пересечения двух прямых: ");
    Console.WriteLine("x = " + x);
    Console.WriteLine("y = " + y);


double FindIntersectionX(double[] k, double[] b)
{
    double intersectionX = 0;

    for (int i = 1; i < k.Length; i++)
    {
        intersectionX = (b[i] - b[0]) / (k[0] - k[i]);
    }

    return intersectionX;
}

double CalculateY(double x, double k, double b)
{
    return k * x + b;
}