Console.Write("Введите число: ");
int numb = int.Parse(Console.ReadLine());
int a = 0;

string b = "";

while (numb >= 1)
{
    a = numb % 2;
    b = a + b;

    numb = numb / 2;
}
Console.WriteLine(b);