namespace ct_test_6;

class Program
{
    static void Main(string[] args)
    {
        ct3 ct  = new ct3();
        ct.Solution(80,new int[,] { { 80, 20 }, { 50, 40 }, { 30, 10 } });
        Console.WriteLine(ct.Solution(80,new int[,] { { 80, 20 }, { 50, 40 }, { 30, 10 } }));
    }
}