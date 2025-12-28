namespace _251217_김덕환;

public class Tester
{
    public void Run()
    {
        int a = 10;

        Console.WriteLine(a.IsEven());
        
    }
}

public static class Extension
{
    public static bool IsEven(this int value)
    {
        return value % 2 == 0;
    }
}

public class Player
{
    private int _health = 100;

    public delegate void HealthDel(int _health);

    public HealthDel OnHealthChanged;
    

    public int Health
    {
        get
        {
            return _health;
        }
        set
        {
            _health = value;
            OnHealthChanged?.Invoke(_health);
        }
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }
    
}

public class GameUI
{
    private Player _player;

    public GameUI(Player player)
    {
        _player.OnHealthChanged += PrintHealthUI;
        // _player.OnHealthChanged += PrintPopUp;
    }
    
    public void PrintHealthUI(int health)
    {
        Console.WriteLine($"플레이어의 현재 체력 : {health}");
    }

    public void PrintPopUp()
    {
        Console.WriteLine("1뎀지");
    }
}
 
