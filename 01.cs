
using System.Collections.Generic;

public class Solution 
{
    public string solution(string my_string, int s, int e) 
    {
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
        
        return answer;
    }
}