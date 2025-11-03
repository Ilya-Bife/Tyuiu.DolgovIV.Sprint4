using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DolgovIV.Sprint4.Task7.V27.Lib
{
    public class DataService : ISprint4Task7V27
    {
        public int Calculate(int n, int m, string value)
        {
            string str = value;
            int[,] matr = new int[n, m];
            int count = 0;
            n = 4;
            m = 3;

            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (global::System.Int32 j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i, j] = int.Parse(str[i * 3 + j].ToString());
                    if (matr[i, j] % 2 == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
