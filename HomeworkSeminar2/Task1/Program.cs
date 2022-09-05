//Задача 10. Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5 782 -> 8  918 -> 1/

// Console.WriteLine("Введите трехзначное число: ");
// int x = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine(x);
// Console.WriteLine((x%100)/10);


// ФУНКЦИЯ:

Console.WriteLine("Введите трехзначное число: ");
int x = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine(x);

int number(int a)
{
    return x%100/10;
}
Console.WriteLine(number(x));
