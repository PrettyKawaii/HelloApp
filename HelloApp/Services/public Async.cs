using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HelloApp.Services
{
    public class Async
    {
        public static Random random = new Random();
        

        public async void Method1()
        {
            await Task.Run(() => Sleep());
            Console.WriteLine("Method1");
            
        }

        public async void Method2()
        {
            await Task.Run(() => Sleep());
            Console.WriteLine("Method2");
        }

        public void Sleep()
        {
            int mseconds = random.Next(2, 4) * 100;
            Thread.Sleep(mseconds);
        }
    }
}
