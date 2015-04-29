namespace TplExamlpe
{
    using System;
    using System.Threading;

    public class Program
    {
        public static void Main(string[] args)
        {
            var result = SlowOpernation();

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Slow operation result: {0}", result);
            Console.WriteLine("Main complete on {0}", 
                Thread.CurrentThread.ManagedThreadId);
        }

        private static int SlowOpernation()
        {
            Console.WriteLine("Slow operation started on {0}",
                Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(2000);
            Console.WriteLine("Slow operation complete on {0}",
                Thread.CurrentThread.ManagedThreadId);

            return 42;
        }
    }
}
