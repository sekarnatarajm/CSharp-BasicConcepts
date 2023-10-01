using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    public class AsyncAwait
    {
        public int RowCount { get; set; } = 2000;
        public async void MainMethod()
        {
            var timer = new Stopwatch();
            timer.Start();
            Method_1();
            Method_2();
            Method_3();
            timer.Stop();
            TimeSpan timeTaken = timer.Elapsed;
            string normalMethod = "Time taken for normal method: " + timeTaken.ToString(@"m\:ss\.fff");

            timer.Restart();
            timer.Start();
            Task<int> one = Method_1_Async();
            Task two = Method_2_Async();
            Task three = Method_3_Async();

            int count = await one;
            Task four = Method_4_Async(RowCount);

            Task.WaitAll(new Task[] { four, two, three });
            timer.Stop();
            TimeSpan timeTakenAsync = timer.Elapsed;
            string asyncMethod = "Time taken for async normal method: " + timeTakenAsync.ToString(@"m\:ss\.fff");
            Console.WriteLine(normalMethod);
            Console.WriteLine(asyncMethod);
        }

        public void Method_1()
        {
            for (int i = 1; i < RowCount; i++)
            {
                Console.WriteLine(" Method 1");
            }
        }

        public void Method_2()
        {
            for (int i = 1; i < RowCount; i++)
            {
                Console.WriteLine(" Method 2");
            }
        }

        public void Method_3()
        {
            for (int i = 1; i < RowCount; i++)
            {
                Console.WriteLine(" Method 3");
            }
        }

        public async Task<int> Method_1_Async()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 1; i < RowCount; i++)
                {
                    Console.WriteLine("Async Method 1 {0}", i);
                    count++;
                }
            });
            return count;
        }

        public async Task Method_2_Async()
        {
            await Task.Run(() =>
            {
                for (int i = 1; i < RowCount; i++)
                {
                    Console.WriteLine("Async Method 2 {0}", i);
                }
            });
        }

        public async Task Method_3_Async()
        {
            await Task.Run(() =>
            {
                for (int i = 1; i < RowCount; i++)
                {
                    Console.WriteLine("Async Method 3 {0}", i);
                }
            });
        }

        public async Task Method_4_Async(int count)
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Method 1 Count = {0}", count);
            });
        }
    }
}
