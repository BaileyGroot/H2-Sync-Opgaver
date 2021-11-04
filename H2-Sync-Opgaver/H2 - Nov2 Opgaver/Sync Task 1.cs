using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;


namespace H2_Sync_Opgaver.H2___Nov2_Opgaver
{
    public class Sync_Task_1
    {
        // Static
        static int x = 0;

        // Object to lock
        object locked = new object();

        // Method that counts down
         void Countdown()
        {
            while (true)
            {
                Monitor.Enter(locked);
                x = x - 2;
                Console.WriteLine(x);
                Thread.Sleep(1000);
                Monitor.Exit(locked);
            }
            
        }
        // Method that counts up.
        void CountUp()
        {
            while (true)
            {
                Monitor.Enter(locked);
                x = x + 1;
                Console.WriteLine(x);
                Thread.Sleep(1000);
                Monitor.Exit(locked);
            }
        }


    public static void Run()
    {
            // Getting the object in the class
            Sync_Task_1 obj = new Sync_Task_1();

            // Threads
            Thread thread = new Thread(obj.Countdown);
            Thread thread2 = new Thread(obj.CountUp);

            // Running the threads
            thread.Start();
            thread2.Start();
        }
    }
}
