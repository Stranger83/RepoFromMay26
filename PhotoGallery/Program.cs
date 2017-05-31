using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int sizeBytes = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string orientation = "";
            double size = sizeBytes;
            string sizeUnit = "B";

            if (width > height)
            {
                orientation = "landscape";
            }
            else if (height > width)
            {
                orientation = "portrait";
            }
            else
            {
                orientation = "square";
            }

            if (sizeBytes >= 1000000)
            {
                size = sizeBytes / 1000000.0;
                sizeUnit = "MB";
            }
            else if (sizeBytes >= 1000 && sizeBytes < 1000000)
            {
                size = sizeBytes / 1000.0;
                sizeUnit = "KB";
            }
            Console.WriteLine($"Name: DSC_{num:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year} {hour:D2}:{minutes:D2}");
            Console.WriteLine($"Size: {size}{sizeUnit}");
            Console.WriteLine($"Resolution: {width}x{height} ({orientation})");
        }
    }
}
