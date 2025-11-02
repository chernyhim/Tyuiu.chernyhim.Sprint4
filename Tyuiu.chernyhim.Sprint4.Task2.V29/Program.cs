using Tyuiu.chernyhim.Sprint4.Task2.V29.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Random rnd = new Random();
        Console.WriteLine("Input array lenght:");
        int len = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[len];
        for (int i = 0; i < len; i++)
        {
            array[i] = rnd.Next(1, 8);
        }
        Console.WriteLine("Array's elements:");
        for (int i = 0;i < len; i++)
        {
            Console.Write(array[i]+" ");
        }
        Console.WriteLine("");
        Console.WriteLine("Mult of even numbers: "+ ds.Calculate(array));
    }
}