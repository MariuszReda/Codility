using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int N)
    {
        int counter = 0;
        int Num = N;
        while (Num >= 1)
        {
            Num /= 2;
            counter++;
        }
        int variable = counter;
        int[] tab = new int[counter];
        while (N >= 1)
        {


            if (N % 2 == 0)
            {
                tab[counter - 1] = 0;
                counter--;
            }
            else
            {
                tab[counter - 1] = 1;
                counter--;
            }
            N /= 2;
        }
        int pos = 0;
        int x = 0;
        int max = 0;
        while (tab[x] == 1)
        {
            if (x + 1 < variable)
            {
                while (tab[x + 1] == 0)
                {
                    pos++;

                    if ((x + 1) == (variable - 1) && tab[x + 1] == 0)
                    {
                        pos = 0;
                        break;
                    }
                    x++;
                }
                if (max < pos)
                {
                    max = pos;
                }

                pos = 0;
                x++;
            }
            else
            {
                break;
            }

        }
        return max;
    }
}

