// See https://aka.ms/new-console-template for more information









    int WordPrinted(List<char> PreviousGuessed, string randomChosenWord)
    {
        int counter = 0;
        int rightLetters = 0;
        Console.Write("\r\n");
        foreach (char c in randomChosenWord)
        {
            if (PreviousGuessed.Contains(c))
            {
                Console.Write(c + " ");
                rightLetters += 1;
            }
            else
            {
                Console.Write("  ");
            }
            counter += 1;
        }
        //Console.Write("\r\n");
        return rightLetters;
    }

     void printLines(string randomChosenWord)
    {
        Console.Write("\r");
        foreach (char c in randomChosenWord)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("\u0305 ");
        }
    }

void Main()
    {
        Console.WriteLine("--------");
        Console.WriteLine("HANGMAN!");
        Console.WriteLine("---------");

        Random random = new Random();
        List<string> wordDictionary = new List<string> { "peaches", "Oranges", "Apples", "peron", "pinneaple", "Mango", "banana", "Avocado" };
        int index = random.Next(wordDictionary.Count);
        String randomChosenWord = wordDictionary[index];
        
        Console.WriteLine("Type 1: to Guess one letter each time: 2: To Guess the whole word");
        int choice = int.Parse(Console.ReadLine());


        foreach (char x in randomChosenWord)
        {
            Console.Write("_ ");
        }

        int lengthOfWordToGuess = randomChosenWord.Length;
        int amountOfTimesWrong = 0;
        List<char> currentLettersGuessed = new List<char>();
        int currentLettersRight = 0;

        while (amountOfTimesWrong != 10 && currentLettersRight != lengthOfWordToGuess)
        {
            if (choice == 1)
            {
                Console.Write("\nLetters guessed so far: ");
                foreach (char letter in currentLettersGuessed)
                {
                    Console.Write(letter + " ");
                }
                

                Console.Write("\nGuess a letter: ");


                char letterGuessed = Console.ReadLine()[0];
                
                if (currentLettersGuessed.Contains(letterGuessed))
                {
                    Console.Write("\r\n You have already guessed this letter");
                    GameLevel(amountOfTimesWrong);
                    currentLettersRight = WordPrinted(currentLettersGuessed, randomChosenWord);
                    printLines(randomChosenWord);
                }
                else
                {
                    
                    bool right = false;
                    for (int i = 0; i < randomChosenWord.Length; i++) { if (letterGuessed == randomChosenWord[i]) { right = true; } }

                    
                    if (right)
                    {
                        GameLevel(amountOfTimesWrong);
                        
                        currentLettersGuessed.Add(letterGuessed);
                        currentLettersRight = WordPrinted(currentLettersGuessed, randomChosenWord);
                        Console.Write("\r\n");
                        printLines(randomChosenWord);
                    }
                    
                    else
                    {
                        amountOfTimesWrong += 1;
                        currentLettersGuessed.Add(letterGuessed);
                        
                        GameLevel(amountOfTimesWrong);
                        
                        currentLettersRight = WordPrinted(currentLettersGuessed, randomChosenWord);
                        Console.Write("\r\n");
                        printLines(randomChosenWord);
                    }
                }
                
            }

            else
            {
                if (choice == 2)
                {
                    Console.WriteLine("Guess the whole word ");
                    string WholeWordGuess = Console.ReadLine();
                    Dictionary<string, int> previouslyGussed = new Dictionary<string, int>();

                    if (WholeWordGuess == randomChosenWord)
                    {
                        Console.WriteLine("Congrats you Gussed the Rightword");
                        Console.WriteLine(WholeWordGuess);
                        amountOfTimesWrong = 10;
                    }
                    else if (previouslyGussed.ContainsKey(WholeWordGuess))
                    {
                        Console.WriteLine("You already guessed this word: Im not consuming your guess");
                        printLines(randomChosenWord);
                        GameLevel(amountOfTimesWrong);


                    }
                    else
                    {
                        Console.WriteLine("You guessed Wrong");
                        printLines(randomChosenWord);
                        amountOfTimesWrong += 1;
                        GameLevel(amountOfTimesWrong);

                    }


                    Console.WriteLine("Im gussing the whole letter");




                }
            }

        }
        Console.WriteLine("\r\nGame is over! Thank you for playing ");
    }


    void GameLevel(int wrong)
    {
        switch (wrong)
        {
            case 0:
                
                break;

            case 1:
               
                break;

            case 2:
                
                break;

            case 3:
              
                break;


            case 4:
                

                break;

            case 5:
              

                break;

            case 6:
               
                break;

            case 7:
                
                break;

            case 8:
                
                break;

            case 9:
                
                break;

            case 10:
               
                break;

        }

    }

Main();
