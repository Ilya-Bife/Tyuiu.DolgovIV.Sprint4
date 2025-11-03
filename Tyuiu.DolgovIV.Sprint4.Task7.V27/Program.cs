using Tyuiu.DolgovIV.Sprint4.Task7.V27.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Дана строка из одноразрядных цифр  583197256891");
        string inp = "583197256891";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");


        
        Console.WriteLine(ds.Calculate(4,3,inp));


        Console.ReadKey();
    }
}