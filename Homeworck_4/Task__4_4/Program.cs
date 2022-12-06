// Дополнительная задача (задача со звёздочкой): 
//Напишите программу, которая на вход принимает радиус круга и находит его площадь округленную до целого числа, 
//необходимо вывести максимальную цифру в полученном округлённом значении площади круга.

//10 -> 4
//20 -> 7
//30 -> 8


Console.Clear();
Console.Write("Введите радиус круга: R=");
double radius = Convert.ToDouble(Console.ReadLine());

int raundingToInt = Convert.ToInt32(FindSquare(radius));
Console.WriteLine($"Площадь круга: {FindSquare(radius)}");
Console.WriteLine($"Площадь круга округление до целого числа: {raundingToInt}");
Console.WriteLine($"Максимальное число: {FindMaxNamber(raundingToInt)}");

double FindSquare(double radius)
{
    double square = Math.PI * Math.Pow(radius, 2);
    return square;
}

int FindMaxNamber (int raundNum)
{
    int numberWithinNumber = 0;
    int maxNum = raundNum % 10;

    while (raundNum != 0)
    {
        raundNum = raundNum / 10;
        numberWithinNumber = raundNum % 10;
        if (numberWithinNumber > maxNum)
        {
            maxNum = numberWithinNumber;
        }
    }
    return maxNum;
}

