using System;

public class Temperature {

    public double CelsiusToFahrenheit(double value) {
        return (value * 9 / 5) + 32;
    }

    public double FahrenheitToCelsius(double value) {
        return (value - 32) * 5 / 9;
    }
}
