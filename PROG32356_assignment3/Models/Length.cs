using System;

public class Length {

    private const double CONVERSION_FACTOR = 3.28084;

    public double FootToMeter(double value) {
        return value * CONVERSION_FACTOR;
    }

    public double MeterToFoot(double value) {
        return value / CONVERSION_FACTOR;
    }
}
