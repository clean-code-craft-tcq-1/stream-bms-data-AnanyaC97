using System;

namespace BatteryStreamer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The Battery readings are: (Press Escape to Exit) ");
            StreamBatteryReadings();
        }

        public static void StreamBatteryReadings()
        {
            BatteryStreamData batteryStreamData = new BatteryStreamData();
            int count = 0;
            do
            {
                batteryStreamData.StreamData(count);
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
