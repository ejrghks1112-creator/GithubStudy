namespace _260101;

class Program
{
    static void Main(string[] args)
    {
        // 두 수의 연산값 비교하기 
        
        //  12 + 3 = 123?  형변환 string => int

        int a = 91;
        int b = 2;
        Console.WriteLine(Solution(a,b));

    }

    public static int Solution(int a, int b)
    {
        
        string c = $"{a}{b}";
        Console.WriteLine(c);
        int d;
        d = int.Parse(c);
        Console.WriteLine(d);
        int e = a * b * 2;
        int answer;
        if (d > e) return answer = d;
        else return answer = e;
        
    }
}
