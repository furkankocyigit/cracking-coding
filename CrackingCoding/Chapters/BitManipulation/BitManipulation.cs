namespace CrackingCoding.Chapters.BitManipulation
{
    public static class BitManipulation
    {
        public static int insertValue(int source, int value, int i, int j)
        {
            if (value > source) return 0;
            if (i > j) return 0;

            int allOnes = ~0;
            int left = allOnes << j + 1;
            int right = (1 << i) - 1;
            int mask = left | right;
            source = source & mask;

            source = source | (value << i);

            return source;
        }
    }
}
