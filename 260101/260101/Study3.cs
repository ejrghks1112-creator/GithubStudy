namespace _260101;

public class Study3
{
    // 하샤드 수 
    // x = 13;  1+3 = 4   X/4 = 0

    public bool solution(int x)
    {
        //x = int 형변환으로 string 으로 만들어 첫자리와 둘째자리를 합친다
        //                                    string은 char의 배열이니까 string[0][1]을 더하면 될것이다?
        bool answer;
        string a = $"{x}";
        // char c = a[0];
        // Console.WriteLine($"1 - {c}");
        // char d = a[1];
        // Console.WriteLine($"2 - {d}");
        
        //얘네가 문제였다 ..... 의미가 없으면 지우도록 하자 제한조건의 수가 1자리일 경우 char d를 해결 못해서 터지는 거였다...
        
        // int b = (a[0]) + (a[1]);
        //? 배열안에서 이상한게 튀어나온다
        // 아스키코드란다 0을 48로 시작하기에 '0'을 빼주면 해결...... 되는줄 알았다 제한조건의 수가 10000까지다...(...)
        // 그래서 문자열의 크기만큼 배열을 돌리면 되는줄 알았다.... 런타임 에러는 사라지지 않는다...
        // int b = (c - '0') + (d - '0');
        int b = 0;
        for (int i = 0; i < a.Length; i++)
        {
            b += a[i]-'0';
        }
        
        Console.WriteLine($"3 - {b}");
        if (x % b != 0)
        {
            answer = false;
            return answer;
        }
        else
        {
            answer = true;
            return answer;
        }
    }
}

// bool answer;
//         
// string a = $"{x}";
//         
// Console.WriteLine(a);
// int b = a[0] + a[1];
// //? 배열안에서 이상한게 튀어나온다
// Console.WriteLine(b);
// if (x / b != 0)
// {
//     answer = false;
//     return answer;
// }
// else
// {
//     answer = true;
//     return answer;
// }