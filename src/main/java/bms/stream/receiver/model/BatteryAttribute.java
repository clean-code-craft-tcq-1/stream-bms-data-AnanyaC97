package bms.stream.receiver.model;

/**
 * @author Shrinidhi Muralidhar Karanam on 2021-06-25
 */
public class BatteryAttribute {
    private Double temperature;
    private Double changeRate;

    public BatteryAttribute(
        Double temperature,
        Double changeRate
    )
    {
        this.temperature = temperature;
        this.changeRate = changeRate;
    }

    public Double getTemperature() {
        return temperature;
    }

    public void setTemperature(Double temperature) {
        this.temperature = temperature;
    }

    public Double getChangeRate() {
        return changeRate;
    }

    public void setChangeRate(Double changeRate) {
        this.changeRate = changeRate;
    }

    @Override
    public String toString() {
        return "BatteryAttribute{" +
            "temperature=" + temperature +
            ", changeRate=" + changeRate +
            '}';
    }
}
