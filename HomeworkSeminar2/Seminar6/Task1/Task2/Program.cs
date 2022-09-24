// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y = k1 * x + b1, y = k2 * x + b2
// k1 * x + b1 = k2 * x + b2
// (k1 - k2) * x = b2 - b1
// x = (b2 - b1) / (k1 - k2)
// y = k1 * x + b1

int b1 = DataEntry("b1= ");
int k1 = DataEntry("k1= ");
int b2 = DataEntry("b2= ");
int k2 = DataEntry("k2= ");
Console.WriteLine(Tochkaper(x, y));


int DataEntry(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Tochkaper(int x, int y)
{
    if ( ( k1 * b2 ) - ( k2 * b1 ) == 0 && ( k2 * b1 ) - ( k1 * b2 ) == 0 ) res = 0;
    return res; 
}   Console.WriteLine(res);



