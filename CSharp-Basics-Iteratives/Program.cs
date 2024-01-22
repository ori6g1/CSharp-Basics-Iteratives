// ---- C# I (Dor Ben Dor) ----
// Ori Shacham-Barr
// ----------------------------

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