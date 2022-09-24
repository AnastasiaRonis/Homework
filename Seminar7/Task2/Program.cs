// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] array = new int[,] {
{1, 4, 7, 2},
{5, 9, 2, 3},
{8, 4, 2, 4},
};
FillArray(array);
PrintArray(array);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void PrintArray(int[,] array)
{
    
    for (int i = 0; i < array.GetLength(0)+1; i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            System.Console.WriteLine("Введите x: ");
            int x = Convert.ToInt32(Console.ReadLine());    
            bool w = false;
            if (array[i, j] >= x)
            {
                w = true;
            }
            if (w == false)
            {
                Console.WriteLine("Не присутствует");
                Console.WriteLine();
            }
            else Console.WriteLine("Присутствует");
                Console.WriteLine();
        }        
        break;
    }
}
