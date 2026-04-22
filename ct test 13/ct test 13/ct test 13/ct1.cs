namespace ct_test_13;

public class ct1
{
    public void Solution()
    {
        string[] keymap = new string[] { "ABACD", "BCEFD" };
        string[] targets = new string[] { "ABCD","AABB" };
        int[] answer = new int[targets.Length];

        Dictionary<char, int> targetkey = new Dictionary<char, int>();

        for (int i = 0; i < keymap.Length; i++)
        {
            string keys = keymap[i];
            for (int j = 0; j < keys.Length; j++)
            {
                char alphabet = keys[j];
                int count = j + 1;

                if (targetkey.ContainsKey(alphabet)) targetkey[alphabet] = Math.Min(targetkey[alphabet], count);
                else                                 targetkey.Add(alphabet, count);
            }
        }

        for (int i = 0; i < targets.Length; i++)
        {
            int result = 0;
            string target = targets[i];
            bool isCanClick = true;

            for (int j = 0; j < target.Length; j++)
            {
                if (targetkey.ContainsKey(target[j])) result += targetkey[target[j]];
                else                                  isCanClick = false;
            }
            
            answer[i] = isCanClick ? result : -1;
            Console.WriteLine(answer[i]);
        }

    }
}