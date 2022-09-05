Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
//int[] array1 = {0,1}; // i
int[] array2 = new int[a]; //j

array2[0] = 0;
array2[1] = 1;

for (int j = 2; j < a; j++)
{
    array2[j] = array2[j - 1] + array2[j - 2];
}
Console.WriteLine(string.Join(" ", array2));