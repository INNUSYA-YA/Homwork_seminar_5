// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.Write("ВВедите размер массива ");
int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[n];
int sum = 0;
FillArray(numbers);
PrintArray(numbers);
for(int i = 0; i<numbers.Length;i++)
{
    if(i%2!=0)
    {
        sum += numbers[i];
    }
}
Console.WriteLine($"сумма элементов, стоящих на нечетных позициях равна {sum}");

void FillArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
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