// See https://aka.ms/new-console-template for more information

using Mission2BradenStevens;

internal class Program
{
    public static void Main(string[] args)
    {
        roleDice rd = new roleDice();
        
        
        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        
        System.Console.WriteLine("How many dice rolls would you like to simulate?");
        
        int numRoles = int.Parse(Console.ReadLine());
        
        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        System.Console.WriteLine("Total number of rolls = "+ numRoles + ".");
        
        int[] roleDistribution = rd.roleTheDice(numRoles);
        
        int roleTotalNumber = 2;
        foreach(var item in roleDistribution)
        {
            string starString = "";
            
            int numStars = (int)Math.Round(((float)item / numRoles) * 100);

            for (int i = 0; i < numStars; i++)
            {
                starString += "*";
            }

            Console.WriteLine(roleTotalNumber + ": " + starString);
            roleTotalNumber += 1;
        }
        
        System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        
    }
}