// See https://aka.ms/new-console-template for more information
using System;
using Mission2Ass;
using static System.Console;

WriteLine("Welcome to the Dice Throwing Simulator!");

diceSim SimDice = new diceSim();

int numRolls = 0; // create numRolls

WriteLine("How many dice rolls would you like to simulate?");
numRolls = int.Parse(ReadLine()); // get the input

int[] rollResults = // assign result array to roll results
    SimDice.SimulateRolls(numRolls); // call the SimulateRolls method and pass numRolls
int[] rollPercentage =
    rollResults.Select(x => x * 100 / numRolls).ToArray(); // calculate the percentage of each roll
for (int i = 2; i < rollPercentage.Length; i++) // loop through the rollPercentage array
{
    string
        percentage =
            new string('*', rollPercentage[i]); // create a string of '*' characters based on the percentage
    WriteLine(i + ": " + percentage); // display the number and the percentage
}





