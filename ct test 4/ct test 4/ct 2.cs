namespace ct_test_4;

public class ct_2
{
    public  void Solution()
    {
        int n = 5;
        int answer = 0;

        for (int i = 2; i < n + 1; i++)
        {
            if (isSosu(i))
            {
                answer++;
            }
        }

        Console.WriteLine(answer);
    }

    public bool isSosu(int n)
    {
        int a = (int)Math.Sqrt(n);
        for (int i = 2; i < a + 1; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}