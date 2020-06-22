using System;

public class Length {

    private const double CONVERSION_FACTOR = 3.28084;

    public double FootToMeter(double value) {
        return Math.Round(value * CONVERSION_FACTOR, 2);
    }

    public double MeterToFoot(double value) {
        return Math.Round(value / CONVERSION_FACTOR, 2);
    }
}
