using System;

namespace remoteCall
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter two digits");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            var myService = new PlusMinus.PlusMinusService();
            var results = myService.Plus(a, b);
            Console.WriteLine(results);


        }
    }
}
