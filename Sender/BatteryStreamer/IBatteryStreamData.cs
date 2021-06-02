using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryStreamer
{
    public interface IBatteryStreamData
    {
        double GenerateTemperatureValue();

        double GenerateChargeRateValue();
    }
}
