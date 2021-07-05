package bms.stream.receiver.parser;


import bms.stream.receiver.model.BatteryAttribute;

/**
 * Temperature and change rate (TCR) parser.
 *
 * @author Shrinidhi Muralidhar Karanam on 2021-06-25
 */
public class TCRBatteryAttributeParser implements BatteryAttributeParser<BatteryAttribute> {

    @Override
    public BatteryAttribute parseToObject(String str) {
        String[] parameters = str.split(", ");
        return new BatteryAttribute(
            Double.parseDouble(parameters[0].split(":")[1]),
            Double.parseDouble(parameters[1].split(":")[1])
        );
    }
}
