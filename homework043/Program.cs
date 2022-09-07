Console.Write("Введите k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = double.Parse(Console.ReadLine());

Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = double.Parse(Console.ReadLine());

// прямые заданы уравнениями  y = k1*x + b1; y = k2*x + b2.

if (k1 != k2) {
    double x = (b1 - b2) / (k2 - k1);
    double y = k2 * ((b1 - b2) / (k2 - k1)) + b2;
    Console.WriteLine("Координаты точки пересечения этих прямых (" + x + "; " + y + ").");
}

else if (k1 == k2 && b1 == b2)     {
        Console.WriteLine("Прямые совпадают");
        
    }
else if (k1 == k2)     {
        Console.WriteLine("Прямые параллельны");
    }
    