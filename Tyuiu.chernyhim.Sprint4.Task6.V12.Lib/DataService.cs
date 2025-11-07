using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.chernyhim.Sprint4.Task6.V12.Lib
{
    public class DataService : ISprint4Task6V12
    {
        public string[] Calculate(string[] array)
        {
            int count = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i].Length == 7)
                {
                    count++;
                }
            }
            string[] result = new string[count];
            int num = 0;
            foreach(var item in array)
            {
                if (item.Length == 7)
                {
                    result[num] = item;
                    num++;
                }
            }
            return result;
        }
    }
}
