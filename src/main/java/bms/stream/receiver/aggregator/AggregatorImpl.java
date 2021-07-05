package bms.stream.receiver.aggregator;

import bms.stream.receiver.model.StreamDataQueue;

/**
 * @author Shrinidhi Muralidhar Karanam on 2021-07-02
 */
public class AggregatorImpl implements Aggregator {

    @Override
    public Double max(
        StreamDataQueue<Double> queue,
        Double value
    )
    {
        final double newValue = queue.stream().mapToDouble(o -> o).max().getAsDouble();
        return value == null || newValue >= value ? newValue : value;
    }

    @Override
    public Double min(
        StreamDataQueue<Double> queue,
        Double value
    )
    {
        final double newValue = queue.stream().mapToDouble(o -> o).min().getAsDouble();
        return value==null || newValue <= value ? newValue : value;
    }

    @Override
    public Double average(StreamDataQueue<Double> queue) {
        return queue.stream().mapToDouble(o -> o).average().getAsDouble();
    }
}
