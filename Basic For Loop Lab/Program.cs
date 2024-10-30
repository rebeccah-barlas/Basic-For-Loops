bool agreePlayAgain = false;

do
{
    Console.WriteLine("Please enter a whole number");
    string userInput = Console.ReadLine();
    int userNumber = 0;
    int userSum = 0;
    bool validNumber = int.TryParse(userInput, out userNumber);

    while (validNumber == false)
    {
        Console.WriteLine("Incorrect input. Please enter a whole number.");
        userInput = Console.ReadLine();
        validNumber = int.TryParse(userInput, out userNumber);
    }

    for (int i = 1; i <= userNumber; i++)
    {
        userSum += i;
    }

    Console.WriteLine($"You total is {userSum}");
    Console.WriteLine("Would you like to continue? (y/n)");
    string playAgain = Console.ReadLine().ToLower();

    if (playAgain == "y")
    {
        agreePlayAgain = true;
    }
    else
    {
        Console.WriteLine("Thanks for playing! Goodbye.");
        break;
    }
} while (agreePlayAgain = true);

// How can loops help us calculate a total?

// For loops are ideal for calculating totals as they contain a variable that sets the condition for how many times the loop is executed, a "counter" to keep track of how many
// times the loop has run, and has the ability to manipulate an integer each time the loop is executed. This can be used for addition/subtraction/multiplcation, etc.



