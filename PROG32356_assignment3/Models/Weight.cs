using System;

public class Weight {

    private const double CONVERSION_FACTOR = 2.20462262185;

    public double KilogramToPound(double value) {
        return value * CONVERSION_FACTOR;
    }

    public double PoundToKilogram(double value) {
        return value / CONVERSION_FACTOR;
    }

}
