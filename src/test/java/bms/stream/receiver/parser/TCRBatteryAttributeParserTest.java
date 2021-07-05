package bms.stream.receiver.parser;

import org.junit.jupiter.api.Test;

import bms.stream.receiver.model.BatteryAttribute;

import static org.junit.jupiter.api.Assertions.*;

/**
 * @author Shrinidhi Muralidhar Karanam on 2021-07-04
 */
class TCRBatteryAttributeParserTest {

    @Test
    void testParseToObject() {
        // ARRANGE
        String line = "Temperature: 39.97, Charge Rate: 0.77";
        BatteryAttribute batteryAttribute = new BatteryAttribute(39.97, 0.77);
        BatteryAttributeParser<BatteryAttribute> parser = new TCRBatteryAttributeParser();

        // ACT
        BatteryAttribute result = parser.parseToObject(line);

        // ASSERT
        assertEquals(batteryAttribute.toString(), result.toString());

    }
}