// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите два числа");
Console.Write("A = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("B = ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{a}^{b} =  {Exponentiation(a, b)}");

int Exponentiation(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}