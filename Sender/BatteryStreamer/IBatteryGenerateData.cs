using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryStreamer
{
    public interface IBatteryGenerateData
    {
        double GenerateTemperatureValue();

        double GenerateChargeRateValue();
    }
}
