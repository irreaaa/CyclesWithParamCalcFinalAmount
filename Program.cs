//StreamWriter txt = new StreamWriter("C:/Users/prdb/source/cbufb/ConsoleAppIra6/test.txt");
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
int n = Convert.ToInt32(Console.ReadLine());


double h = (b - a) / n;
    
Func<double, double> f = x => 2 * Math.Pow(x, 2) + 3 * x;

double integral = 0;
for (int i = 1; i <= n; i++)
{
    double xMiddle = a + (i - 1 + 0.5) * h;

    integral += f(xMiddle) * h;
}

Console.WriteLine($"Приближённое значение интеграла методом средних треугольников: {integral:F4}");
//txt.WriteLine($"Приближённое значение интеграла методом средних треугольников: {integral}");
//txt.Close();

Console.ReadKey();