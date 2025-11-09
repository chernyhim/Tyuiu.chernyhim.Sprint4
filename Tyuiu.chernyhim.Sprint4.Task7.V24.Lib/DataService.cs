using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.chernyhim.Sprint4.Task7.V24.Lib
{
    public class DataService : ISprint4Task7V24
    {
        public int Calculate(int n, int m, string value)
        {
            int mult = 1;
            for (int i = 0; i < value.Length; i++)
            {
                if(Convert.ToInt32(value[i]) % 2 == 0)
                {
                    mult *= Convert.ToInt32(value[i]) - '0';
                }
            }            
            return mult;
        }
    }
}
