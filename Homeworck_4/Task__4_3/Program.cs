// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.WriteLine("Введите количество элементов массива.");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(n);
PrintArray(array);



int[] FillArray(int n)
{
    int[] createArray = new int[8];
    Random rand = new Random();
    for (int i = 0; i < createArray.Length; i++)
    {
        createArray[i] = rand.Next(1, 30);
    }
    return createArray;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}