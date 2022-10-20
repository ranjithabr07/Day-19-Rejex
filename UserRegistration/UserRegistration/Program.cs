// See https://aka.ms/new-console-template for more information

using UserRegistration;

Console.WriteLine("Welcome to User Registration Problem");

RegexFirstName firstName = new RegexFirstName();

if (firstName.validateString("Ranjitha"))

{
    Console.WriteLine("The Name is Valid");

}
else
{
    Console.WriteLine("The Name is InValid");
}