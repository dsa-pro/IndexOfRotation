using System;

namespace IndexOfRotation
{
    class Program
    {
        // Find out the index of the word which will come first in the alphabetical order in the given list/array of strings.

        // ["proton", "renegade", "retrospection", "retrospective","surpass", "xerox", "apple", "banana", "enemy", "ferocious",
        //  "joystick", "kaput", "osteoporosis"]

        // Since the array is partially or mostly sorted we'll use Binary search or divide and conquer approach.
        static void Main(string[] args)
        {
            var words = new string[] {"proton", "renegade", "retrospection", "retrospective","surpass",
                "xerox", "apple", "banana", "enemy", "ferocious",
                "joystick", "kaput", "osteoporosis" };

            var actualIndex = FindIndex(words);
            // expected index = 6;

            Console.ReadKey();
        }

        static int FindIndex(string[] words)
        {
            var firstWord = words[0];

            int floorIndex = 0;
            int ceilingIndex = words.Length - 1;

            while (floorIndex < ceilingIndex)
            {
                int pivotIndex = (floorIndex + ceilingIndex) / 2;

                if (String.Compare(words[pivotIndex], firstWord, StringComparison.Ordinal) >= 0)
                {
                    floorIndex = pivotIndex;
                }
                else
                {
                    ceilingIndex = pivotIndex;
                }
                if (floorIndex + 1 == ceilingIndex)
                {
                    return ceilingIndex;
                }
            }

            return 0;
        }
    }
}
