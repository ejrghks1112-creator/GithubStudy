namespace _260101;

public class Study2
{
    // 홀 짝 구분하기
    
    // 연산자 %를 이용해 나머지값이 존재하면 홀수로 반환 0이면 짝수로 반환한다

    public void Solution()
    {
        int n = 157;

        if (n % 2 == 0)
        {
            Console.WriteLine($"{n} is even");
        }
        else if (n % 2 != 0)
        {
            Console.WriteLine($"{n} is odd");
        }
    }
}