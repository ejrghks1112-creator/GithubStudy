namespace _251217_김덕환;

public class Tester
{
    public void Run()
    {
        
    }
}

public interface IInteractable
{
    public void Interact();
}

public interface IBreakable
{
    public void Break();
}
public class Item
{
    
}

public class Chair : Item, IInteractable,IBreakable
{
    public void Interact()
    {
        Console.WriteLine("앉기");
    }

    public void Break()
    {
        Console.WriteLine("깨짐");
    }
}
 
