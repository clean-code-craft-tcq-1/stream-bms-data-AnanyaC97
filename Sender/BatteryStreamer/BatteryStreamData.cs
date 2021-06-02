using System;
using System.Collections.Generic;

namespace BatteryStreamer
{
    public class BatteryStreamData : IBatteryStreamData
    {
        public List<BatteryConstants> BatteryReadings = new List<BatteryConstants>();
        public static bool IsReadingCountGreaterThan15(int readingCount)
        {
            return readingCount >= 15 ? true : false;
        }
        public void GenerateBatteryReadings()
        {
            double temperature = GenerateTemperatureValue();
            double chargeRate = GenerateChargeRateValue();
            BatteryReadings.Add(new BatteryConstants(temperature, chargeRate));
        }
        public double GenerateTemperatureValue()
        {
            return GenerateRandomNumber(BatteryConstants.MinTemperature, BatteryConstants.MaxTemperature);
        }
        public double GenerateChargeRateValue()
        {
            return GenerateRandomNumber(BatteryConstants.MinChargeRate, BatteryConstants.MaxChargeRate);
        }
        public double GenerateRandomNumber(double minValue, double maxValue)
        {
            Random random = new Random();
            return Math.Round((random.NextDouble() * (maxValue - minValue) + minValue), 2);
        }
    }
}
