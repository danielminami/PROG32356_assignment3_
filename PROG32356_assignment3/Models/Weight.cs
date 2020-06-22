using System;

public class Weight {

    private const double CONVERSION_FACTOR = 2.20462262185;

    public double KilogramToPound(double value) {
        return Math.Round(value * CONVERSION_FACTOR);
    }

    public double PoundToKilogram(double value) {
        return Math.Round(value / CONVERSION_FACTOR);
    }

}
