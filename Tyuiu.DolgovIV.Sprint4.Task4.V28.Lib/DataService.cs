using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DolgovIV.Sprint4.Task4.V28.Lib
{
    public class DataService : ISprint4Task4V28
    {
        public int[,] Calculate(int[,] matrix)
        {
            int c = 0;
            int[,] res = matrix; 
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        res[i, j] = 1;
                    }
                }
            }
            return res;
        }
    }
}
