using System.Runtime.Intrinsics.X86;

namespace _13.RomanToInteger
{
    public static class leetRomanToInteger
    {
        public static int RomanToInt(string s )
        {
            

            Dictionary<char, int> romanCharsValue = new()
            {
                { 'M', 1000 },
                { 'D', 500 },
                { 'C', 100 },
                { 'L', 50 },
                { 'X', 10 },
                { 'V', 5 },
                { 'I', 1 }
            };

            int total = 0;

            for ( int i = 0; i < s.Length - 1; i++ )
            {
                if (romanCharsValue[s[i]] < romanCharsValue[s[i+1]])
                    total -= romanCharsValue[s[i]];
                else
                    total += romanCharsValue[s[i]];
            }


            return total + romanCharsValue[s[s.Length - 1]];
        }
    }
}
