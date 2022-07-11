// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Write("ВВедите размер массива ");
int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[n];
FillArray(numbers);
PrintArray(numbers);
int count = 0;

for(int i = 0; i<numbers.Length; i++)
{
    if (numbers[i]%2==0)
    {
        count++;
    }
}
Console.WriteLine($"Количество четных чисел в массиве - {count}");

void FillArray(int[] array)
{
 for (int i = 0; i<array.Length; i++)
{
    array[i] = new Random().Next(100,1000);
}   
}

void PrintArray(int[] array)
{
for (int i = 0; i<array.Length; i++)
{
    Console.Write(array[i]+ " ");
}
Console.WriteLine();
}