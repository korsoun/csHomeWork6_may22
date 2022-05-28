// Задача 43
// Принять коэффициенты k и b для двух уравнений прямых и найти координаты точки пересечения заданных прямых.

void GetIntersectionPoint (double k1, double b1, double k2, double b2)
{
double kTransitional = k1 - k2;  // Эквивалент вычитания одного уравнения из другого
double bTransitional = b1 - b2;

double x = -bTransitional / kTransitional;  // Эквивалент получения k, 0 = kx + b => -b = kx => x = -b/k
double y = x * k2 + b2;     // Эквивалент подстановки k и b в уравнение
string resX = string.Format("{0:f3}", x);
string resY = string.Format("{0:f3}", y);

Console.WriteLine("Точка пересечения (" + resX + "; " + resY + ")");
}

Console.WriteLine("Введите значения для уравнений прямых ида y = kx + b.");
Console.Write("Коэффициент k для первой прямой: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Коэффициент b для первой прямой: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Коэффициент k для второй прямой: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Коэффициент b для второй прямой: ");
double b2 = Convert.ToDouble(Console.ReadLine());

GetIntersectionPoint(k1, b1, k2, b2);
