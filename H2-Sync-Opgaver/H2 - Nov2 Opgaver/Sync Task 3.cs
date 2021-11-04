using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;

namespace H2_Sync_Opgaver.H2___Nov2_Opgaver
{
    class Sync_Task_3
    {
        static int count = 0;
        object locked = new object();

        void Hashtag()
        {
            while (count < 1000)
            {
                Monitor.Enter(locked);
                count = count + 60;
                Console.WriteLine("************************************************************" + count);
                Thread.Sleep(1000);
                Monitor.Exit(locked);
            }
        }

        void Star()
        {
            while (count < 1000)
            {
                Monitor.Enter(locked);
                count = count + 60;
                Console.WriteLine("############################################################" + count);
                Thread.Sleep(1000);
                Monitor.Exit(locked);
            }
        }



        public static void Run2()
        {
            Sync_Task_3 obj = new Sync_Task_3();
            Thread thread = new Thread(obj.Hashtag);
            Thread thread1 = new Thread(obj.Star);

            thread.Start();
            thread1.Start();

        }
    }
}
