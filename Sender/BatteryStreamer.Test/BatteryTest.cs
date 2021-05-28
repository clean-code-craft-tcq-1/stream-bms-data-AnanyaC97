using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BatteryStreamer.Test
{
    [TestClass]
    public class BatteryTest
    {
        [TestMethod]
        public void GivenReadingCount_WhenLessThan15_ReturnsFalse()
        {
            Assert.IsFalse(BatteryStreamData.IsReadingCountGreaterThan15(int.Parse("5")));
        }
        [TestMethod]
        public void GivenReadingCount_WhenGreaterThanOrEqualTo15_ReturnsTrue()
        {
            Assert.IsTrue(BatteryStreamData.IsReadingCountGreaterThan15(int.Parse("15")));
        }
        [TestMethod]
        public void GivenReadingCount_WhenGreaterThanOrEqualTo15_CreatesReadingRange()
        {
            BatteryStreamData batteryStreamData = new BatteryStreamData();
            batteryStreamData.CreateBatteryMeasureReadingsList(int.Parse("15"));
            Assert.IsNotNull(batteryStreamData.BatteryReadings);
        }
        [TestMethod]
        public void GetRandomNumber_WhenWithinGivenRange()
        {
            double randomNumber = new BatteryStreamData().GenerateRandomNumber(0, 10);
            Assert.IsTrue(randomNumber >= 0 && randomNumber <= 10);
        }
        [TestMethod]
        public void GetTemperature_WhenWithinGivenRange()
        {
            double temperature = new BatteryStreamData().GenerateTemperatureValue();
            Assert.IsTrue(temperature <= BatteryConstants.MaxTemperature && temperature >= BatteryConstants.MinTemperature);
        }
        [TestMethod]
        public void GetChargeRate_WhenWithinGivenRange()
        {
            double ChargeRate = new BatteryStreamData().GenerateChargeRateValue();
            Assert.IsTrue(ChargeRate <= BatteryConstants.MaxChargeRate && ChargeRate >= BatteryConstants.MinChargeRate);
        }
    }
}
