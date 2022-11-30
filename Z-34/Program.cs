// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива:");
var array = FillArray(Convert.ToInt32(Console.ReadLine()));
Print(array);
Console.WriteLine();
Console.Write($"Четных чисел: {Sum(array)}");

int Sum(int[] array)
{
int sum = 0;
    foreach(int item in array)
    {
        if(item % 2 == 0)
{
sum ++;
}
    }
return sum;
}

int[] FillArray(int length)
{
int[] array = new int[length];
for(int i = 0; i < length; i++)
{
array[i] = new Random().Next(0, 101);
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
