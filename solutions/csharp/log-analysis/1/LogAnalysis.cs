

public static class LogAnalysis
{
    // 1️⃣ Возвращает часть строки после указанного разделителя
    public static string SubstringAfter(this string str, string delimiter)
    {
        int index = str.IndexOf(delimiter);
        if (index == -1)
        {
            return str;
        }

        return str.Substring(index + delimiter.Length);
    }

    // 2️⃣ Возвращает часть строки между двумя разделителями
    public static string SubstringBetween(this string str, string start, string end)
    {
        int startIndex = str.IndexOf(start);
        if (startIndex == -1)
        {
            return str;
        }

        startIndex += start.Length;

        int endIndex = str.IndexOf(end, startIndex);
        if (endIndex == -1)
        {
            return str;
        }

        return str.Substring(startIndex, endIndex - startIndex);
    }

    // 3️⃣ Возвращает сообщение из лога
    public static string Message(this string log)
    {
        return log.SubstringAfter(": ");
    }

    // 4️⃣ Возвращает уровень лога
    public static string LogLevel(this string log)
    {
        return log.SubstringBetween("[", "]");
    }
}
