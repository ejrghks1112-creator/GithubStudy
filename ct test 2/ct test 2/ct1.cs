/*namespace ct_test_2;

public class ct1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            string my_string = "Progra21Sremm3";
            int s = 6; 
            int e = 12;
            List<char> list = new();

            for (int i = 0; i < my_string.Length; i++)
            {
                list.Add(my_string[i]);
            }

            QuickSort(list, s, e);

            foreach (char a in list)
            {
                Console.Write(a);
            }
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
}*/