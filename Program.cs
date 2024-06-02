namespace LeetCodeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }


        public void ReverseString(char[] s)
        {
            if (s.Length <= 1) return;

            int m, n;
            n = 0;
            m = s.Length - 1;

            while (n < m)
            {
                char temp = s[n];
                s[n] = s[m];
                s[m] = temp;
                n++;
                m--;
            }
        }

    }
}
