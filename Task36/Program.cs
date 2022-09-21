//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
int[] array = new int[10];

void SummNumber(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            result+=array[i];
            
            i++;

        }
    }
    Console.WriteLine($"сумма чисел на нечетных позициях :{result} ");
}

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(0, 100);
        index++;
    }
}

void PrintArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write($"{array[index]}, ");
        index++;
    }
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
SummNumber(array);




