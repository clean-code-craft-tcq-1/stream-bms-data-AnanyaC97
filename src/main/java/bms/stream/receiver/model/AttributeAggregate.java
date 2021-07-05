package bms.stream.receiver.model;

/**
 * @author Shrinidhi Muralidhar Karanam on 2021-07-02
 */
public class AttributeAggregate {

    private Double min;
    private Double max;
    private Double average;

    public AttributeAggregate(
        Double min,
        Double max,
        Double average
    )
    {
        this.min = min;
        this.max = max;
        this.average = average;
    }

    public Double getMin() {
        return min;
    }

    public void setMin(Double min) {
        this.min = min;
    }

    public Double getMax() {
        return max;
    }

    public void setMax(Double max) {
        this.max = max;
    }

    public Double getAverage() {
        return average;
    }

    public void setAverage(Double average) {
        this.average = average;
    }

    @Override
    public String toString() {
        return "min=" + min +
            ", max=" + max +
            ", average=" + average +
            '}';
    }
}
