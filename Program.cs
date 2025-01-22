// See https://aka.ms/new-console-template for more information

using Mission2BradenStevens;

internal class Program
{
    public static void Main(string[] args)
    {
        roleDice rd = new roleDice();
        
        //Give the user some instructions
        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        
        // Ask how many dice they would like to roll
        System.Console.WriteLine("How many dice rolls would you like to simulate?");
        
        // Store the num of rolls as 
        int numRolls = int.Parse(Console.ReadLine());
        
        // Return the results
        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        System.Console.WriteLine("Total number of rolls = "+ numRolls + ".");
        
        // Store the array returned from the method
        int[] roleDistribution = rd.roleTheDice(numRolls);
        
        int roleTotalNumber = 2;
        
        // Put together the output text
        foreach(var item in roleDistribution)
        {
            string starString = "";
            
            int numStars = (int)Math.Round(((float)item / numRolls) * 100);

            for (int i = 0; i < numStars; i++)
            {
                starString += "*";
            }

            Console.WriteLine(roleTotalNumber + ": " + starString);
            roleTotalNumber += 1;
        }
        
        // end
        System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        
    }
}