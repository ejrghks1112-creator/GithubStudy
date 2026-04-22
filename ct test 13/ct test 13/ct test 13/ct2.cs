namespace ct_test_13;

public class ct2
{
    public void Solution()
    {
        string s = "aukks";
        string skip = "wbqd";
        int index = 5;
        string answer = "";

        List<char> alphbet = new List<char>();
        
        for (char i = 'a'; i <= 'z'; i++)
        {
            if (!skip.Contains(i)) alphbet.Add(i);
        }

        for (int i = 0; i < s.Length; i++)
        {
            int currentIndex = alphbet.IndexOf(s[i]);
            int nextIndex = currentIndex + index;
            
            while (nextIndex >= alphbet.Count) nextIndex -= alphbet.Count;
            
            answer += alphbet[nextIndex];
        }

        Console.WriteLine(answer);
    }
}