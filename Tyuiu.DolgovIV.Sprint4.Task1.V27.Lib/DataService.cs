using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DolgovIV.Sprint4.Task1.V27.Lib
{
    public class DataService : ISprint4Task1V27
    {
        public int Calculate(int[] array)
        {
            int c = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    c *= array[i];
                }
            }
            return c;
        }
    }
}
