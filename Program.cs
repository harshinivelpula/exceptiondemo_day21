namespace ExceptionDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Temperature temperature = new Temperature();
                temperature.ShowTemp();
            }
            catch(TemperatureIsZeroException t)
            {
                Console.WriteLine(t.Message);
            }
                //int[]arr = new int[4];

            //    arr[0] = 8;
            //    arr[1] = 28;
            //    arr[2] = 33;
            //    arr[3] = 40;

            //    int a = 12, b = 0;
            //    int c = a / b;

            //    foreach (int i in arr)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //catch(IndexOutOfRangeException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch(DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
        }
    }
}