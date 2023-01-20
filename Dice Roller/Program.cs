using System.Runtime.CompilerServices;

Console.WriteLine("Welcome to Grand Circus Casino");
int input;

bool restart = true;


while (restart == true)
{
    for (int i = 1; i < 3; i++)
    {
        Console.WriteLine($"Roll {i} "); //counts the number of rolls, adds one every new turn

        Console.WriteLine("How many sides should each die have?"); //requests user input  
        while (int.TryParse(Console.ReadLine(), out input) == false) //converts ui to invalid value          
        {
            Console.WriteLine("Please use a valid choice");
        }
        if (input > 6 || input <= 1)
        {
            Console.WriteLine("We can not accomodate. Please choose a number 2-6. "); //blocks invalid dice options
        }
        else if (input <= 6 || input >= 2)
        {
            int Random1 = GetRandom(input);
            int Random2 = GetRandom(input);
            Console.WriteLine(Random1);
            Console.WriteLine(Random2);
            Console.WriteLine(sixSides(Random1, Random2));
        }

        Console.WriteLine("Would you like to roll again?");
        string response = Console.ReadLine().ToLower().Trim();
        if (response == "y" || response == "yes")
        {
            restart = true;
        }
        else if (response == "n" || response == "no")
        {
            restart = false;
            Console.WriteLine("Good Game!");           
        }
        else
        {
            break;
        }
    }
    

    static int GetRandom(int max)
    {
        Random r = new Random();
        return r.Next(1, max + 1);
    }
    Console.WriteLine(GetRandom(6));  //sets maximum range to 6

    static string sixSides(int x, int y)
    {
        if (x == 1 && y == 1)
        {
            return "Snake Eyes!";  //static uses return
        }
        else if (x == 1 && y == 2)
        {
            return "Ace Deuce!";
        }
        else if (x == 6 && y == 6)
        {
            return "Box Cars!";
        }
        else if (x + y == 7 || x + y == 11)
        {
            return "Winner!!";
        }
        else if (x + y == 2 || x + y == 3 || x + y == 12)
        {
            return "Craps!";
        }
        else
        {
            return " ";
        }
    }
    Console.WriteLine(sixSides(2, 1));

    static string DiceOutput(int x, int y)
    {
        return $"({x + y} total)";
    }
    Console.WriteLine(DiceOutput(1, 2));
}