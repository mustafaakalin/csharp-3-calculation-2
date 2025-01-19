// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// // random number generator
// Random random = new Random();
// int randomNumber = random.Next(1, 100);

// // user input
// int userGuess = 0;

// // number of guesses
// int numberOfGuesses = 0;

// // game loop

// while (userGuess != randomNumber)
// {
//     Console.WriteLine("Guess a number between 1 and 100: ");
//     userGuess = Convert.ToInt32(Console.ReadLine());
//     numberOfGuesses++;

//     if (userGuess < randomNumber)
//     {
//         Console.WriteLine("Too low! Try again.");
//     }
//     else if (userGuess > randomNumber)
//     {
//         Console.WriteLine("Too high! Try again.");
//     }
//     else
//     {
//         Console.WriteLine($"You guessed it! The number was {randomNumber}.");
//         Console.WriteLine($"It took you {numberOfGuesses} guesses.");
//     }
// }


Random rastgelesayi = new Random();
for (int i = 0; i < 5; i++)
{
    int sayi = rastgelesayi.Next(10, 50);
    Console.WriteLine(sayi);
}