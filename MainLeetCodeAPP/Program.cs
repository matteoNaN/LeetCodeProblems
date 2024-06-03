using _3.LongestSubstringWithoutRepeatingCharacters;

namespace MainLeetCodeAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "abcabcbb";

            int l = LeetLongestSubstringNoRC.LengthOfLongestSubstring(s);

            Console.WriteLine(l);
        }
    }
}
