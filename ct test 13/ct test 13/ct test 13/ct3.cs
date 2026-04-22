namespace ct_test_13;

public class ct3
{
    public void Solution()
    {
        int[] players = {0, 2, 3, 3, 1, 2, 0, 0, 0, 0, 4, 2, 0, 6, 0, 4, 2, 13, 3, 5, 10, 0, 1, 5};
        int m = 3;
        int k = 5;
        int answer = 0;

        int server = 0;
        int[] returnServer = new int[24];

        for (int i = 0; i < 24; i++)
        {
            server -= returnServer[i];
            
            int currentServer = players[i] / m;

            if (currentServer > server)
            {
                int plusServer = currentServer - server;
                
                answer += plusServer;
                server += plusServer;

                if (i + k < returnServer.Length) returnServer[i + k] += plusServer;
            }
        }

        Console.WriteLine(answer);
    }
}