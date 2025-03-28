using System.Diagnostics;

namespace Stopwatch2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stopwatch2");

            //siin algab stopwatch

            //toimub for loop 1000 korda
            //seal sees sleep (10)
            //prindib välja iga tsükli number

            //stopwatch lõppeb ära

            //konsool näitab aega


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i <= 1000; i++)
            {
                Console.WriteLine("Cycle number: " + i);
                Thread.Sleep(10);
            }

            stopwatch.Stop();

            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);

            Console.WriteLine("Elapsed time: " + ts);

        }
    }
}
