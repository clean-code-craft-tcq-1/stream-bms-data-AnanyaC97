using System;

namespace BatteryStreamer
{
    public class Program
    {
        public static int readingCount = 0;
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of readings to be considered - Minimum 15");
            readingCount = int.Parse(Console.ReadLine());

            if (BatteryStreamData.IsReadingCountGreaterThan15(readingCount))
            {
                StreamBatteryReadings();
            }
            else
            {
                Console.WriteLine("Minimum readings value should be 15");
            }
        }

        public static void StreamBatteryReadings()
        {
            BatteryStreamData batteryStreamData = new BatteryStreamData();
            for (int count = 0; count < readingCount; count++)
            {
                batteryStreamData.GenerateBatteryReadings();
                Console.WriteLine("Temperature: " + batteryStreamData.BatteryReadings[count].Temperature + " Charge Rate: " + batteryStreamData.BatteryReadings[count].ChargeRate);
                System.Threading.Thread.Sleep(5000);
            }
        }
    }
}
