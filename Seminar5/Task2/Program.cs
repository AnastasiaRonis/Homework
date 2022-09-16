// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size = 5;
int [] array = new int [size];
FillArray(array);
Console.WriteLine("[{0}]", string.Join(",", array));
Console.WriteLine();
Nechetpoz(array);
Console.WriteLine();

void FillArray (int [] array)
{
    for(int i=0; i<array.Length; i++)
    array[i] = new Random().Next(0,100);
}

void Nechetpoz (int[] array)
{
    int sum =0;
    for(int i=1; i<array.Length; i+=2)
    sum+=array[i];
    Console.WriteLine(sum);
}
