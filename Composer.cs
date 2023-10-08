using System;
using System.Collections.Generic;

public class Composer
{
    public static int[] GenerateBeatEmphasis(int powerOfTwo)
    {
        int totalBeats = (int)Math.Pow(2, powerOfTwo);
        int[] emphasisArray = new int[totalBeats];

        // The first beat is always emphasized as powerOfTwo * powerOfTwo;
        emphasisArray[0] = powerOfTwo * powerOfTwo;

        for (int i = 1; i < powerOfTwo; i++)
        {
            int segmentSize = (int)Math.Pow(2, i);
            for (int j = 0; j < segmentSize; j++)
            {
                emphasisArray[j + segmentSize] = emphasisArray[j] - 1;
            }
        }

        // Double the numbers to fill the array
        for (int i = 1; i < powerOfTwo; i++)
        {
            int offset = (int)Math.Pow(2, i);
            for (int j = 0; j < offset; j++)
            {
                emphasisArray[j + offset] = emphasisArray[j];
            }
        }

        return emphasisArray;
    }

    public void Test()
    {
        int[] result = GenerateBeatEmphasis(3);
        Console.WriteLine(string.Join(", ", result));
    }
}
