namespace _251217_김덕환;

class Program
{
    static void Main(string[] args)
    {
        Tester tester = new();
        tester.Run();

        int a = 2;
        int b = 5;
        float c = 2f;
        float d = 4f;

        SwapT.Swap(ref a, ref b);
        SwapT.Swap(ref c, ref d);

        Console.WriteLine($"a = {a}, b = {b}");
        Console.WriteLine($"c = {c}, d = {d}");
    }
    
    
}
public static class SwapT
{
  public static void Swap<T>(ref T a, ref T b) where T : struct
  {
    T temp = a;
    a = b;
    b = temp;
  }
}