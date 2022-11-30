// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.WriteLine("Введите размер массива:");
var array = FillArray(Convert.ToInt32(Console.ReadLine()));
Print(array);
Console.WriteLine();
Console.Write($"Сумма элементов: {Sum(array)}");

int Sum(int[] array)
{
int sum = 0;
    for(int i = 0; i< array.Length; i=i+2)
    {
        sum = sum + array[i];
    }
return sum;
}

int[] FillArray(int length)
{
int[] array = new int[length];
for(int i = 0; i < length; i++)
{
array[i] = new Random().Next(-100, 101);
}
return array;
}

void Print(int[] array)
{
foreach(var item in array)
{
Console.Write($"{item}, ");
}
}
