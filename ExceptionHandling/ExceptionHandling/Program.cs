using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main()
        {
            try
            {
                Person ti = new Person("niki", "ok" , -92);
            }
            catch(ArgumentOutOfRangeException  ex)
            {
                Console.WriteLine("Exception thrown : {0}",ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Exception thrown : {0}",ex.Message);
            }

            //person toj = new person("niki",null, 92);
            //person tq = new person("", "jordanov", 92);
            //person to = new person(null, "jordanov", 92);
            //person nie = new person("bogdan", "jordanov", 125);
            //Person vie = new Person("bogdan", "jordanov", -92);
        }
    }
}
