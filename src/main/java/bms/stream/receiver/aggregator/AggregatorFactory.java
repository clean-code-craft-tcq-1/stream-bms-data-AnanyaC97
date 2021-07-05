package bms.stream.receiver.aggregator;

/**
 * @author Shrinidhi Muralidhar Karanam on 2021-07-02
 */
public class AggregatorFactory {

    public Aggregator getAggregator(){
        return new AggregatorImpl();
    }

}
