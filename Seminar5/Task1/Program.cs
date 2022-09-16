// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int size = 4;
int [] array = new int [size];
FillArray(array);
Console.WriteLine("[{0}]", string.Join(",", array));
FindChet(array);

void FillArray (int [] array)
{
    for(int i=0; i<array.Length; i++)
    array[i] = new Random().Next(101,999);
}

void FindChet (int[] array)
{
        for(int i=0; i<array.Length; i++)
        {
            if(i%2==0)
            Console.WriteLine(i);
        }
    Console.WriteLine();
}


