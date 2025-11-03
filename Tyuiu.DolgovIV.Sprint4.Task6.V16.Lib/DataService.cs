using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DolgovIV.Sprint4.Task6.V16.Lib
{
    public class DataService : ISprint4Task6V16
    {
        public string[] Calculate(string[] array)
        {
            
            int i = 0;
            foreach (var item in array)
            {
                if (item.Length == 7)
                {
                    i++;
                }
            }
            string[] res = new string[i];
            i = 0;
            foreach (var item in array)
            {
                if (item.Length == 7)
                {
                    res[i] = item;
                    i++;
                }
            }
            return res;
        }
    }
}
