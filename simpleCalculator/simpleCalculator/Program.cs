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



    if (checkCaseSensitive(operationInput, "A"))
    {
        int result = firstNumber + secondNumber;
        printEquation(firstNumber, secondNumber, result, "+");
    }
    else if (checkCaseSensitive(operationInput, "S"))
    {
        int result = firstNumber - secondNumber;
        printEquation(firstNumber, secondNumber, result, "-");
    }
    else if (checkCaseSensitive(operationInput, "M"))
    {
        int result = firstNumber * secondNumber;
        printEquation(firstNumber, secondNumber, result, "*");
        }
    else
        Console.WriteLine("'" + operationInput + "' is an invalid input");


Console.WriteLine("Press any key to end programme");
Console.ReadKey();

void printEquation(int number1, int number2, int result, string @operator)
{
    Console.WriteLine(
        number1 + " " + @operator + " " + number2 + " = " + result);
}

bool checkCaseSensitive (string inputChar, string compareChar)
{
    return inputChar.ToUpper() == compareChar.ToUpper();
}