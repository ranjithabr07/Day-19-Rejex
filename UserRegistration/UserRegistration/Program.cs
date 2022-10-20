using UserRegistration;

Console.WriteLine("Welcome to User Registration Problem");
Console.WriteLine("Enter 1 for First Name");
Console.WriteLine("Enter 2 for Last Name");
Console.WriteLine("Enter 3 for Email");
Console.WriteLine("Enter 4 for Mobile number");
Console.WriteLine("Enter 5 for PassWord Rule1");

int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{
    case 1:
        RegexFirstName firstName = new RegexFirstName();
        bool ValidName = firstName.validateString("Ranju");
        Console.WriteLine("{0}", (ValidName) ? "Valid" : "Invalid");
        break;

    case 2:
        RegexLastName lastName = new RegexLastName();
        bool ValidName2 = lastName.validateString("Rajappa");
        Console.WriteLine("{0}", (ValidName2) ? "Valid" : "Invalid");
        break;

    case 3:
        RegexEmail Email = new RegexEmail();
        bool Email1 = Email.validateString("abc.xyz@bl.co.in");
        Console.WriteLine("{0}", (Email1) ? "Valid" : "Invalid");
        break;

    case 4:
        RegexMobileNumber regexMobileNumber = new RegexMobileNumber();
        bool Number1 = regexMobileNumber.validateString("91 9919819801");
        Console.WriteLine("{0}", (Number1) ? "Valid" : "Invalid");
        break;

    case 5:
        RegexPassWordRule1 regexPassWordRule1 = new RegexPassWordRule1();
        bool PassWord1 = regexPassWordRule1.validateString("abcdefg1d");
        Console.WriteLine("{0}", (PassWord1) ? "Valid" : "Invalid");
        break;
}
