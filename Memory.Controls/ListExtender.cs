namespace Memory.Controls
{
    // Tutaj mieszamy kafelki, przed rozłożeniem ich na planszy
    public static class ListExtender
    {
        public static void Shuffle<T>(this List<T> instance) // T -  parametr typu
        {
            Random random = new Random();
            for (int i = 0; i < instance.Count; i++)
            {
                int indexA = random.Next(instance.Count);
                int indexB = random.Next(instance.Count);
                T itemA = instance[indexA];
                T itemB = instance[indexB];

                instance[indexA] = itemB;
                instance[indexB] = itemA;
            }
        }
    }
}
