namespace BatteryStreamer
{
    public class BatteryConstants
    {
        public static double MaxTemperature = 40;
        public static double MinTemperature = 0;
        public static double MaxChargeRate = 0.8f;
        public static double MinChargeRate = 0.5f;
        public static int BatteryReadingCount = 0;
        public double Temperature;
        public double ChargeRate;
        public BatteryConstants(double Temperature, double ChargeRate)
        {
            this.Temperature = Temperature;
            this.ChargeRate = ChargeRate;
        }
    }
}
