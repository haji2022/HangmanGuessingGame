
Console.WriteLine("............");

Console.WriteLine("WELLCOM TO HANGMAN!");

Console.WriteLine("............");

Random rnd = new Random();

string[] names = new string[] { "peaches", "apples", "oranges", "peron", "code","smoothie" };

int guessMeIndex = 0;
string guessMe;
string Guess = "";
int guesslimit = 10;
bool outofguesses = false;
int guesscount = 0;


for (int i = 0; i < 9; i++)
{
    guessMeIndex = rnd.Next(0, 9);
    guessMe = names[guessMeIndex];
    Console.WriteLine(guessMe);
    Console.WriteLine("Enter the Guessing word: ");
    
}
guessMeIndex = rnd.Next(0, 3);
guessMe = names[guessMeIndex];


