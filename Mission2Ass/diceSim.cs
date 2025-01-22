namespace Mission2Ass;
using System;
public class diceSim // create a static class for the dice roll simulator
{
    public int[] SimulateRolls(int numRolls) // method to simulate dice rolls
    {
        Random random = new Random(); // create a new instance of the Random class

        int[] rolls = new int[13]; // create an array to store the results

        for (int i = 0; i < numRolls; i++) // loop through the number of die rolls
        {
            int tempRoll1 = random.Next(1, 7);// get a random number between 1 and 6 for the first die
            int tempRoll2 = random.Next(1, 7);// get a random number between 1 and 6 for the second die
            int rollSum = tempRoll1 + tempRoll2; // calculate the sum of the two dice rolls
            rolls[rollSum]++; // increment the corresponding index in the rolls array
        }
        return rolls; // return the array of roll results to the main program
    }
}