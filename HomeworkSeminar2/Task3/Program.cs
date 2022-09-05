// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да, 7 -> да, 1 -> нет

// Console.WriteLine("Введите цифру, которая обозначает день недели: ");
// int DayNumber = Convert.ToInt32(Console.ReadLine()); 

// if(DayNumber == 6 || DayNumber  == 7)
// {
//     Console.WriteLine("Да, этот день выходной");
// }
// else if(DayNumber > 1 && DayNumber > 7)
// {
//     Console.WriteLine("Такого дня недели не существует");
// }
// else
// {
//     Console.WriteLine("Этот день рабочий");
// }

// Функция

Console.WriteLine("Введите цифру, которая обозначает день недели: ");
int DayNumber = Convert.ToInt32(Console.ReadLine()); 

void WeekNumber (int DayNumber)
{
    if(DayNumber == 6 || DayNumber  == 7)
    {
        Console.WriteLine("Да, этот день выходной");
    }
    else if(DayNumber < 1 || DayNumber > 7)
    {
        Console.WriteLine("Такого дня недели не существует");
    }
    else
    {
        Console.WriteLine("Этот день рабочий");
    }
}
WeekNumber(DayNumber);