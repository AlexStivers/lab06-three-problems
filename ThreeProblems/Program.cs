/*
* Name: Alex Stivers
* Course: CSCI 1250, Section 001
* Assignment: Lab 06, Three Short Problems
* Date: October 21, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/
//Writing Menu
const int MENU_OPTIONS = 5;

Console.WriteLine("=== CSCI 1250 Lab 06 ===");
Console.WriteLine("1. The Grade Checker");
Console.WriteLine("2. The Dice Table");
Console.WriteLine("3. The Score Report");
Console.WriteLine("4. All three");
Console.WriteLine("5. Quit");

int choice = 0;

// Adding Choices for Menu
while (choice < 1 || choice > MENU_OPTIONS)
{
    Console.Write("Choose 1 through 5: ");
    choice = Convert.ToInt32(Console.ReadLine());

    if (choice < 1 || choice > MENU_OPTIONS)
    {
        Console.WriteLine("Choose a number from 1 to 5.");
    
    }
}

//The Grade Checker
if (choice == 1 || choice == 4)
{
    Console.WriteLine("\n===Exercise 1: The Grade Checker ===");
    int score = -1;

    while (score < 0 || score > 100)
    {
        Console.Write("Score: ");
        score = Convert.ToInt32(Console.ReadLine());

        if (score < 0 || score > 100)
        {
            Console.WriteLine("A score must be between 0 and 100");
        }
    }
    
    if (score >= 90)
    {
        Console.WriteLine($"{score} earns an A.");
    }

    else if (score >= 80)
    {
        Console.WriteLine($"{score} earns a B.");
    }

    else if (score >= 70)
    {
        Console.WriteLine($"{score} earns a C.");
    }

    else if (score >= 60)
    {
        Console.WriteLine($"{score} earns a D.");
    }

    else
    {
        Console.WriteLine($"{score} earns an F.");
    }
}
