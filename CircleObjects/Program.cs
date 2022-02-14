using CircleObjects;

Console.WriteLine("Welcome to the Circle Builder");

bool looping = true;
while (looping)
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

    Circle newCircle = new Circle(input);

    string circumference = newCircle.CalculateFormattedCircumference();
    string area = newCircle.CalculateFormattedArea();

    Console.WriteLine($"Circumference: {circumference}");
    Console.WriteLine($"Area: {area}");

    while (true)
    {
        Console.Write("Continue? (y/n): ");
        string loopchoice = Console.ReadLine().ToLower().Trim();
        Console.WriteLine();

        if (loopchoice == "y" || loopchoice == "yes")
        {
            looping = true;
            break;
        }
        else if (loopchoice == "n" || loopchoice == "no")
        {

            looping = false;
            Console.WriteLine("Have fun being square, because you're no longer a-round!");
            break;
        }
        else
        {
            Console.WriteLine("Please try again");
        }
    }
}




