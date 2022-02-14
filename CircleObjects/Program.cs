using CircleObjects;

Console.WriteLine("Welcome to the Circle Builder");

List<Circle> allCircles = new List<Circle>(); //can make a list of your custom class
bool looping = true;
while (looping)
{
    double input = Validator.GetUserRadius();//put validator in a method

    Circle newCircle = new Circle(input);

    string circumference = newCircle.CalculateFormattedCircumference();
    string area = newCircle.CalculateFormattedArea();

    Console.WriteLine($"Circumference: {circumference}");
    Console.WriteLine($"Area: {area}");
    allCircles.Add(newCircle);

    looping = Validator.GetContinue();
    Console.WriteLine();
}

//goodbye message
Console.WriteLine($"You have created {allCircles.Count} circles. Goodbye");

//loop METHODS in validator class






