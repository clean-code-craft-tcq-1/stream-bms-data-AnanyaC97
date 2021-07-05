package bms.stream.receiver.aggregator;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

/**
 * @author Shrinidhi Muralidhar Karanam on 2021-07-04
 */
class AggregatorFactoryTest {

    @Test
    void testGetAggregator() {
        // ARRANGE
        AggregatorFactory factory = new AggregatorFactory();

        // ACT & ASSERT
        assertTrue(factory.getAggregator() instanceof AggregatorImpl);
    }
}