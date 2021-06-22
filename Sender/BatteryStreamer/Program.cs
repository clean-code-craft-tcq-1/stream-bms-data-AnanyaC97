using System;
using System.Threading;

namespace BatteryStreamer
{
    public class Program
    {
        public static bool stopStreaming = false;
        public static void Main(string[] args)
        {
            Console.WriteLine("The Battery readings are: (Press Ctrl-C to Exit) ");
            Console.CancelKeyPress += (sender, EventArgs) => { stopStreaming = true; EventArgs.Cancel = true; };
            StreamBatteryReadings();
        }

        public static void StreamBatteryReadings()
        {
            while (!stopStreaming)
            {
                new BatteryStreamData().StreamData();
            }
        }
    }
}
