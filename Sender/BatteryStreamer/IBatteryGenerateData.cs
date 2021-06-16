namespace BatteryStreamer
{
    public interface IBatteryGenerateData
    {
        double GenerateTemperatureValue();

        double GenerateChargeRateValue();
    }
}
