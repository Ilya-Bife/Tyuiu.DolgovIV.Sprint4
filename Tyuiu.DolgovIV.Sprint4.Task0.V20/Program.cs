using Tyuiu.DolgovIV.Sprint4.Task0.V20.Lib;


internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x1 = Convert.ToInt32(Console.ReadLine());
        int x2 = Convert.ToInt32(Console.ReadLine());
        int x3 = Convert.ToInt32(Console.ReadLine());
        int x4 = Convert.ToInt32(Console.ReadLine());
        int x5 = Convert.ToInt32(Console.ReadLine());
        int x6 = Convert.ToInt32(Console.ReadLine());
        int x7 = Convert.ToInt32(Console.ReadLine());
        int x8 = Convert.ToInt32(Console.ReadLine());
        int x9 = Convert.ToInt32(Console.ReadLine());
        int x10 = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int[] array = { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };
        Console.WriteLine(ds.GetMultEvenArrEl(array));


        Console.ReadKey();
    }
}