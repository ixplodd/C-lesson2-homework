System.Console.WriteLine("Enter number");
string strnumber = Console.ReadLine();
int number = Convert.ToInt32(strnumber);
int i = 1000;


if (number < 100)
{
    System.Console.WriteLine("There is no third number");
}

else if (number <= 1000)
{
    int number1 = number % 10;
    System.Console.WriteLine(number1);
}

else if ( number <= 10000)
{
    int number2 = number / 10;
    int number3 = number2 % 10;
    System.Console.WriteLine(number3);
}
else if ( number <= 100000)
{
    int number4 = number / 100;
    int number5 = number4 % 10;
    System.Console.WriteLine(number5);
}