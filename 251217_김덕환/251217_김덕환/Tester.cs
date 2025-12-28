namespace _251217_김덕환;

public class Tester
{
   public void Run()
   {
      Balrog balrog = new();
      Monster[] mons = new Monster[3]
      {
         new Balrog(),
         new Goblin(),
         new Slime()
      };
      foreach (Monster mon in mons)
      {
         mon.Skill();
      }
   }
}