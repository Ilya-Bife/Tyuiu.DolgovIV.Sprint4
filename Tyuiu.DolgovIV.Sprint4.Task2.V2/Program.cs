using Tyuiu.DolgovIV.Sprint4.Task2.V2.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Random random = new Random();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите кол-во элементов массива");
        int len = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[len];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1,9);
            Console.Write(array[i] + " ");
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine(ds.Calculate(array));


        Console.ReadKey();
    }
}