using System;
using System.Threading;

namespace SyncLesson
{

    public class Account : ContextBoundObject
    {
        private object syncObject = new object();
        public int Sum { get; set; } = 1000;

        public void ProcessMoney(object sum)
        {
            Monitor.Enter(syncObject);

            Sum += (int)sum;
            Console.WriteLine(Sum);

            Monitor.Exit(syncObject);
        }
    }
}
