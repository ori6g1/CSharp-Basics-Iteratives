// ---- C# I (Dor Ben Dor) ----
// Ori Shacham-Barr
// ----------------------------

using System.ComponentModel;
using System.Runtime.InteropServices;

string input;
string lineBreak = "\r\n";
string messageStart, messageMiddle, messageEnd;

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

// D - Loops
// 1
int naturalNumbersAmount = 10;
Console.Write($"The first {naturalNumbersAmount} natural numbers are: ");

for (int i = 1; i <= naturalNumbersAmount; i++)
    Console.Write($" {i} ");

// 2
int[] items = new int[] { 1, 2, 5, 4, 8, 4, 10};
int maxNumber = items[0], minNumber = items[0];

for (int i = 1; i < items.Length; i++)
{
    if (items[0] > maxNumber)
        maxNumber = items[0];
    else if (items[0] < minNumber)
        minNumber = items[0];
}
Console.WriteLine("The difference between the largest number and the smallest number is " + (maxNumber - minNumber));
Console.WriteLine(lineBreak);

// 3
int[] randomNumberArray = new int[50];

for (int i = 0; i < randomNumberArray.Length; i++)
    randomNumberArray[i] = Random.Shared.Next(1, 100);

Console.Write("Enter a value to search: ");
int value = int.Parse(Console.ReadLine());

for (int i = 0; i < randomNumberArray.Length; i++)
{
    if (value == randomNumberArray[i])
    {
        Console.WriteLine($"The index of value {value} is {i}.");
        break;
    }
    else if (i == (randomNumberArray.Length - 1))
    {
        Console.WriteLine($"The value {value} is not in the array.");
        break;
    }
}
Console.WriteLine(lineBreak);

// 4
float[] floatArray = new float[] {1.2f, -10f, 9.9f, -12, -1.1f};
float absoluteSum = 0f;

for (int i = 0; i < floatArray.Length; i++)
    absoluteSum += Math.Abs(floatArray[i]);

Console.WriteLine($"The absolute sum of the floats in the array is {absoluteSum}");
Console.WriteLine(lineBreak);

// 5
Console.Write("Enter a range where x is smaller than y.");
int xMinima, yMaxima;

do
{
    Console.Write("Enter x value: ");
    xMinima = int.Parse(Console.ReadLine());

    Console.Write("Enter y value: ");
    yMaxima = int.Parse(Console.ReadLine());
} while (xMinima < yMaxima);

int averageSum = 0;
for (int i = xMinima; i <= yMaxima; i++)
    averageSum += i;

Console.WriteLine("The average of the numbers in the range is " + (averageSum / (yMaxima - xMinima)));
Console.WriteLine(lineBreak);

// E - Strings
// 1
Console.Write("Enter a sentence to ALLCAPS: ");
string sentence = Console.ReadLine();
string capsSentence = "";

for (int i = 0; i < sentence.Length; i++)
{
    if (sentence[i] >= 97 && sentence[i] <= 122)
        capsSentence += (char)(sentence[i] - 32);
    else
        capsSentence += sentence[i];
}
Console.WriteLine($"The new ALLCAPSED'ed sentence is: {capsSentence}");
Console.WriteLine(lineBreak);

// 2
Console.Write("Enter a sentence to sPoNgIfY: ");
sentence = Console.ReadLine();
string spongeSentence = "";

for (int i = 0; i < sentence.Length; i++)
{
    if (sentence[i] >= 97 && sentence[i] <= 122 && (i % 2) == 0)
        spongeSentence += (char)(sentence[i] - 32);
    else
        spongeSentence += sentence[i];
}
Console.WriteLine($"The new spongified sentence is: {spongeSentence}");
Console.WriteLine(lineBreak);

// 3
Console.Write("Enter a word to check if it's an isogram: ");
string word = Console.ReadLine();
bool isIsogram = false;

for (int i = 0; i < word.Length; i++)
{
    for (int j = (i + 1); j < word.Length; j++)
    {
        if (word[j] == word[i])
        {
            isIsogram = true;
            Console.WriteLine($"The word {word} is an isogram.");
            break;
        }
    }
}

if (!isIsogram)
    Console.WriteLine($"The word {word} is not an isogram.");
Console.WriteLine(lineBreak);

// F - The Blind Hero
messageStart = "> ";
Console.WriteLine($"{messageStart}The following commands are available to you: up, down, right, left, status, end");

input = "";
int[] heroLocation = new int[] { 0, 0 };
string[] command;

while ( input != "end" )
{
    Console.Write(messageStart);
    input = Console.ReadLine();
    command = input.Split(" ");
    
    switch (command[0])
    {
        case "up":
            if (command.Length > 1)
                heroLocation[1] += int.Parse(command[1]);
            break;
        case "down":
            if (command.Length > 1)
                heroLocation[1] -= int.Parse(command[1]);
            break;
        case "right":
            if (command.Length > 1)
                heroLocation[0] += int.Parse(command[1]);
            break;
        case "left":
            if (command.Length > 1)
                heroLocation[0] -= int.Parse(command[1]);
            break;
        case "status":
            Console.WriteLine($"{messageStart}({heroLocation[0]}, {heroLocation[1]})");
            break;
        case "end":
            break;
        default:
            Console.WriteLine($"{messageStart}There is no such command");
            break;
    }
}
