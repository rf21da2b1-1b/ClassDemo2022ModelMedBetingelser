using System;

namespace ClassDemo2022ModelMedBetingelser
{
    class Program
    {
        static void Main(string[] args)
        {
            BetingelsesWorker worker = new BetingelsesWorker();
            worker.Start();


            Console.WriteLine("Hello World!");
        }
    }
}
