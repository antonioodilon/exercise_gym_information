using System;
using System.Collections.Generic;

Console.Write("How many exercises would you like to insert?");
string? amountExercisesStr = Console.ReadLine();
int amountExercisesInt;
bool success = true;
success = Int32.TryParse(amountExercisesStr, out amountExercisesInt);
if (success)
    Console.WriteLine("Parsing was a success. Continuing with the program");
else
    Console.WriteLine("Parsing from string to integer was a failure (Are you sure you only typed"+
    " integer numbers?). Aborting.");

// An array of type int with space for amountExercisesInt values:
int[] weights = new int[amountExercisesInt];
string?[] arrayExercises = new string[amountExercisesInt];

string? nameExercise;
string? weightCurrentExerciseStr;
int weightCurrentExerciseInt;
int i = 1;
while (i <= weights.Length)
{
    bool success2 = true;
    Console.Write($"What is the name of exercise number {i}? ");
    nameExercise = Console.ReadLine();
    arrayExercises[i - 1] = nameExercise;

    Console.Write($"How much weight do you put on the {nameExercise}? ");
    weightCurrentExerciseStr = Console.ReadLine();
    success2 = Int32.TryParse(weightCurrentExerciseStr, out weightCurrentExerciseInt);

    if (success2)
        {
            Console.WriteLine("Parsing was a success. Continuing with the program.");
            weights[i - 1] = weightCurrentExerciseInt;
        }
    else
        {
            Console.WriteLine("Parsing from string to integer was a failure (Are you sure you only typed"+
            " integer numbers?). Aborting.");
            break;
        }

    ++i;
}

Console.WriteLine("======================================");

int j;
Console.WriteLine("Here are the exercises and the weights you put on each one of them:");
for (j = 0; j < amountExercisesInt; ++j)
{
    Console.WriteLine($"{arrayExercises[j]}: {weights[j]} kg");

}