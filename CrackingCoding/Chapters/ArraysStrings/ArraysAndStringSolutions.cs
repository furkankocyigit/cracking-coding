namespace CrackingCoding.Chapters.ArraysStrings
{
    public class ArraysAndStringSolutions
    {
        public bool isStringUniq(string input)
        {
            bool isUniq = true;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        isUniq = false;
                    }
                }
            }
            return isUniq;
        }

        public bool isStringUniqSecondSolution(string input)
        {
            bool isUniq = true;
            bool[] chars = new bool[128];
            for (int i = 0; i < input.Length; i++)
            {
                var val = input.ElementAt(i);
                if (chars[val])
                {
                    isUniq = false;
                }
                chars[val] = true;
            }
            return isUniq;
        }

        public string compressString(string inputString)
        {
            string compressedString = "";
            int count = 1;
            for (int i = 0; i < inputString.Length;)
            {
                while ((i + count) < inputString.Length && inputString[i] == inputString[i + count])
                {
                    count++;
                }

                compressedString += inputString[i] + count.ToString();

                i += count;
                count = 1;
            }

            return (inputString.Length > compressedString.Length) ? compressedString : inputString;
        }

        public string compressStringSecond(string inputString)
        {
            string compressedString = "";
            int count = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                count++;
                if (i + 1 >= inputString.Length || inputString[i] != inputString[i + 1])
                {
                    compressedString += inputString[i] + count.ToString();
                    count = 0;
                }
            }

            return (inputString.Length > compressedString.Length) ? compressedString : inputString;
        }

        public bool isPermutation(string first, string second)
        {
            bool isPermutationOfOther = false;
            if (first.Length != second.Length)
            {
                return isPermutationOfOther;
            }
            int count = 0;
            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j < second.Length; j++)
                {
                    if (first[i] == second[j])
                    {
                        count++;
                        break;

                    }
                }
            }
            isPermutationOfOther = count == first.Length ? true : false;
            return isPermutationOfOther;
        }
    }
}
