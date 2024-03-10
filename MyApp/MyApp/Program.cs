// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World1!");
Console.WriteLine("Hello, World2!");
Console.WriteLine("Hello, World3!");

static double GetAverage(int[] numbers)
{
    double zmienna = 0.0;
    for (int i = 0; i < numbers.Length; i++)
    {
        zmienna += numbers[i];
    }

    return zmienna / numbers.Length;
}

int[] numbers = {1,2,3,421,123,12,2,12,12312};
double average = GetAverage(numbers);
Console.WriteLine(average);


static int GetMax(int[] numbers)
{
    int result = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (result < numbers[i])
            result = numbers[i];
    }
    return result;
}

