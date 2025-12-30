using System;

public static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        // Parses the string into a DateTime using en-US culture (already set by tests)
        return DateTime.Parse(appointmentDateDescription);
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        // Checks if the appointment is in the past
        return appointmentDate < DateTime.Now;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        // Afternoon is from 12:00 (inclusive) to 18:00 (exclusive)
        return appointmentDate.Hour >= 12 && appointmentDate.Hour < 18;
    }

    public static string Description(DateTime appointmentDate)
    {
        // Formats the DateTime using default en-US formatting
        return $"You have an appointment on {appointmentDate}.";
    }

    public static DateTime AnniversaryDate()
    {
        // Returns September 15th of the current year at midnight
        int year = DateTime.Now.Year;
        return new DateTime(year, 9, 15, 0, 0, 0);
    }
}
