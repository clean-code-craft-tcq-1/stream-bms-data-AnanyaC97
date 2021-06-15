using System;

namespace BatteryStreamer
{
    public class BatteryStreamData
    {
        BatteryGenerateData batteryGenerateData = new BatteryGenerateData();
        public bool IsReadingListEmpty()
        {
            return batteryGenerateData.BatteryReadings.Count == 0 ? true : false;
        }
        
        public void StreamData(int count)
        {
            while(!Console.KeyAvailable)
            {
                batteryGenerateData.GenerateBatteryReadings();
                Console.WriteLine("Temperature: " + batteryGenerateData.BatteryReadings[count].Temperature + " Charge Rate: " + batteryGenerateData.BatteryReadings[count].ChargeRate);
                System.Threading.Thread.Sleep(1000);
                count++;
            }
        }
    }
}
