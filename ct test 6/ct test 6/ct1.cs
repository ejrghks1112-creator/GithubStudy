namespace ct_test_6;

public class ct1
{
    public void Solution()
    {
        string[] s1 = new string[] { "a", "b", "c" };
        string[] s2 = new string[] { "com", "b", "d", "p", "c" };
        int answer = 0; 

        for (int i = 0; i < s1.Length; i++)
        {
            for (int j = 0; j < s2.Length; j++)
            {
                if (s1[i] == s2[j])
                {
                    answer++;
                }
            }
        }

        Console.WriteLine(answer);
    }
}