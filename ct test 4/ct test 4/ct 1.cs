namespace ct_test_4;

public class ct_1
{
    public void Solution()
    {
        int[] array = new[] { 9, -1, 0 };
        List<int> list = new List<int>();
        list = array.ToList();

        int low = 0;
        int high = list.Count - 1;

        QuickSort(list, low, high);

        int answer = list[list.Count / 2];
        Console.WriteLine(answer);
    }
    
    void QuickSort(List<int> list, int low, int high)
    {
        if (low >= high) return;
        
        int pivot = Partition(list, low, high);
        
        QuickSort(list, low, pivot - 1);
        QuickSort(list, pivot + 1, high);
    }

    int Partition(List<int> list, int low, int high)
    {
        int pivot = list[high];
        int j = low - 1;

        for (int i = low; i < high; i++)
        {
            if (list[i] < pivot)
            {
                j++;
                int temp = list[j];
                list[j] = list[i];
                list[i] = temp;
            }
        }

        int pivotIndex = j + 1;
        int temp2 = list[pivotIndex];
        list[pivotIndex] = list[high];
        list[high] = temp2;
        
        return pivotIndex;
    }
}