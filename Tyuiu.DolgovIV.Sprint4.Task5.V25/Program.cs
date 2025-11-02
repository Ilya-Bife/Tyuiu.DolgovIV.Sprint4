using Tyuiu.DolgovIV.Sprint4.Task5.V25.Lib;

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

        int[,] array = new int[len,len];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = random.Next(-4, 3);
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine(ds.Calculate(array));


        Console.ReadKey();
    }
}