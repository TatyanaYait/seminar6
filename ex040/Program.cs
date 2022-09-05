Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine());

if (a + b > c && b + c > a && a + c > b)
{
    Console.WriteLine(" такой треугольник существует!");
}
else
    Console.WriteLine(" такой треугольник не существует!");