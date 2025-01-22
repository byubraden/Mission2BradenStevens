namespace Mission2BradenStevens;

public class roleDice
{
    public int[] roleTheDice(int NumTimeToRole)
    {
        // Yes I know I used the wrong roll above haha
        Random rnd = new Random();
        
        // Create the roles array
        int[] rollsArray = [0,0,0,0,0,0,0,0,0,0,0];
        
        // Roll the number of dice for the number of times the user asked
        for (int i = 0; i < NumTimeToRole; i++)
        {
            int roll1Value = rnd.Next(1,7);
            int roll2Value = rnd.Next(1,7);
            int totalValue = roll1Value + roll2Value;
            int indexValue = totalValue - 2;
            rollsArray[indexValue] = rollsArray[indexValue] + 1;
        }
        
        // Return the array of counts of each number rolled
        return rollsArray;
    }
}