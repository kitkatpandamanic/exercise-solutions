public static class QuestLogic
{
    // 1️⃣ Fast attack can be made if the knight is sleeping
    public static bool CanFastAttack(bool knightIsAwake)
    {
        return !knightIsAwake;
    }

    // 2️⃣ Spy can be done if at least one of them is awake
    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        return knightIsAwake || archerIsAwake || prisonerIsAwake;
    }

    // 3️⃣ Signal prisoner if prisoner is awake and archer is sleeping
    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        return !archerIsAwake && prisonerIsAwake;
    }

    // 4️⃣ Free prisoner
    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        // Case 1: Dog is present → can free if archer is sleeping
        if (petDogIsPresent && !archerIsAwake)
        {
            return true;
        }

        // Case 2: No dog → can free if prisoner awake and both knight & archer sleeping
        if (!petDogIsPresent && prisonerIsAwake && !knightIsAwake && !archerIsAwake)
        {
            return true;
        }

        // Otherwise, can’t free prisoner
        return false;
    }
}
