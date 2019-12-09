using System;

namespace SyncLesson
{

    [Synchronization]
    public class Account : ContextBoundObject
    {
        private object syncObject = new object();
        public int Sum { get; set; } = 1000;

        public void ProcessMoney(object sum)
        {
            Sum += (int)sum;
            Console.WriteLine(Sum);
        }
    }
}
