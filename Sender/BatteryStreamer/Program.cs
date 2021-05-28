using System;

namespace BatteryStreamer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of readings to be considered - Minimum 15");
            int readingCount = int.Parse(Console.ReadLine());

            if (BatteryStreamData.IsReadingCountGreaterThan15(readingCount))
            {
                BatteryStreamData batteryStreamData = new BatteryStreamData();
                batteryStreamData.CreateBatteryMeasureReadingsList(readingCount);
                batteryStreamData.PrintBatteryMeasureReadings();
            }
            else
            {
                Console.WriteLine("Please provide the valid number!!!");
            }
        }
    }
}
