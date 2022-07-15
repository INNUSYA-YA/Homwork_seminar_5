// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.;
Console.Write("ВВедите размер массива ");
int n = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[n];
FillArray(numbers);
PrintArray(numbers);
double min = numbers[0];
double max = numbers[0];
for (int i = 0; i<numbers.Length;i++)
{
    if(numbers[i]<min)
    {
        min = numbers[i];
    }
    else if (numbers[i]>max)
    {
        max = numbers[i];
    }
}
double result = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна {result}");

void FillArray(double[] array)
{
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = new Random().Next(1,100)/10.0;
    }
}
void PrintArray(double[] array)
{
for (int i = 0; i<array.Length; i++)
{
    Console.Write(array[i]+ " ");
}
Console.WriteLine();
}