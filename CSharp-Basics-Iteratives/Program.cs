// ---- C# I (Dor Ben Dor) ----
// Ori Shacham-Barr
// ----------------------------

using System.ComponentModel;
using System.Runtime.InteropServices;

string input;
string lineBreak = "\r\n";
string messageStart, messageMiddle, messageEnd;
/*
// A - Arrays (W.I.C)
// 1
int[] numberArray =  new int[] {0, 1, 2, 3, 4};

Console.WriteLine("The fourth number in the array is " + numberArray[3] + ".");
Console.WriteLine(lineBreak);

//2
string[] favoriteFoods = new string[] { "fajita", "ramen", "pizza", "fried rice", "eggs royale", "napoleon cake" };

Console.Write("Enter a number and I will tell you what food I like based on it: ");
input = Console.ReadLine();
Console.WriteLine("My #" + int.Parse(input) + " favorite food is " + favoriteFoods[int.Parse(input) - 1] + ".");
Console.WriteLine(lineBreak);

//3
float[] floatArray = new float[] {1.1f, 2.2f, 3.3f, 4.4f};

Console.WriteLine("The sum of all the numbers is " + (floatArray[0] + floatArray[1] + floatArray[2] + floatArray[3]));
Console.WriteLine(lineBreak);

// B - For & While Loops (W.I.C)
// 1
string username = "ori", password = "123123";
string inputUsername, inputPassword;
bool areCredentialsCorrect = false;

while (!areCredentialsCorrect)
{
    Console.Write("Enter a username: ");
    inputUsername = Console.ReadLine();
    
    Console.Write("Enter a password: ");
    inputPassword = Console.ReadLine();

    if (inputUsername == username && inputPassword == password)
    {
        Console.WriteLine("Credentials are correct!");
        areCredentialsCorrect = true;
    }
    else
        Console.WriteLine("Password or username are wrong :( Try again.");
}
Console.WriteLine(lineBreak);

// 2
int sum = 0;

for (int i = 0; i <= 20; i++)
    sum += i;

Console.WriteLine("The sum of the first 20 natural numbers is " + sum);
Console.WriteLine(lineBreak);

// 3
int[] iterativeNumberArray = new int[] {1, 2, 4, 6, 0, -3};
int lowestNumber = iterativeNumberArray[0];

for (int i = 1; i < iterativeNumberArray.Length; i++)
{
    if (lowestNumber > iterativeNumberArray[i])
        lowestNumber = iterativeNumberArray[i];
}

Console.WriteLine("The lowest number in the array is " + lowestNumber);
Console.WriteLine(lineBreak);

// 4
int playerHealth = 3,  aiHealth = 3;
int aiRandomChoice, playerChoice;

string[] opponentChoiceStart = new string[] { "Opponent chose rock", "Opponent chose paper", "Opponent chose scissors" };
string playerLifeLoss = ", you lose 1 life.", aiLifeLoss = ", opponent loses 1 life.";

while (playerHealth > 0 && aiHealth > 0)
{
    Console.WriteLine("Player hp: " + playerHealth + ". Opponent hp: " + aiHealth);
    Console.Write("Choose rock(1), paper(2), scissors(3): ");
    playerChoice = int.Parse(Console.ReadLine());

    aiRandomChoice = Random.Shared.Next(1, 3);
    Console.Write(opponentChoiceStart[aiRandomChoice - 1]);

    if (playerChoice == aiRandomChoice)
        Console.WriteLine(", tie");

    switch (playerChoice)
    {
        case 1:
            if (aiRandomChoice == 2)
            {
                Console.WriteLine(playerLifeLoss);
                playerHealth--;
            }
            else if (aiRandomChoice == 3)
            {
                Console.WriteLine(aiLifeLoss);
                aiHealth--;
            }
            break;
        case 2:
            if (aiRandomChoice == 1)
            {
                Console.WriteLine(aiLifeLoss);
                aiHealth--;
            }
            else if (aiRandomChoice == 3)
            {
                Console.WriteLine(playerLifeLoss);
                playerHealth--;
            }
            break;
        case 3:
            if (aiRandomChoice == 1)
            {
                Console.WriteLine(aiLifeLoss);
                aiHealth--;
            }
            else if (aiRandomChoice == 2)
            {
                Console.WriteLine(playerLifeLoss);
                playerHealth--;
            }
            break;
        default:
            Console.WriteLine(" you gave an invalid input.");
            break;
    }
}

if (playerHealth == 0)
    Console.WriteLine("You lost!");
else
    Console.WriteLine("Opponent lost!");
Console.WriteLine(lineBreak);
*/
// C - Jumping Statements (W.I.C)
// 1
Console.Write("The following numbers are divisibles of 4: 4");

for (int i = 5; i <= 100; i++)
{
    if ((i % 4) == 0)
        Console.Write($", {i}");
}
Console.WriteLine(lineBreak);

// 2
int numberToGuess = 7, guessAmount = 1;
Console.Write("Guess the number I am thinking of between 1-10: ");
input = Console.ReadLine();

while (int.Parse(input) != numberToGuess)
{
    Console.Write("Wrong. Guess again: ");
    input = Console.ReadLine();
    guessAmount++;
}
Console.WriteLine($"The number I was thinking of is {numberToGuess} and it took you {guessAmount} guesses.");
Console.WriteLine(lineBreak);

// 3
Console.Write("Enter the minimum number to check: ");
int minRange = int.Parse(Console.ReadLine());
Console.Write("Enter the maximum number to check: ");
int maxRange = int.Parse(Console.ReadLine());

Console.Write("The following numbers are divisibles of 4: ");

for (int i = minRange; i <= maxRange; i++)
{
    if ((i % 4) == 0)
        Console.Write($" {i} ");
}
Console.WriteLine(lineBreak);

// 4
Console.Write("Enter the divisor to check: ");
int divisor = int.Parse(Console.ReadLine());
Console.Write("Enter the minimum number to check: ");
minRange = int.Parse(Console.ReadLine());
Console.Write("Enter the maximum number to check: ");
maxRange = int.Parse(Console.ReadLine());

Console.Write($"The following numbers are divisibles of {divisor}: ");

for (int i = minRange; i <= maxRange; i++)
{
    if ((i % divisor) == 0)
        Console.Write($" {i} ");
}
Console.WriteLine(lineBreak);