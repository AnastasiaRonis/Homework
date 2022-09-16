// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] array = new double [5];
Random rand=new Random();
FillArray(array);
DifMinMax(array);

void FillArray (double[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        array[i]=rand.NextDouble()*100;
        Console.Write("{0,6:F2}", array[i]);
    }
}

void DifMinMax (double[] array)
{
    double max=array[0];
    double min=array[0];
    double dif=0;
    for(int i=1; i<array.Length; i+=2)
    {
        if(max-min==dif)
        dif=array[i];
        Console.WriteLine(dif);
    }
}
