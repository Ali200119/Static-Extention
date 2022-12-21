using AtHome.Helpers;

#region Task 1

Console.WriteLine("Please enter the number whose factorial you want to find:");
Number: string checkNumber = Console.ReadLine();
int num;
bool isNumber = int.TryParse(checkNumber, out num);

if (!isNumber)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Please enter the number:");
    Console.ResetColor();
    goto Number;
}

Console.WriteLine(num.Factorial());

#endregion