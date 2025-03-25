string carger;
bool name = false;

Console.WriteLine( "Enter your role name (Administrador, Manager, or User)");

do{
    carger = Console.ReadLine().Trim().ToLower();

    if (carger == "administrator" || carger == "manager" || carger == "user")
    {
        name = true;
    }
    else
    {
        Console.WriteLine($"The role name \"{carger}\" is not valid. Enter your role name (Administrator, Manager, or User):");
    }
} while (!name);

Console.WriteLine( $"Your input ({carger}) has been accepted");


