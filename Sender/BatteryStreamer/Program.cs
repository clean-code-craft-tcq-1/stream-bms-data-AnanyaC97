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
                for(int count = 0; count < readingCount; count++)
                {
                    batteryStreamData.GenerateBatteryReadings();
                    Console.WriteLine("Temperature: " + batteryStreamData.BatteryReadings[count].Temperature + " Charge Rate: " + batteryStreamData.BatteryReadings[count].ChargeRate);
                    System.Threading.Thread.Sleep(5000);
                }
            }
            else
            {
                Console.WriteLine("Minimum readings value should be 15");
            }
        }
    }
}
