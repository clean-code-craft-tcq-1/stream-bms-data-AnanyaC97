using System;

namespace BatteryStreamer
{
    public class BatteryStreamData
    {
        BatteryGenerateData batteryGenerateData = new BatteryGenerateData();
        public bool IsReadingListEmpty()
        {
            return BatteryConstants.BatteryReadingCount == 0 ? true : false;
        }
        
        public void StreamData()
        {
            batteryGenerateData.GenerateBatteryReadings();
            Console.WriteLine("Temperature: " + batteryGenerateData.BatteryReadings[0].Temperature + ", Charge Rate: " + batteryGenerateData.BatteryReadings[0].ChargeRate);
            System.Threading.Thread.Sleep(1000);
        }
    }
}
