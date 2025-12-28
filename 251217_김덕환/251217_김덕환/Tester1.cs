namespace _251217_김덕환;

public abstract class Monster
{
    public abstract void Skill();
}

public class Goblin : Monster
{
    public override void Skill()
    {
        Console.WriteLine("찌르기 공격");
    }
}


public class Slime : Monster
{
    public override void Skill()
    {
        Console.WriteLine("누르기 공격");
    }
}

public class Balrog : Monster
{
    public override void Skill()
    {
        Console.WriteLine("베기 공격");
    }

    public void Say()
    {
        Console.WriteLine("말함");
    }
}