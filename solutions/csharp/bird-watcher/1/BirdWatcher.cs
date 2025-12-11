public class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    // 1. LastWeek()
    public static int[] LastWeek()
    {
        return new int[] { 0, 2, 5, 3, 7, 8, 4 };
    }

    // 2. Today()
    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length - 1];
    }

    // 3. IncrementTodaysCount()
    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1]++;
    }

    // 4. HasDayWithoutBirds()
    public bool HasDayWithoutBirds()
    {
        foreach (int birds in birdsPerDay)
        {
            if (birds == 0)
                return true;
        }
        return false;
    }

    // 5. CountForFirstDays()
    public int CountForFirstDays(int numberOfDays)
    {
        int sum = 0;

        // Если указанное число дней больше длины массива — считаем только доступные дни
        if (numberOfDays > birdsPerDay.Length)
            numberOfDays = birdsPerDay.Length;

        for (int i = 0; i < numberOfDays; i++)
        {
            sum += birdsPerDay[i];
        }

        return sum;
    }

    // 6. BusyDays()
    public int BusyDays()
    {
        int count = 0;
        foreach (int birds in birdsPerDay)
        {
            if (birds >= 5)
                count++;
        }
        return count;
    }
}