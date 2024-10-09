// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information

/*Console.WriteLine("Hi .Net Fundamental!");
            Console.WriteLine("Name:");
            string? Name=Console.ReadLine();
            Console.WriteLine("Last Name:");
            string? LastName= Console.ReadLine();
            Console.WriteLine("Age:");
            string? Age = Console.ReadLine();
            Console.WriteLine("Phone Number:");
            string? PhoneNumber= Console.ReadLine();
            Console.WriteLine(Name+" "+LastName+"/"+Age+" "+"years old"+"/"+"call:"+PhoneNumber);*/

Console.WriteLine("Hi .Net Fundamental!");
Console.WriteLine("Age:");
string? Age = Console.ReadLine();
int Ageint = int.Parse(Age);
if (Ageint > 15 && Ageint < 120)
{
    Console.WriteLine("You are valid, so please keep on to complete form.");
    Console.WriteLine("Name:");
    string? Name = Console.ReadLine();
    Console.WriteLine("Last Name:");
    string? LastName = Console.ReadLine();
    Console.WriteLine("Phone Number:");
    string? PhoneNumber = Console.ReadLine();
    if (PhoneNumber.Length == 11)
    {
        Console.WriteLine(Name + " " + LastName + "/" + Age + " " + "years old" + "/" + "call:" + PhoneNumber);
    }
    else
    {
        Console.WriteLine("Your Phone Number is not valid,please try again.");
    }

}
else
{
    Console.WriteLine("Sorry!You are not valid.");

}
