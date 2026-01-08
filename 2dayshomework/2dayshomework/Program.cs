namespace _2dayshomework;

class Program
{
    static void Main(string[] args)
    {
        OneHandSword woodsword = new("나무막대기" ,5);
        Character player = new("kim",100,woodsword);
        player.attack();
    }
}