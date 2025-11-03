// See https://aka.ms/new-console-template for more information
Console.WriteLine("====Assignemnt 01====");
Console.WriteLine("Enter your name:");
string name = Console.ReadLine();
Console.WriteLine("Enter your gender:");
string gender = Console.ReadLine();
Console.WriteLine("Enter your age:");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("Enter your phone number:");
int phoneNumber = int.Parse(Console.ReadLine());
Console.WriteLine($"Hello, {name}! You are a {age}-year-old {gender} with phone number {phoneNumber}.");

Console.WriteLine("====Assignemnt 02====");
double spentAmount = 35 * 3 + 120 * 2;
Console.WriteLine($"Total amount spent: ${spentAmount}");

Console.WriteLine("====Assignemnt 03====");
void A03()
{
    Console.WriteLine("Input days");
    int days = int.Parse(Console.ReadLine());
    int weeks = days / 7;
    int remainingDays = days % 7;
    Console.WriteLine($"{days} days are {weeks} weeks and {remainingDays} days.");
}
A03();

Console.WriteLine("====Assignemnt 04====");
void A04()
{
    int secondNumber = 107653;
    int days = secondNumber / (24 * 60 * 60);
    secondNumber %= (24 * 60 * 60);
    int hours = secondNumber / (60 * 60);
    secondNumber %= (60 * 60);
    int minutes = secondNumber / 60;
    int seconds = secondNumber % 60;
    Console.WriteLine($"107653 seconds are {days} days, {hours} hours, {minutes} minutes, and {seconds} seconds.");
}
A04();

Console.WriteLine("====Assignemnt 05====");
void A05()
{
    Console.WriteLine("Input user name:");
    string userName = Console.ReadLine();
    Console.WriteLine("Input password:");
    string password = Console.ReadLine();
    if (userName == "admin" && password == "88888")
    {
        Console.WriteLine("Access granted.");
    }
    else
    {
        if (userName != "admin")
        {
            Console.WriteLine("Invalid user name.");
        }
        else
        {
            Console.WriteLine("Invalid password.");
        }
    }
}
A05();

Console.WriteLine("====Assignemnt 06====");
void A06()
{
    double salary = 5000;
    Console.WriteLine("Input grade (A, B, C, D, E):");
    string grade = Console.ReadLine();
    switch (grade)
    {
        case "A":
            salary += 500;
            break;
        case "B":
            salary += 200;
            break;
        case "C":
            salary += 0;
            break;
        case "D":
            salary -= 200;
            break;
        case "E":
            salary -= 500;
            break;
        default:
            Console.WriteLine("Invalid grade.");
            return;
    }
    Console.WriteLine($"Final salary: ${salary}");
}
A06();

Console.WriteLine("====Assignemnt 07====");
void A07()
{
    Console.WriteLine("Input year:");
    int year = int.Parse(Console.ReadLine());
    Console.WriteLine("Input month:");
    int month = int.Parse(Console.ReadLine());
    int daysInMonth;
    switch (month)
    {
        case 1:
        case 3:
        case 5:
        case 7:
        case 8:
        case 10:
        case 12:
            daysInMonth = 31;
            break;
        case 4:
        case 6:
        case 9:
        case 11:
            daysInMonth = 30;
            break;
        case 2:
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                daysInMonth = 29;
            }
            else
            {
                daysInMonth = 28;
            }
            break;
        default:
            Console.WriteLine("Invalid month.");
            return;
    }
}
A07();

Console.ReadLine();