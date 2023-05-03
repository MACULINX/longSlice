using System;
public static class LargestSeriesval
{
   public static long GetLargestval(string digits, int span)
{
    if ( span > digits.Length || span < 0)
        throw new ArgumentException();
    
    if (span == 0)
        return 1;
    
    foreach (var c in digits)
        if (!Char.IsDigit(c))
            throw new ArgumentException();

    char[] DigitCharArray = digits.ToCharArray();

    long MaxVal = 0;

    for (int i = 0; i <= digits.Length - span; i++)
    {
        long val = 1;

        for (int j = 0; j < span; j++)
        {
            int digit = (int)DigitCharArray[i + j]-30;
            val *= digit;
        }

        if (val > MaxVal)
            MaxVal = val;
    }

    return MaxVal;
}

}