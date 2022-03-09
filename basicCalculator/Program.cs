double num1 = 0;
double num2 = 0;

Console.WriteLine("console calculator\r");
Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - \n");


Console.WriteLine("Type a number, and then press enter");
num1 = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Type another number, and then press enter");
num2 = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Choose an option from the following list");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.WriteLine("Your Option?");

switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"your result: {num1} + {num2} = " +(num1 + num2));
        break;
    case "b":
        Console.WriteLine($"your result: {num1} - {num2} = " + (num1 - num2));
        break;
    case "c":
        Console.WriteLine($"your result: {num1} * {num2} = " + (num1 * num2));
        break;
    case "d":
        Console.WriteLine($"your result: {num1} / {num2} = " + (num1 / num2));
        break;
}
