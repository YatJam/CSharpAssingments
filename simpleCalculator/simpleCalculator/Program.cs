Console.WriteLine("Well hello there...");
Console.WriteLine("Please input the first number");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Please input the second number");
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Select which operation to perform:");
Console.WriteLine("[A]dd the two numbers together");
Console.WriteLine("[S]ubtract the two numbers against eachother");
Console.WriteLine("[M]ultiply the two numbers together");
string operationInput = Console.ReadLine();

string calculatorOutput(string opertationInput)
{
    if (operationInput == "A" || operationInput == "a")
    {
        int result = firstNumber + secondNumber;
        return (firstNumber + " + " + secondNumber + " = " + result);
    }
    else if (operationInput == "S" || operationInput == "s")
    {
        int result = firstNumber - secondNumber;
        return (firstNumber + " - " + secondNumber + " = " + result);
        }
    else if (operationInput == "M" || operationInput == "m")
    {
        int result = firstNumber * secondNumber;
        return (firstNumber + " * " + secondNumber + " = " + result);
        }
    else
        return ("Invalid option selected");
}

Console.WriteLine(calculatorOutput(operationInput));

Console.WriteLine("Press any key to end programme");
Console.ReadKey();