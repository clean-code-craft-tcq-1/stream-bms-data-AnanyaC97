package bms.stream.receiver;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import bms.stream.receiver.aggregator.Aggregator;
import bms.stream.receiver.aggregator.AggregatorFactory;
import bms.stream.receiver.model.AttributeAggregate;
import bms.stream.receiver.model.BatteryAttribute;
import bms.stream.receiver.model.StreamDataQueue;
import bms.stream.receiver.parser.BatteryAttributeParser;
import bms.stream.receiver.parser.TCRBatteryAttributeParser;
import bms.stream.receiver.printer.ValuePrinter;
import bms.stream.receiver.printer.ValuePrinterFactory;

/**
 * @author Shrinidhi Muralidhar Karanam on 2021-06-13
 */
public class Receiver {

    private static final BatteryAttributeParser<BatteryAttribute> BATTERY_ATTRIBUTE_PARSER =
        new TCRBatteryAttributeParser();
    private static final StreamDataQueue<Double> TEMPERATURE_STREAM_DATA_QUEUE = new StreamDataQueue<>(5);
    private static final StreamDataQueue<Double> CHANGERATE_STREAM_DATA_QUEUE = new StreamDataQueue<>(5);
    private static final AggregatorFactory aggregatorFactory = new AggregatorFactory();
    private static Aggregator aggregator;
    private static AttributeAggregate temperature = new AttributeAggregate(null, null, null);;
    private static AttributeAggregate changeRate = new AttributeAggregate(null, null, null);;
    private static final ValuePrinterFactory valuePrinterFactory = new ValuePrinterFactory();
    private static ValuePrinter valuePrinter;

    public static void main(String[] args) throws IOException {
        while (true) {
            BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
            String line = reader.readLine();
            valuePrinter = valuePrinterFactory.getValuePrinterFor("console");
            valuePrinter.print(line);

            BatteryAttribute batteryAttribute = BATTERY_ATTRIBUTE_PARSER.parseToObject(line);
            TEMPERATURE_STREAM_DATA_QUEUE.offer(batteryAttribute.getTemperature());
            CHANGERATE_STREAM_DATA_QUEUE.offer(batteryAttribute.getChangeRate());

            aggregator = aggregatorFactory.getAggregator();
            temperature = getAttributeAggregateOf(TEMPERATURE_STREAM_DATA_QUEUE, temperature);
            changeRate = getAttributeAggregateOf(CHANGERATE_STREAM_DATA_QUEUE, changeRate);

            valuePrinter.print("Temperature:\n" + temperature);
            valuePrinter.print("Change Rate:\n" + changeRate);
        }

    }

    private static AttributeAggregate getAttributeAggregateOf(
        StreamDataQueue<Double> queue,
        AttributeAggregate attribute
    )
    {
        return new AttributeAggregate(
            aggregator.min(queue, attribute.getMin()),
            aggregator.max(queue, attribute.getMax()),
            aggregator.average(queue)
        );
    }

}
