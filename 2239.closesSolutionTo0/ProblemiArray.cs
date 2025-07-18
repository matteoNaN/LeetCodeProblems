﻿namespace ProblemiArrayGenerali
{
    public class ProblemiArray
    {
        public static int FindClosestNumber_2239(int[] nums)
        {
            (int,int) smallest = (int.MaxValue-1,1);

            foreach (int i in nums)
            {
                
                int difference = Math.Abs(i);
                if(difference <= smallest.Item1)
                {
                   if(i > 0 && difference == smallest.Item1 && smallest.Item2 < 0)
                    {
                        smallest.Item1 = difference;
                        smallest.Item2 = 1;
                        continue;
                    }
                   if(i<0 && difference == smallest.Item1 && smallest.Item2 > 0)
                    {
                        continue;
                    }
                   smallest.Item1 = difference;
                   smallest.Item2 = i>=0?1:-1;

                }
            }

            return smallest.Item1*smallest.Item2;
        }

        public static string MergeAlternately_1768(string word1, string word2)
        {
            int i1 = 0;
            int i2 = 0;
            string result = "";
            int min_length = Math.Min(word1.Length, word2.Length);
            while (i1 != min_length && i2 != min_length)
            {
                result += word1[i1];
                i1++;
                result += word2[i2];
                i2++;
            }
            while (i1 != word1.Length)
            {
                result += word1[i1];
                i1++;
            }
            while (i2 != word2.Length)
            {
                result += word2[i2];
                i2++;
            }
            return result;

        }
    }
}
