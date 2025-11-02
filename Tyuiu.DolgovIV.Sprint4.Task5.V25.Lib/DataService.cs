using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DolgovIV.Sprint4.Task5.V25.Lib
{
    public class DataService : ISprint4Task5V25
    {
        public int Calculate(int[,] matrix)
        {
            int c = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        c += matrix[i,j];
                    }
                }
            }
            return c;
        }
    }
}
