namespace _3.LongestSubstringWithoutRepeatingCharacters
{
    public static class LeetLongestSubstringNoRC
    {
        public static int LengthOfLongestSubstring(string s)
        {
            HashSet<char> charSet = new HashSet<char>();
            int result = 0;
            int left = 0;
            for (int right = 0; right < s.Length; right++)
            {
                while (charSet.Contains(s[right]))
                {
                    charSet.Remove(s[left]);
                    left++;
                }
                charSet.Add(s[right]);
                result = Math.Max(result, charSet.Count);
            }
            return result;
        }
    }
}
