// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hangman Guessing Game!");
Console.WriteLine("you have a total of 10 Guesses");

Random rnd = new Random();

string[] names = new string[] { "peaches", "apples", "oranges" };

int guessMeIndex = 0;
string guessMe;
string secretword = "code";
string Guess = "";
int guesslimit = 10;
bool outofguesses = false;
int guesscount = 0;




while (Guess != secretword && outofguesses != true )
{

    for (int i = 0; i < 3; i++)
    {
        guessMeIndex = rnd.Next(0, 3);
        guessMe = names[guessMeIndex];
        Console.WriteLine(guessMe);
    }
    guessMeIndex = rnd.Next(0, 3);
    guessMe = names[guessMeIndex];



    if (guesscount<guesslimit)
    {

        Console.Write("Enter the Guess word:");
        Guess = Console.ReadLine();
        guesscount++;
    }
     else
    {
        outofguesses = true;
    }

    if (outofguesses)
    {
        Console.WriteLine("you lose");
    }


    
    


}


void PrintDashes(string secretword)
{
    Console.OutputEncoding = System.Text.Encoding.Unicode;
    Console.Write("code");
  
}

foreach (string name in names)
{
    Console.Write(" _ ");
}

int lengthOfWordToGuess = secretword.Length;

