namespace ExtendedTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Main*/
            Car carobj = new Car();
            carobj.Start();
            Console.WriteLine("Enter to exit");
            Console.ReadLine();
        }
    }
}