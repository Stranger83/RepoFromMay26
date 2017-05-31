using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int beatsPerMinute = int.Parse(Console.ReadLine());
            int numberOfBeats = int.Parse(Console.ReadLine());

            double bars = numberOfBeats / 4.0;
            double beatsPerSecond = beatsPerMinute / 60.0;
            double totalSeconds = numberOfBeats / beatsPerSecond;
            double minutes = totalSeconds / 60;
            double seconds = totalSeconds % 60;

            Console.WriteLine($"{Math.Round(bars, 1)} bars - {(int)minutes}m {(int)seconds}s");
        }
    }
}
