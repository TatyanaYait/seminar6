Console.Write("Введите количество чисел, которое хотите ввести: ");
int m = int.Parse(Console.ReadLine());
int[] arr = new int[m];

int count = 0;

for (int j = 0; j < m; j++)
{
    Console.Write("Введите любое число: ");
    int a = int.Parse(Console.ReadLine());

    arr[j] = a;

    if (arr[j] > 0)
    {
        count += 1;
    }
}
//Console.WriteLine(string.Join(", ", arr));
Console.WriteLine();
Console.WriteLine("Количество чисел больше нуля -> " + count);