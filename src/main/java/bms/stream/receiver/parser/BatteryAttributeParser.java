package bms.stream.receiver.parser;

/**
 * @author Shrinidhi Muralidhar Karanam on 2021-06-25
 */
public interface BatteryAttributeParser<T> {

    T parseToObject(String str);

}
