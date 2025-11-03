using Tyuiu.DolgovIV.Sprint4.Task6.V16.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Дан строковый массив данных  [\"Автомобиль\", \"Велосипед\", \"Самолет\", \"Поезд\", \"Трамвай\", \"Троллейбус\", \"Метро\"]");
        string[] inp = { "Автомобиль", "Велосипед", "Самолет", "Поезд", "Трамвай", "Троллейбус", "Метро" };

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        for (int i = 0; i < inp.Length; i++)
        {
            Console.WriteLine(ds.Calculate(inp)[i]);
        }
       
        Console.ReadKey();
    }
}