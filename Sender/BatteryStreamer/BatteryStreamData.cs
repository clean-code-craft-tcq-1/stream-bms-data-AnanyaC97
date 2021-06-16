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
            while(!Console.KeyAvailable)
            {
                batteryGenerateData.GenerateBatteryReadings();
                Console.WriteLine("Temperature: " + batteryGenerateData.BatteryReadings[BatteryConstants.BatteryReadingCount-1].Temperature + " Charge Rate: " + batteryGenerateData.BatteryReadings[BatteryConstants.BatteryReadingCount-1].ChargeRate);
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
