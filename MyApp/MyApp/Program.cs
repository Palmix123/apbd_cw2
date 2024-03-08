// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World1!");
Console.WriteLine("Hello, World2!");
Console.WriteLine("Hello, World3!");

static double GetAverage(int[] numbers)
{
    double result = 0.0;
    for (int i = 0; i < numbers.Length; i++)
    {
        result += numbers[i];
    }

    return result / numbers.Length;
}

int[] numbers = {1,2,3,421,123,12,2,12,12312};
double average = GetAverage(numbers);
Console.WriteLine(average);