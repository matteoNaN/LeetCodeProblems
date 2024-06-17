namespace _20.ValidParentheses
{
    public static class leetValidParentheses
    {
        //soluzione alterntiva vista direttamente da leetcode 
        public static bool IsValid(string s)
        {
            if (s.Length <= 1)
                return false;

            var bracketQueue = new List<int>();

            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    bracketQueue.Add(1);
                    continue;
                }
                if (s[i] == '[')
                {
                    bracketQueue.Add(2);
                    continue;
                }
                if (s[i] == '{')
                {
                    bracketQueue.Add(3);
                    continue;
                }
                if (bracketQueue.Count == 0)
                    return false;

                if (s[i] == ')' && bracketQueue[bracketQueue.Count - 1] == 1)
                {
                    bracketQueue.RemoveAt(bracketQueue.Count - 1);
                    continue;
                }
                if (s[i] == ']' && bracketQueue[bracketQueue.Count - 1] == 2)
                {
                    bracketQueue.RemoveAt(bracketQueue.Count - 1);
                    continue;
                }
                if (s[i] == '}' && bracketQueue[bracketQueue.Count - 1] == 3)
                {
                    bracketQueue.RemoveAt(bracketQueue.Count - 1);
                    continue;
                }

                return false;
            }
            return bracketQueue.Count == 0;
        }
         //la mia soluzione con lo stack
        public static bool IsValidStack(string s)
        {
            
            if(s.Length <=1 || s.Length % 2 !=0) return false;
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push(')');
                    continue;
                }
                if (s[i] == '[')
                {
                    stack.Push(']');
                    continue;
                }
                if (s[i] == '{')
                {
                    stack.Push('}');
                    continue;
                }

                if(stack.Count == 0) return false;
                if(s[i] != stack.Pop()) return false;

            }

            return stack.Count ==0;
        }
        //altra soluzione di leetcode più veloce della mia ma uguale il foreach ???
        public static bool IsValidForEach(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(')
                {
                    stack.Push(')');
                }
                else if (c == '{')
                {
                    stack.Push('}');
                }
                else if (c == '[')
                {
                    stack.Push(']');
                }
                else if (stack.Count == 0 || c != stack.Pop())
                {
                    return false;
                }
            }
            return stack.Count() == 0;
        }
    }
    
}
