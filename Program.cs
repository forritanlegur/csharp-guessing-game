//Get text file, has to be next to the .exe file
string target = "ROBOtext.txt";
FileInfo fileInfo = new FileInfo(target);
string path = fileInfo.FullName;

//Creating Array from txt file.
string[] lines;
lines = File.ReadLines(path).ToArray();



//-----------------------------------------Checking if filepath works.. Use as needed----------------------------------------------------------------------------
//Console.WriteLine("The path to the .txt is: " + path);
//Console.WriteLine();
//Console.WriteLine("The array is: [{0}]", string.Join(", ", lines));
//----------------------------------------------------------------------------------------------------------------------------------------------------------------



while (true)
{
    Console.WriteLine();
    Console.WriteLine("YOU MUST GUESS A RANDOMLY SELECTED WORD");
    Console.WriteLine("THE WORD WILL ALWAYS BE FIVE LETTERS LONG.");
    Console.WriteLine("YOU WILL BE TOLD WHAT CHARACTERS YOU GUESSED CORRECTLY, IF ANY.");
    Console.WriteLine();
    //Get random word
    Random random = new Random();
    int randomNumber = random.Next(1, 63);

    //Time for user to guess
    bool guessing = true;

    while (guessing)
    {


        //---------------------------------Select random number in array. this is hereby known as the SECRET WORD------------------------------------------
        string secretWord = lines[randomNumber];
        //below code will display the word if u wanna cheat
        //Console.WriteLine("This is a secret word  " + secretWord);
        //-------------------------- --------------end of secret word generation------------------------------------------------------------------------------
        //Now we are finding each char in the random word
        char[] secretWordChar = new char[secretWord.Length];


        for (int i = 0; i < secretWord.Length; i++)
        {
            secretWordChar[i] = secretWord[i];
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------

        Console.WriteLine();
        Console.WriteLine("INPUT GUESS: ");
        string? userInput = Console.ReadLine();
        userInput = userInput.ToLower();



        //Checking the input for characters that exist inside the SECRET WORD
        if (userInput != secretWord)
        {
            for (int i = 0; i < secretWord.Length; i++)
            {
                if (userInput.Contains(secretWordChar[i]))
                {
                    Console.WriteLine(secretWordChar[i] + "  is a correct letter");

                }
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("CONGRATULATIONS YOU GUESSED THE WORD. IT WAS " + secretWord.ToUpper());
            guessing = false;
            break;
        }
    }
    Console.WriteLine("PLAY AGAIN    [1]");
    Console.WriteLine("EXIT          [2]");
    Console.WriteLine();
    if (Console.ReadLine() != "1")
    {
        break;
    }

}

Console.WriteLine("You reached the end!");
