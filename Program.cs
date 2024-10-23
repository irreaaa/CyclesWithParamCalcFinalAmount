Console.WriteLine("Введите значение нижнего предела интегрирования: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение верхнего предела интегрирования: ");
double b = Convert.ToDouble(Console.ReadLine());

if (a >= b)
{
    Console.WriteLine("ошибка");
    return;
}

Console.WriteLine("Введите количество разбиений интеграла на треугольники: ");
double n = Convert.ToDouble(Console.ReadLine());


double h = (b - a) / n;

Func<double, double> f = x => 2 * Math.Pow(x, 2) + 3 * x;

double integral = 0;
for (int i = 0; i < n; i++)
{
    double xMiddle = a + (i + 0.5) * h;

    integral += f(xMiddle) * h;
}

Console.WriteLine($"Приближённое значение интеграла методом средних треугольников: {integral}");

Console.ReadKey();