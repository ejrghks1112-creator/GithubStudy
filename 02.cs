using System;

public class Solution 
{
    public string[] solution(string[] players, string[] callings) 
    {
        for (int i = 0; i < callings.Length; i++)
        {
            for (int j = 0; j < players.Length; j++)
            {
                if (callings[i] == players[j])
                {
                    string temp = players[j - 1];
                    players[j - 1] = callings[i];
                    players[j] = temp;
                }
            }

        }
        string[] answer = players;
        return answer;
    }
}