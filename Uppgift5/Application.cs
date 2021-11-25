using System;

namespace Exam
{
    class Application
    {
        public void Run()
        {
            try
            {
                Method1();
            }
            catch
            {
                Console.WriteLine("FormatException happend");
                return;
            }
            try
            {
                Method2();
            }
            catch
            {
                Console.WriteLine("ArgumentException happend");
                return;
            }
            Console.WriteLine("No errors here");
            //Om bägge metoder går igenom visas den här.
            //Om man skulle visa den om bara en metod gick igenom
            //skulle man sätta den här i TRY blocket efter metoden.
        }

        private void Method1()
        {
            if (new Random().Next(0, 2) < 1)
            {
                throw new FormatException("Error in method1");
            }
        }

        private void Method2()
        {
            if (new Random().Next(0, 2) < 1)
            {
                throw new ArgumentException("Error in method2");
            }
        }
    }
}
