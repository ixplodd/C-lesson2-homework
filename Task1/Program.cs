System.Console.WriteLine("Enter number");
string? strnumber = Console.ReadLine();
int number = Convert.ToInt32(strnumber);

int numberA = number / 10;
int numberB = numberA %10;
System.Console.WriteLine(numberB);