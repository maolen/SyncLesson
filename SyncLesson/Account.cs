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
            var semaphore = new Semaphore(3, 3);

            Sum += (int)sum;
            Console.WriteLine(Sum);

            semaphore.Release();
        }
    }
}
