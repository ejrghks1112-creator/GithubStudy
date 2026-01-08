namespace _2dayshomework;

public interface Attackable
{
    int attack();
}

public  class Character 
{
    private string Name { get; set; }
    private int Health { get; set; }
    private Attackable Weapon { get; set; }

    public Character(string name, int health, Attackable weapon)
    {
        Name = name;
        Health = health;
        Weapon = weapon;
    }

    public int attack()
    {
        return Weapon.attack();
    }

    public void changeWeapon(Attackable weapon)
    {
        Weapon = weapon;
    }

}

public class OneHandSword : Attackable
{
    private string Name { get; set; }
    private int Damage { get; set; }

    public OneHandSword(string name, int damage)
    {
        Name = name;
        Damage = damage;
    }

    public int attack()
    {
        return Damage;
    }
}

public class WoodSword : OneHandSword
{
    public WoodSword(string name, int damage) : base(name, damage)
    {
        Console.WriteLine("");
    }
}

public class StoneSword : OneHandSword
{
    public StoneSword(string name, int damage) : base(name, damage)
    {
    }
}

public class ChargeAxe : Attackable
{
    private string Name { get; set; }
    private int Damage { get; set; }

    public ChargeAxe(string name, int damage)
    {
        Name = name;
        Damage = damage;
    }

    public int attack()
    {
        return Damage;
    }
}

public class HeavyBowGun: Attackable
{
    private string Name { get; set; }
    private int Damage { get; set; }

    public HeavyBowGun(string name, int damage)
    {
        Name = name;
        Damage = damage;
    }

    public int attack()
    {
        return Damage;
    }
    
}

public class Lance: Attackable
{
    private string Name { get; set; }
    private int Damage { get; set; }

    public Lance(string name, int damage)
    {
        Name = name;
        Damage = damage;
    }

    public int attack()
    {
        return Damage;
    }
    
}

public class Bow: Attackable
{
    private string Name { get; set; }
    private int Damage { get; set; }

    public Bow(string name, int damage)
    {
        Name = name;
        Damage = damage;
    }

    public int attack()
    {
        return Damage;
    }
    
}