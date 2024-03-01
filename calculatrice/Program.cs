
double nbr1, nbr2;
string operateur;

Console.WriteLine("Veuillez entrer un premier nombre : ");
nbr1 = double.Parse(Console.ReadLine());

Console.WriteLine("Veuillez entrer un operateur (+,-,*,/) : ");
operateur = Console.ReadLine();

Console.WriteLine("Veuillez entrer un second nombre : ");
nbr2 = double.Parse(Console.ReadLine());

switch (operateur)
{
    case "+":
        Console.WriteLine($"{nbr1} {operateur} {nbr2} = {nbr1 + nbr2}");
        break;
    case "-":
        Console.WriteLine($"{nbr1} {operateur} {nbr2} = {nbr1 - nbr2}");
        break;
    case "*":
        Console.WriteLine($"{nbr1} {operateur} {nbr2} = {nbr1 * nbr2}");
        break;
    case "/":
        if (nbr2 != 0)
        {
            Console.WriteLine($"{nbr1} {operateur} {nbr2} = {nbr1 / nbr2}");
        }
        else
        {
            Console.WriteLine("Division par zero impossible");
        }
        break;
    default:
        Console.WriteLine("Operateur invalide !");
        break;
}

