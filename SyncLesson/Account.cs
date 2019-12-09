using System;

namespace SyncLesson
{
    public class Account
    {
        private object syncObject = new object();
        public int Sum { get; set; } = 1000;
        
        public void ProcessMoney(object sum)
        {
            lock (syncObject)
            {
                Sum += (int)sum;
                Console.WriteLine(Sum);
            }
        }
    }
}
