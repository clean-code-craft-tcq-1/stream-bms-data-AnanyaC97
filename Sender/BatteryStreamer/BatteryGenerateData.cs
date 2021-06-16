using System;
using System.Collections.Generic;

namespace BatteryStreamer
{
    public class BatteryGenerateData : IBatteryGenerateData
    {
        public List<BatteryConstants> BatteryReadings = new List<BatteryConstants>();
        public void GenerateBatteryReadings()
        {
            double temperature = GenerateTemperatureValue();
            double chargeRate = GenerateChargeRateValue();
            BatteryReadings.Add(new BatteryConstants(temperature, chargeRate));
            BatteryConstants.BatteryReadingCount++;
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
