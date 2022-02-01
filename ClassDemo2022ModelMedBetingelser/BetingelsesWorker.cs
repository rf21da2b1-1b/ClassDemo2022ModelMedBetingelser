using System;
using ClassDemo2022ModelMedBetingelser.model;

namespace ClassDemo2022ModelMedBetingelser
{
    public class BetingelsesWorker
    {
        public BetingelsesWorker()
        {
        }

        public void Start()
        {
            Person p1 = new Person();
            try
            {
                p1 = new Person(1,"Peter", "Roskilde", 131);
           
                p1.Name = "Peter";
                p1.Alder = 5;
                Console.WriteLine(p1);

                p1.Alder = -1;
                Console.WriteLine(p1);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

            try
            {
                p1.Alder = 131;
                Console.WriteLine(p1);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

        }
    }
}