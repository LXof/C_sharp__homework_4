// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр в числе: {GetSumNumber(number)}");

int GetSumNumber(int inputNum)
{
    int sum = 0;
    while (inputNum != 0)
    {
        sum = sum + inputNum % 10;
        inputNum = inputNum / 10;
    }
    return sum;
}