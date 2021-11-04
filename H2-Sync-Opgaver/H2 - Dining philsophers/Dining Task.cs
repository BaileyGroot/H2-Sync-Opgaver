using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;


namespace H2_Sync_Opgaver.H2___Dining_philsophers
{
    class Dining_Task
    {
        Random random = new Random();
        private bool[] fork = new bool[5];

        public string Name { get; private set; }
        public int Rightfork { get; private set; }
        public int Leftfork { get; private set; }

        public Dining_Task(string name, int rightfork, int leftfork)
        {
            Name = name;
            Rightfork = rightfork;
            Leftfork = leftfork;
        }


        void RunProgram()
        {
            while (true)
            {
                Eat();
                Think();
            }
        }

        void Eat()
        {
            bool ItsEating = false;
            lock(this)
                if (fork[Rightfork] && fork[Leftfork])
                {
                    ItsEating = true;
                    fork[Rightfork] = true;
                    fork[Leftfork] = true;
                    Thread.Sleep(2000 + random.Next(4000));
                    fork[Rightfork] = false;
                    fork[Leftfork] = false;
                }
        }
        void Think()
        {
            Thread.Sleep(7000 + random.Next(13000));
        }

        static void RunDining()
        {
            Dining_Task u1 = new Dining_Task("Per", 0, 1);
            Dining_Task u2 = new Dining_Task("Marc", 1, 2);
            Dining_Task u3 = new Dining_Task("Kenneth", 2, 3);
            Dining_Task u4 = new Dining_Task("Louise", 3, 4);
            Dining_Task u5 = new Dining_Task("Simon", 4, 5);

            Thread t1 = new Thread();
        }
    }
}
