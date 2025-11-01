using Tyuiu.chernyhim.Sprint4.Task0.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Input " + (1+i) + " number");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Summ of even numbers: " + ds.GetSumEvenArrEl(array));
    }
}