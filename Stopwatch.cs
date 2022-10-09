using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Stopwatch
    {
        public static void MeasureTime()
        {
            Console.WriteLine("Type 'start' to start the stopwatch");
            string srt = Console.ReadLine();

            long start = Environment.TickCount;
            Console.WriteLine(start);
            if (srt.Equals("start"))
            {
                Console.WriteLine("Type 'stop' to stop the stopwatch");
                string stp = Console.ReadLine();

                while (!stp.Equals("stop"))
                {
                    Console.WriteLine("Type 'stop' to stop the stopwatch");

                }
                long stop = Environment.TickCount;
                long time = stop - start;
                Console.WriteLine("Elapsed Time in ms = " + time);
                Console.WriteLine("Elapsed Time in sec = " + time / 1000);
            }
            else
            {
                Console.WriteLine("Wrong Input");

            }

        }
    }
}