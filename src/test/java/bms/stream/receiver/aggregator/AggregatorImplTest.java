package bms.stream.receiver.aggregator;

import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import bms.stream.receiver.model.BatteryAttribute;
import bms.stream.receiver.model.StreamDataQueue;

import static org.junit.jupiter.api.Assertions.*;

/**
 * @author Shrinidhi Muralidhar Karanam on 2021-07-04
 */
class AggregatorImplTest {

    StreamDataQueue<Double> queue = new StreamDataQueue<>(5);

    @BeforeEach
    void init() {
        queue.offer(27.3);
        queue.offer(24.3);
        queue.offer(38.8);
    }

    @Test
    void testMax_whenInputMaxisNull() {
        // ARRANGE
        Aggregator aggregator = new AggregatorImpl();

        // ACT
        Double result = aggregator.max(queue,null);

        // ASSERT
        assertEquals(38.8, result);

    }

    @Test
    void testMax_whenInputMaxisLesser() {
        // ARRANGE
        Aggregator aggregator = new AggregatorImpl();

        // ACT
        Double result = aggregator.max(queue,30.2);

        // ASSERT
        assertEquals(38.8, result);

    }

    @Test
    void testMax_whenInputMaxisGreater() {
        // ARRANGE
        Aggregator aggregator = new AggregatorImpl();

        // ACT
        Double result = aggregator.max(queue,40.2);

        // ASSERT
        assertEquals(40.2, result);

    }

    @Test
    void testMax_whenInputMinisNull() {
        // ARRANGE
        Aggregator aggregator = new AggregatorImpl();

        // ACT
        Double result = aggregator.min(queue,null);

        // ASSERT
        assertEquals(24.3, result);

    }

    @Test
    void testMax_whenInputMinisLesser() {
        // ARRANGE
        Aggregator aggregator = new AggregatorImpl();

        // ACT
        Double result = aggregator.min(queue,20.2);

        // ASSERT
        assertEquals(20.2, result);

    }

    @Test
    void testMax_whenInputMinisGreater() {
        // ARRANGE
        Aggregator aggregator = new AggregatorImpl();

        // ACT
        Double result = aggregator.min(queue,40.2);

        // ASSERT
        assertEquals(24.3, result);

    }

    @Test
    void testAverage() {
        // ARRANGE
        Aggregator aggregator = new AggregatorImpl();
        Double expectedAverage = queue.stream().mapToDouble(o->o).average().getAsDouble();

        // ACT
        Double result = aggregator.average(queue);

        // ASSERT
        assertEquals(expectedAverage, result);
    }
}