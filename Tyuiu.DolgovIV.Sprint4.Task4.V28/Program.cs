using Tyuiu.DolgovIV.Sprint4.Task4.V28.Lib;

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

        int[,] array = new int[len,len];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("Введите значение " + i + " " + j + " элемента массива: ");
                array[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(ds.Calculate(array)[i, j] + " "); 
            }
            Console.WriteLine();
        }


        Console.ReadKey();
    }
}