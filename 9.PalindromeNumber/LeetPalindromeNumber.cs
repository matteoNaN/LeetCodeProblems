namespace _9.PalindromeNumber
{
    public class LeetPalindromeNumber
    {
        public static bool IsPalindrome(int number)
        {
            var numberString = number.ToString();
            var invertedString =  new string(numberString.Reverse().ToArray());
            return numberString.Equals(invertedString);
        }

    }
}
