namespace _251217_김덕환;

public class Tester
{
    public void Run()
    {
        Player player = new();
        GameUI ui = new(player);

        Console.Clear();
        ui.PrintHealthUI(player.Health);
        
        while (true)
        {
            ConsoleKey input = Console.ReadKey(true).Key;

            if (input == ConsoleKey.W)
            {
                player.TakeDamage(1);
            }
        }
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
 
