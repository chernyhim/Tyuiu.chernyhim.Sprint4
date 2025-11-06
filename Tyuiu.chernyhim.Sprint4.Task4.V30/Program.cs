using Tyuiu.chernyhim.Sprint4.Task4.V30.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("Input number of rows and colums:");
        int rows = Convert.ToInt32(Console.ReadLine());
        int cols = rows;
        Console.WriteLine("Input array elements:");
        int[,] array = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.WriteLine("Input element [" + (i + 1) + "," + (j + 1) + "]:");
                array[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        int[,] result = ds.Calculate(array);
        Console.WriteLine("Array without odd nubers:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}