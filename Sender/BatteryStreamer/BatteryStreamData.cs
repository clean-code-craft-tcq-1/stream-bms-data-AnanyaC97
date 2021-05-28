using System;
using System.Collections.Generic;

namespace BatteryStreamer
{
    public class BatteryStreamData
    {
        public static bool IsReadingCountGreaterThan15(int readingCount)
        {
            return readingCount >= 15 ? true : false;
        }

        public List<BatteryConstants> BatteryReadings = new List<BatteryConstants>();
        public void CreateBatteryMeasureReadingsList(int Readingcount)
        {
            for (int count = 1; count <= Readingcount; count++)
            {
                double temperature = GenerateTemperatureValue();
                double chargeRate = GenerateChargeRateValue();
                BatteryReadings.Add(new BatteryConstants(temperature, chargeRate));
            }
        }
        public double GenerateTemperatureValue()
        {
            return GenerateRandomNumber(BatteryConstants.MinTemperature, BatteryConstants.MaxTemperature);
        }
        public double GenerateChargeRateValue()
        {
            return GenerateRandomNumber(BatteryConstants.MinChargeRate, BatteryConstants.MaxChargeRate);
        }
        public void PrintBatteryMeasureReadings()
        {
            foreach (var readings in BatteryReadings)
            {
                Console.WriteLine("Temperature: " + readings.Temperature + " Charge Rate: " + readings.ChargeRate);
            }
        }
        public double GenerateRandomNumber(double minValue, double maxValue)
        {
            Random random = new Random();
            double RandomValue = Math.Round((random.NextDouble() * (maxValue - minValue) + minValue), 2);
            return RandomValue;
        }
    }
}
