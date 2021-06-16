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
            do
            {
                new BatteryStreamData().StreamData();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
