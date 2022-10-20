using UserRegistration;

Console.WriteLine("Welcome to User Registration Problem");
Console.WriteLine("Enter 1 for First Name");
Console.WriteLine("Enter 2 for Last Name");
Console.WriteLine("Enter 3 for Email");
Console.WriteLine("Enter 4 for Mobile number");
Console.WriteLine("Enter 5 for PassWord Rule1");
Console.WriteLine("Enter 6 for PassWord Rule2");
Console.WriteLine("Enter 7 for PassWord Rule3");
Console.WriteLine("Enter 8 for PassWord Rule4");


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
        bool PassWord1 = regexPassWordRule1.validateString("abcdefgd");
        Console.WriteLine("{0}", (PassWord1) ? "Valid" : "Invalid");
        break;

    case 6:
        RegexPassWordRule2 regexPassWordRule2 = new RegexPassWordRule2();
        bool PassWord2 = regexPassWordRule2.validateString("ABJHFTDfg");
        Console.WriteLine("{0}", (PassWord2) ? "Valid" : "Invalid");
        break;

    case 7:
        RegexPassWordRule3 regexPassWordRule3 = new RegexPassWordRule3();
        bool PassWord3 = regexPassWordRule3.validateString("ABJHFTDfg67");
        Console.WriteLine("{0}", (PassWord3) ? "Valid" : "Invalid");
        break;

    case 8:
        RegexPassWordRule4 regexPassWordRule4 = new RegexPassWordRule4();
        bool PassWord4 = regexPassWordRule4.validateString("ABJHFTDfg67@@");
        Console.WriteLine("{0}", (PassWord4) ? "Valid" : "Invalid");
        break;
}
