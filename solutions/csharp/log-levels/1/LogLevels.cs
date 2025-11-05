using System;

public static class LogLine
{
    // 1. Get the message
    public static string Message(string logLine)
    {
        // Split the string at "]:"
        string[] parts = logLine.Split(new string[] { "]:" }, StringSplitOptions.None);
        // Take the second part (the message) and trim spaces/newlines
        return parts[1].Trim();
    }

    // 2. Get the log level in lowercase
    public static string LogLevel(string logLine)
    {
        // Split the string at "]:"
        string[] parts = logLine.Split(new string[] { "]:" }, StringSplitOptions.None);
        // Remove the opening "[" from the first part, and convert to lowercase
        return parts[0].TrimStart('[').ToLower();
    }

    // 3. Reformat log line: message first, level in parentheses
    public static string Reformat(string logLine)
    {
        // Get message and log level using the methods above
        string message = Message(logLine);
        string level = LogLevel(logLine);
        // Combine them in the new format
        return $"{message} ({level})";
    }
}
