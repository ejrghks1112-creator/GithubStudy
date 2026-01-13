using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[,] maps = new int[n.m];
    }

    public List<int> BFS(int start)
    {
        int n = 5;
        int m = 5;
        
        List<(int,int)> path = new();
        Queue<(int,int)> queue = new Queue<(int,int)>();

        bool[,] visited = new bool [n,m];
        visited[1,1] = true;
        queue.Enqueue((1, 1));

        while (queue.Count > 0)
        {
             (int currentX, int currentY) = queue.Dequeue();
            path.Add((currentX , currentY));

            for (int i = 0; i < n - 1; i++)
            {
                if(maps[n,i] && !visited[i])
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