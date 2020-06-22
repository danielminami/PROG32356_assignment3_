using System;

public class Time {
	
    public double MinuteToHour(double value) {
        return Math.Round(value / 60, 2);
    }

    public double HourToMinute(double value) {
        return Math.Round(value * 60, 2);
    }
}
