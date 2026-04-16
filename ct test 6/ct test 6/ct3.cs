namespace ct_test_6;

public class ct3
{
    int[,] dungeons = new int[,] { { 80, 20 }, { 50, 40 }, { 30, 10 } }; 
    int k = 80;
    bool[] visited;
    int answer = 0;
    
    public int Solution(int k, int[,] dungeons)
    {
        visited = new bool[dungeons.GetLength(0)];
        DFS(k, dungeons, 0);
        
        return answer;
    }

    public void DFS(int k, int[,] dungeons, int count)
    {
        answer = count;
        
        for (int i = 0; i < dungeons.GetLength(0); i++)
        {
            if(k >= dungeons[i, 0] && !visited[i])
            {
                visited[i] = true;
                DFS(k - dungeons[i, 1], dungeons, count++);
                visited[i] = false;
            }
        }
    }
}