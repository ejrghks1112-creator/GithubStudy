using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string my_string = "Progra21Sremm3";
        int s = 6;
        int e = 12;
        string answer = "";
        
        char[] c = new char[my_string.Length];
        Stack<char> stack = new Stack<char>();

        for (int j = 0; j < my_string.Length; j++)
        {
            c[j] = my_string[j];
        }

        for (int i = s; i < e + 1; i++)
        {
            stack.Push(c[i]);
        }
        
        for (int i = s; i < e + 1; i++)
        {
            c[i] = stack.Pop();
        }

        for (int k = 0; k < my_string.Length; k++)
        {
            answer += c[k];
        }

        Console.WriteLine(answer);
        
        
    }
}