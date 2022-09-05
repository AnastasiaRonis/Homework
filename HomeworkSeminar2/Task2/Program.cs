// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5, 78 -> третьей цифры нет, 32679 -> 6

Console.Write("Введите трехзначное число: ");
int x = Convert.ToInt32(Console.ReadLine()); 
int num = x%10;
Console.WriteLine(num);

if (num>3)
{
  Console.WriteLine("третья цифра -> " + num);
}
else if (num<3) 
{
  Console.WriteLine("третьей цифры нет -> ");
}

// Console.Write("Введите трехзначное число: ");
// int x = Convert.ToInt32(Console.ReadLine()); 
// int num = x%10;
// Console.WriteLine(num);



// if(num<3) 
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else if(num>3) 
// {
//     Console.WriteLine(num);
// }



// Console.Write("Введите трехзначное число: ");
// int a = Convert.ToInt32(Console.ReadLine()); 
// int b = a%10;
// Console.WriteLine(b);

// while (--b) 
//     {
//         a /= 10;
//     }
    
// return x % 10;


// int number(int a, int b);
// int count = a.Length;
// {
//     if(a<3 || a.Length == 3) 
//     {
//         Console.WriteLine("Третьей цифры нет");
//     }
//     else if(a>3 || a.Length == 3)
//     {
//         Console.WriteLine(number(b));
//     }
//     return a%10;
// }



