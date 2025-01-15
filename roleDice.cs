namespace Mission2BradenStevens;

public class roleDice
{
    public int[] roleTheDice(int NumTimeToRole)
    {
        Random rnd = new Random();
        
        int[] rolesArray = [0,0,0,0,0,0,0,0,0,0,0];
        
        for (int i = 0; i < NumTimeToRole; i++)
        {
            int role1Value = rnd.Next(1,7);
            int role2Value = rnd.Next(1,7);
            int totalValue = role1Value + role2Value;
            int indexValue = totalValue - 2;
            rolesArray[indexValue] = rolesArray[indexValue] + 1;
        }
        
        return rolesArray;
    }
}