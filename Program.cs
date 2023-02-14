// start main
int userChoice = GetUserChoice(); // priming read
while(userChoice != 3)
{
    RouteEm(userChoice);
    userChoice = GetUserChoice(); // update read
}

// end main 

static int GetUserChoice()
{
    DisplayMenu();
    string userChoice = Console.ReadLine();
    if(IsValidChoice(userChoice))
    {
        return int.Parse(userChoice);
    }
    else return 0;
    
}

static void DisplayMenu()
{
    System.Console.WriteLine("Enter 1 to display full triangle \nEnter 2 to display partial triangle \nEnter 3 to exit");
}

static bool IsValidChoice(string userInput)
{
    if(userInput == "1" || userInput == "2" || userInput == "3")
    {
        return true;
    }
    else return false;
}
static void RouteEm(int menuChoice)
{
    if(menuChoice == 1)
    {
        GetFull();
    }
    else if(menuChoice == 2)
    {
        GetPartial();
    }
    else if(menuChoice != 3)
    {
        SayInvalid();
    }
}
static void SayInvalid()
{
    System.Console.WriteLine("Invalid");

}

static void GetFull()
{
    Random rand = new Random();
    int number = rand.Next(3,10);
    for(int i = 0; i < number ;i++)
    {
        System.Console.WriteLine("");
        for(int j = 0; j < i ;j++)
        {
            System.Console.Write("*");
        }
    }
    System.Console.WriteLine();
}

static void GetPartial()
{
    Random rand = new Random();
    int number = rand.Next(3,10);
    for(int i = 0; i < number ;i++)
    {
        System.Console.WriteLine("");
        for(int j = 0; j < i ;j++)
        {
            if(rand.Next(2) == 1) System.Console.Write("*");
        }
    }
    System.Console.WriteLine();
}