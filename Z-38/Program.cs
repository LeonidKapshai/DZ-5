// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.WriteLine("Введите размер массива:");
var array = FillArray(Convert.ToInt32(Console.ReadLine()));
Print(array);
Console.WriteLine();
Console.Write($"Разница элементов: {Sum(array)}");

int Sum(int[] array)
{
int sum = 0;
int max = array[0];
int min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
       if(array[i]> max)
       {
        max= array[i];
       } 
       if(array[i]< min)
       {
        min= array[i];
       } 
    }
    if(min<0)
    {
        sum=max+min;
    }
    else
    {
        sum=max-min;
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