namespace _260101;

public class Study1
{
    public int Solution()
    {
        // 두 수의 연산값 비교하기 
        
        //  12 + 3 = 123?  형변환 string => int
        
        int a = 2;
        int b = 91;
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