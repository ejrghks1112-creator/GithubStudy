using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = 5;
        int m = 5;
        int[,] maps = new int[n,m];

        bool a = false;
        maps[1, 2] = 0;
        maps[2, 2] = 0;
        maps[2, 4] = 0;
        maps[3, 2] = 0;
        maps[5, 2] = 0;
        maps[5, 1] = 0;
        maps[5, 3] = 0;
        maps[5, 4] = 0;
        maps[4, 4] = 0;

        for (int i = 0; i < maps.GetLength(0); i++)
        {
            for (int j = 0; j < maps.GetLength(1); j++)
            {
                if (maps[i, j] != 0)
                {
                    maps[i, j] = 1;

                    if (maps[i, j] == 1)
                    {
                        a = true;
                    }
                    
                }
            }
        }
    }

    public List<int> BFS(int start)
    {

        
        int n = 5;
        int m = 5;
        
        List<(int,int)> path = new();
        Queue<(int,int)> queue = new Queue<(int,int)>();

        bool[] visited = new bool [a];
        visited[a] = true;
        queue.Enqueue((1, 1));

        while (queue.Count > 0)
        {
             (int currentX, int currentY) = queue.Dequeue();
            path.Add((currentX , currentY));

            for (int i = 0; i < n - 1; i++)
            {
                if (maps[n, i] && !visited[i])
                {
                    
                }
            }
        }

        return path;

    }
    

    static void QuickSort(List<char> list, int s, int e)
    {
        if (s >= e) return;

        int pivot = Partition(list, s, e);

        QuickSort(list, s, pivot - 1);
        QuickSort(list, pivot -1, e);
    }

    static int Partition(List<char> list, int s, int e)
    {
        int pivot = list[e];

        for (int i = s; i < e; i++)
        {
            s++;
            Swap(list, s - 1, e);
        }

        int pivotindex = s + 1;
        Swap(list, pivotindex, e);

        return pivotindex;
    }

    static void Swap(List<char> list, int s, int e)
    {
        char temp = list[s];
        list[s] = list[e];
        list[e] = temp;
    }
}