using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BatteryStreamer.Test
{
    [TestClass]
    public class BatteryTest
    {
        [TestMethod]
        public void GivenNoReadings_WhenListIsEmpty_ReturnsTrue()
        {
            Assert.IsTrue(new BatteryStreamData().IsReadingListEmpty());
        }
        [TestMethod]
        public void GivenReadingCount_WhenListIsNotEmpty_CreatesReadingRange()
        {
            BatteryGenerateData batteryGenerateData = new BatteryGenerateData();
            for(int count = 0; count <=15; count++)
            {
                batteryGenerateData.GenerateBatteryReadings();
            }
            Assert.IsNotNull(batteryGenerateData.BatteryReadings);
        }
        [TestMethod]
        public void GetRandomNumber_WhenWithinGivenRange()
        {
            double randomNumber = new BatteryGenerateData().GenerateRandomNumber(0, 10);
            Assert.IsTrue(randomNumber >= 0 && randomNumber <= 10);
        }
        [TestMethod]
        public void GetTemperature_WhenWithinGivenRange()
        {
            double temperature = new BatteryGenerateData().GenerateTemperatureValue();
            Assert.IsTrue(temperature <= BatteryConstants.MaxTemperature && temperature >= BatteryConstants.MinTemperature);
        }
        [TestMethod]
        public void GetChargeRate_WhenWithinGivenRange()
        {
            double ChargeRate = new BatteryGenerateData().GenerateChargeRateValue();
            Assert.IsTrue(ChargeRate <= BatteryConstants.MaxChargeRate && ChargeRate >= BatteryConstants.MinChargeRate);
        }
    }
}
