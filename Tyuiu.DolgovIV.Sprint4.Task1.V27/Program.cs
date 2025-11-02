using Tyuiu.DolgovIV.Sprint4.Task1.V27.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите кол-во элементов массива");
        int len = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[len];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Введите значение " + i + " элемента массива: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine(ds.Calculate(array));


        Console.ReadKey();
    }
}