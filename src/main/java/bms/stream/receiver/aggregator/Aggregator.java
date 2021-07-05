package bms.stream.receiver.aggregator;

import bms.stream.receiver.model.AttributeAggregate;
import bms.stream.receiver.model.StreamDataQueue;

/**
 * @author Shrinidhi Muralidhar Karanam on 2021-06-28
 */
public interface Aggregator {

    Double max(StreamDataQueue<Double> queue, Double value);
    Double min(StreamDataQueue<Double> queue, Double value);
    Double average(StreamDataQueue<Double> queue);
}
