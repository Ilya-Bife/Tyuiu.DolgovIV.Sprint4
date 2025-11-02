using Tyuiu.DolgovIV.Sprint4.Task3.V3.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[,] arr =
        {
            { 9, 4, 5, 4, 8},
            { 7, 6, 7, 7, 4,},
            { 4, 4, 3, 5, 6,},
            { 6, 5, 9, 4, 9,},
            { 9, 7, 8, 7, 7}
         };

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine(ds.Calculate(arr));


        Console.ReadKey();
    }
}