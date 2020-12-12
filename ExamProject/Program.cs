using System;

namespace ExamProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //exception handling

            try
            {
                Console.WriteLine("Welcome to LegalX!");
                Processor p = new Processor();
                p.EntrySystem();
           
         



            }

            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
                Console.WriteLine("Press any key to start the system again");
                Console.ReadKey();
            }

            finally
            {
                Console.WriteLine("Welcome to LegalX!");
                Processor p = new Processor();
                p.EntrySystem();
            }
         
        }
    }
}

