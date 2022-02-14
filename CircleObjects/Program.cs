using CircleObjects;

Console.WriteLine("Welcome to the Circle Builder");

List<Circle> allCircles = new List<Circle>(); //can make a list of your custom class
bool looping = true;
while (looping)
{
    double input = GetUserRadius();//put validator in a method

    Circle newCircle = new Circle(input);

    string circumference = newCircle.CalculateFormattedCircumference();
    string area = newCircle.CalculateFormattedArea();

    Console.WriteLine($"Circumference: {circumference}");
    Console.WriteLine($"Area: {area}");
    allCircles.Add(newCircle);

    looping = GetContinue();
    Console.WriteLine();
}

//goodbye message
Console.WriteLine($"You have created {allCircles.Count} circles. Goodbye");

//METHODS

//get continue 
static bool GetContinue()
{
    bool result = true;

    while (true)
    {
        Console.Write("Continue? (y/n): ");
        string choice = Console.ReadLine().ToLower().Trim();
        if (choice == "y" || choice == "yes")
        {
            result = true;
            break;
        }
        else if (choice == "n" || choice == "no")
        {

            result = false;
            break;
        }
        else
        {
            Console.WriteLine("Please try again");
        }
    }
    return result;
}

static double GetUserRadius()
{
    double input = 0;
    while (true)
    {
        try
        {
            Console.Write("Enter a radius: ");
            input = double.Parse(Console.ReadLine());
            break;
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
    }
    return input;
}




