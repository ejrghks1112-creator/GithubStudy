namespace ct_test_6;

public class ct2
{
    public void Solution()
    {
        string pn = "01033334444";
        Stack<char>  stack = new Stack<char>();
        char[] p = pn.ToCharArray();
        char[] n = new char[p.Length];

        for (int i = 0; i < p.Length; i++)
        {
            stack.Push(p[i]);
        }

        for (int i = 0; i < 4; i++)
        {
           n[i] = stack.Pop();
        }

        for (int i = 0; i < stack.Count; i++)
        {
            n[i+4] = '*';
        }

        Array.Reverse(n);
        string answer = new string(n);
        Console.WriteLine(answer);
    }
}