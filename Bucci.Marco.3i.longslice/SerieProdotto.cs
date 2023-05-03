using System;
public static class LargestSeriesval
{
    public static long GetLargestval(string digits, int span)
    {

        //Controllo che la sequenza non sia piu' grande della stringa o sia minore di 0
        if (span > digits.Length || span < 0)
            throw new ArgumentException();

        //Controllo che la sequenza non sia 0
        if (span == 0)
            return 1;

        //Converto la stringa in un char[] 
        char[] DigitCharArray = digits.ToCharArray();

        //Controllo che ogni carattere sia un numero
        foreach (var c in DigitCharArray)
            if (!Char.IsDigit(c))
                throw new ArgumentException();
        
        //Dichiaro e inizializzo la variabile di ritorno "MaxVal"
        int MaxVal = 0;

        //Ciclo for per scorrere il vettore
        for (int i = 0; i <= DigitCharArray.Length - span; i++)
        {
            //Dichiaro e inizializzo la variabile da controllare "val"
            int val = 1;
            
            //Ciclo for per moltiplicare la sequenza di numeri
            for (int j = 0; j < span; j++)
            {
                //Qui avviene la conversione da char a int
                int digit = (int)DigitCharArray[i + j] - 30;
                //Qui avviene la moltiplicazione di ogni numero
                val *= digit;
            }

            //Controllo che la variabile "val" sia maggiore di "MaxVal"
            if (val > MaxVal)
                //In caso positivo do a "MaxVal" il valore di "val"
                MaxVal = val;
        }
        //Ritorno "MaxVal"
        return MaxVal;
    }

}