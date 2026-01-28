namespace ct_test_4;

public class ct_3
{
    public void Solution()
    {
        string skill = "CBD";
        String[] skill_trees = {"BACDE", "CBADF", "AECB", "BDA"};

        List<string> list = new List<string>();
        List<char> list2 = new List<char>(); 
        List<char> list3 = new List<char>();
        list = skill_trees.ToList();
        list2 = skill.ToList();
        list3 = list[0].ToList();
        

        Console.WriteLine(CheckSkill(list2, list3));
    }

    public bool CheckSkill(List<char> list2, List<char> list3)
    {
        char pivot = list2[0];

        for (int i = 1; i < list3.Count; i++)
        {
            if (list3[i] < pivot)
            {
                return false;
            }
        }
        
        return true;
    }
}