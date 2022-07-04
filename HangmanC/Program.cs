// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");









Console.WriteLine("---------------------");
            Console.WriteLine("Welcome to Hangman!");
            Console.WriteLine("--------------------");

            string[] FruitNames = { "peaches", "Oranges", "Apples", "peron", "pinneaple", "Mango", "banana", "Avocado" };


            Random random = new Random();
            int FruitListInt = random.Next(0, FruitNames.Length - 1);

            string chosenWord = FruitNames[FruitListInt];
            Console.WriteLine("The word has {0} characters", chosenWord.Length);

            int remainingAttempts = 9;
            List<string> GuessedLetters = new List<string>();
            string displayWord = "";

          for (int i = 0; i < 9; i++)
          {

   

             
            }

            while (remainingAttempts > 0 && displayWord != chosenWord)
            {
                Console.WriteLine("Remaining attempts: {0}", remainingAttempts);

                
                Console.WriteLine("Enter the guessing letter: ");
               char[] input = Console.ReadLine().ToCharArray();

                string guess = "";
                if (input.Length > 0)
                {
                    guess = input[0].ToString();

                }

                GuessedLetters.Add(guess);

                displayWord = "";
                string containedMessage = "";
                if (chosenWord.Contains(guess))
                {
                    containedMessage = "{0} is contained in the word.";
                }
                else
                {
                    containedMessage = "{0} is NOT contained in the word.";
                    remainingAttempts--;
                }

                Console.WriteLine(containedMessage, guess);

                foreach (var letter in chosenWord)
                {
                    if (GuessedLetters.Contains(letter.ToString()))
                    {
                        displayWord += letter;
                    }
                    else
                    {
                        displayWord += "_";
                    }
                }

                Console.WriteLine(displayWord);
                Console.WriteLine();
            } 

            if (remainingAttempts == 0)
            {
                Console.WriteLine("You have ran out of attempts. You lose!");
                Console.WriteLine("The word was: {0}", chosenWord);
            }
            else
            {
                Console.WriteLine("You have won the game!");
            }
        
    
