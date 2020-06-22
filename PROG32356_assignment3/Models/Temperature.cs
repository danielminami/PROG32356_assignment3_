using System;

public class Temperature {

    public double CelsiusToFahrenheit(double value) {
        return Math.Round(((value * 9 / 5) + 32), 2);
    }

    public double FahrenheitToCelsius(double value) {
        return Math.Round(((value - 32) * 5 / 9), 2);
    }
}
