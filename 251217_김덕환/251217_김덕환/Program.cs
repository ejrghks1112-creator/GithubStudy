namespace _251217_김덕환;

class Program
{
    public delegate void VoidDel();

    public static event VoidDel voidDel;
    static void Main(string[] args)
    {
        HealthDel += delegate()
        {

        };
        voidDel += delegate()
        {
            Console.WriteLine("dwwf");
        };
        
    }
}