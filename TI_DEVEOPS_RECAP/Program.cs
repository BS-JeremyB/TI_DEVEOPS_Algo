
#region Intro
//// TYPE

//// EN PSEUDO CODE : CHAINE, BOOLEAN, ENTIER, REEL
//// VARIABLE nomVar : Type

//// En C# : string, bool, int, double
//// type nomVar;


//string message; // Declaration
//int nombre = 42; // Declaration + initialisation
//double nombreDouble1 = 1.2, nombreDouble2 = 3.14, nombreDouble3;


//message = "Bonjour à tous"; // Affectation


//// Lecture en pseudo Code :  Lire(nomVar)
//// Lecture en C# : string nomVar = Console.ReadLine()

//// Ecriture en Pseudo Code : Ecrire("Notre texte")
//// Ecriture en C# : Console.WriteLine("Notre texte")

//Console.WriteLine("Entrer un message à afficher : ");
//string nouveauMessage = Console.ReadLine();

//Console.WriteLine(nouveauMessage);

// OPERATEUR ARITHMETIQUE EN Pseudo Code = à ceux en C#
// +,-,/,*,% 
// Mais aussi les OPERATEURS LOGIQUES
// &&, ||, !
// Tout comme les OPERATEURS DE COMPARAISON 
// <, <=, >, >=, ==, !=


// CONCATENATION en Pseudo code : +
// CONCATENATION en C# : +
// MAIS en C# il est possible d'utiliser d'autres méthodes, ex :

//string nom = "Doe", prenom = "John";

//Console.WriteLine("Bonjour je suis " + prenom + " "+ nom);
//Console.WriteLine($"Bonjour je suis {prenom} {nom}");


#endregion

#region EXO Permutation

//int a = 5;
//int b = 7;


//int temp = a;
//a = b;
//b = temp;
//Console.ReadLine();


#endregion

#region EXO convertisseur

//int jour, heure, minute, seconde;

//Console.WriteLine("Veuillez entrer un nombre de secondes");
//seconde = int.Parse(Console.ReadLine());

//jour = seconde / 86400;
//heure = (seconde % 86400) / 3600;
//minute = (seconde % 3600) / 60;
//seconde = (seconde % 60);

//Console.WriteLine($"{jour} jour(s) , {heure} heure(s), {minute} minute(s), {seconde} seconde(s)");


#endregion

#region Recap Les conditions

//bool test = 10 > 20 || 10 > 5;
//Console.WriteLine(test);
//test = 10 > 20 && 10 > 5;
//Console.WriteLine(test);
//test = !(10 > 20 && 10 > 5);
//Console.WriteLine(test);

//if (contion)
//{
//    instruction
//}
//else
//{
//    instruction
//}

//// SELON QUE en pseudo code  = SWITCH CASE en c#

//string choix;

//Console.WriteLine($"Veuillez selectionner un fruit : \n" +
//                  $"1. kiwi\n" +
//                  $"2. Oranges\n" +
//                  $"3. pomme\n" +
//                  $"4. Grenade");

//choix = Console.ReadLine();
//switch (choix)
//{
//    case "3":
//        Console.WriteLine("Le prix au kg est de 2€");
//        break;
//    case "2":
//        Console.WriteLine("Le prix au kg est de 2,20€");
//        break;
//    case "1":
//    case "4":
//        Console.WriteLine("Le prix au kg est de 3,20€");
//        break;
//    default:
//        Console.WriteLine("choix invalide");
//            break;
//}







#endregion

#region EXO Bissextile


//Console.WriteLine("Veuillez entrer une année : ");
//int annee = int.Parse(Console.ReadLine());

//if(annee % 4 == 0 && annee % 100 != 0 || annee % 400 == 0)
//{
//    Console.WriteLine("l'année " + annee + " est bissextile");
//}
//else
//{
//    Console.WriteLine("l'année " + annee + " n'est pas bissextile");
//}

#endregion

#region Exo Calculatrice

//double nbr1, nbr2;
//string operateur;

//Console.WriteLine("Veuillez entrer un premier nombre : ");
//nbr1 = double.Parse(Console.ReadLine());

//Console.WriteLine("Veuillez entrer un operateur (+,-,*,/) : ");
//operateur = Console.ReadLine();

//Console.WriteLine("Veuillez entrer un second nombre : ");
//nbr2 = double.Parse(Console.ReadLine());

//switch (operateur)
//{
//    case "+":
//        Console.WriteLine($"{nbr1} {operateur} {nbr2} = {nbr1 + nbr2}");
//        break;
//    case "-":
//        Console.WriteLine($"{nbr1} {operateur} {nbr2} = {nbr1 - nbr2}");
//        break;
//    case "*":
//        Console.WriteLine($"{nbr1} {operateur} {nbr2} = {nbr1 * nbr2}");
//        break;
//    case "/":
//        if(nbr2 != 0)
//        {
//            Console.WriteLine($"{nbr1} {operateur} {nbr2} = {nbr1 / nbr2}");
//        }
//        else 
//        {
//            Console.WriteLine("Division par zero impossible");
//        }
//        break;
//    default:
//        Console.WriteLine("Operateur invalide !");
//        break;
//}

#endregion

#region Exo Convertisseur Diff

//int jour, heure, minute, seconde;

//Console.WriteLine("Veuillez entrer une durée en jour : ");
//jour = int.Parse(Console.ReadLine());

//Console.WriteLine("Veuillez entrer une durée en heure : ");
//heure = int.Parse(Console.ReadLine());

//Console.WriteLine("Veuillez entrer une durée en minute : ");
//minute = int.Parse(Console.ReadLine());

//Console.WriteLine("Veuillez entrer une durée en seconde : ");
//seconde = int.Parse(Console.ReadLine());

//int temps1 = (jour * 86400) + (heure * 3600) + (minute * 60) + seconde;


//Console.WriteLine("Veuillez entrer une nouvelle durée en jour : ");
//jour = int.Parse(Console.ReadLine());

//Console.WriteLine("Veuillez entrer une nouvelle durée en heure : ");
//heure = int.Parse(Console.ReadLine());

//Console.WriteLine("Veuillez entrer une nouvelle durée en minute : ");
//minute = int.Parse(Console.ReadLine());

//Console.WriteLine("Veuillez entrer une nouvelle durée en seconde : ");
//seconde = int.Parse(Console.ReadLine());

//int temps2 = (jour * 86400) + (heure * 3600) + (minute * 60) + seconde;

//if(temps1 > temps2)
//{
//    seconde = temps1 - temps2;
//}
//else
//{
//    seconde = temps2 - temps1;
//}

//jour = seconde / 86400;
//heure = (seconde % 86400) / 3600;
//minute = (seconde % 3600) / 60;
//seconde = (seconde % 60);

//Console.WriteLine($"La difference est de {jour} jour(s) , {heure} heure(s), {minute} minute(s), {seconde} seconde(s)");


#endregion

#region Boucle While
//Console.WriteLine("Veuillez entrer un nombre : ");
//int nbr = int.Parse(Console.ReadLine());


//while( nbr != 32)
//{
//    Console.WriteLine("Le nombre n'a pas été trouvé, veuillez recommencer : ");
//    nbr = int.Parse(Console.ReadLine());
//}



//int compteur = 10;

//while (compteur > 0)
//{

//    Console.WriteLine(compteur);
//    compteur = compteur - 1;

//}
#endregion

#region Exo Table Bonus
//using System.Text.RegularExpressions;
//bool isMatched;


//do
//{
//    isMatched = true;
//    Console.WriteLine("Veuillez entrer les tables séparées par une virgule :");
//    string tableString = Console.ReadLine();
//    string pattern = @"^(?:[1-9]|10)(?:,(?:[1-9]|10))*$";


//    if (Regex.IsMatch(tableString, pattern))
//    {
//        string[] tableList = tableString.Split(",");

//        foreach (string table in tableList)
//        {
//            Console.WriteLine();
//            Console.WriteLine($"#### TABLE DE {table} ####");
//            Console.WriteLine();
//            for (int i = 1; i <= 10; i++)
//            {
//                Console.WriteLine($"{i} * {table} = {i * int.Parse(table)}");
//            }
//        }
//    }
//    else
//    {
//        Console.WriteLine("entrée incorrect");
//        isMatched = false;
//    }

//}while (!isMatched);
#endregion

#region Exo table de 2

//int compteur = 1;

//while(compteur <= 10)
//{
//    Console.WriteLine($"{compteur} * 2 = {compteur * 2}");
//    compteur = compteur + 1;

//}




#endregion

#region Exo table 1 - 9
//int table = 1, compteur = 1;

//while(table <= 9)
//{

//    Console.WriteLine();
//    Console.WriteLine($"#### TABLE DE {table} ####");
//    Console.WriteLine();
//    while (compteur <= 10)
//    {
//        Console.WriteLine($"{compteur} * {table} = {compteur * table}");
//        compteur = compteur + 1;
//    }

//    table = table + 1;
//    compteur = 1;
//}

#endregion

#region Exo Plus ou Moins
//Random rnd = new Random();

//int nbrMystere  = rnd.Next(100) +1;

//Console.WriteLine("Veuillez entrer un nombre entre 1 & 100");
//int nbrEssaye = int.Parse(Console.ReadLine());


//while (nbrEssaye != nbrMystere)
//{

//    if( nbrMystere > nbrEssaye)
//    {
//        Console.WriteLine("Le nombre mystère est plus grand");
//    }
//    else
//    {
//        Console.WriteLine("Le nombre mystère est plus petit");
//    }
//    Console.WriteLine("Veuillez entrer un autre nombre entre 1 & 100");
//    nbrEssaye = int.Parse(Console.ReadLine());
//}

//Console.WriteLine("Bravo le nombre mystère était bien " + nbrMystere);


#endregion

//Random rnd = new Random();

//int nbrMystere = rnd.Next(100) + 1;
//int nbrEssaye;

//do
//{
//    Console.WriteLine("Veuillez entrer un nombre entre 1 & 100");
//    nbrEssaye = int.Parse(Console.ReadLine());


//    if (nbrMystere > nbrEssaye)
//    {
//        Console.WriteLine("Le nombre mystère est plus grand");
//    }
//    else if (nbrMystere < nbrEssaye)
//    {
//        Console.WriteLine("Le nombre mystère est plus petit");
//    }
//    else
//    {
//        Console.WriteLine("Bravo le nombre mystère était bien " + nbrMystere);
//    }

//} while (nbrEssaye == nbrMystere);

#region Exo Distributeur


//int stockCoca = 3, stockFanta = 1, stockSprite = 6, stockOasis = 0;
//string choix;


//do
//{
//    Console.WriteLine("Veuillez faire votre selection : \n" +
//                      "1. Coca-Cola \n" +
//                      "2. Fanta \n" +
//                      "3. Sprite \n" +
//                      "4. Oasis \n" +
//                      "0. Quitter");
//    choix = Console.ReadLine();


//    switch (choix)
//    {
//        case "1":
//            if(stockCoca > 0)
//            {
//                Console.WriteLine("Voici votre canette de Coca-Cola");
//                stockCoca = stockCoca - 1;
//            }
//            else
//            {
//                Console.WriteLine("Sold Out");
//            }
//            break;
//        case "2":
//            if (stockFanta > 0)
//            {
//                Console.WriteLine("Voici votre canette de Fanta");
//                stockFanta = stockFanta - 1;
//            }
//            else
//            {
//                Console.WriteLine("Sold Out");
//            }
//            break;
//        case "3":
//            if (stockSprite > 0)
//            {
//                Console.WriteLine("Voici votre canette de Sprite");
//                stockSprite = stockSprite - 1;
//            }
//            else
//            {
//                Console.WriteLine("Sold Out");
//            }
//            break;
//        case "4":
//            if (stockOasis > 0)
//            {
//                Console.WriteLine("Voici votre canette de Oasis");
//                stockOasis = stockOasis - 1;
//            }
//            else
//            {
//                Console.WriteLine("Sold Out");
//            }
//            break;
//        case "0":
//            Console.WriteLine("Bonne journée");
//            break;
//        default: 
//            Console.WriteLine("Choix invalide");
//            break;
//    }


//} while (choix != "0");





//int stockCoca = 3, stockFanta = 1, stockSprite = 6, stockOasis = 0;
//string choix;


//do
//{
//    Console.WriteLine("Veuillez faire votre selection : \n" +
//                      "1. Coca-Cola \n" +
//                      "2. Fanta \n" +
//                      "3. Sprite \n" +
//                      "4. Oasis ");
//    choix = Console.ReadLine();


//    switch (choix)
//    {
//        case "1":
//            if (stockCoca > 0)
//            {
//                Console.WriteLine("Voici votre canette de Coca-Cola");
//                stockCoca = stockCoca - 1;
//            }
//            else
//            {
//                Console.WriteLine("Sold Out");
//            }
//            break;
//        case "2":
//            if (stockFanta > 0)
//            {
//                Console.WriteLine("Voici votre canette de Fanta");
//                stockFanta = stockFanta - 1;
//            }
//            else
//            {
//                Console.WriteLine("Sold Out");
//            }
//            break;
//        case "3":
//            if (stockSprite > 0)
//            {
//                Console.WriteLine("Voici votre canette de Sprite");
//                stockSprite = stockSprite - 1;
//            }
//            else
//            {
//                Console.WriteLine("Sold Out");
//            }
//            break;
//        case "4":
//            if (stockOasis > 0)
//            {
//                Console.WriteLine("Voici votre canette de Oasis");
//                stockOasis = stockOasis - 1;
//            }
//            else
//            {
//                Console.WriteLine("Sold Out");
//            }
//            break;
//        default:
//            Console.WriteLine("Choix invalide");
//            break;
//    }

//        choix = "oui";
//    do
//    {
//        if(choix != "oui" && choix != "non")
//        {
//            Console.WriteLine("Attention, le choix doit être 'oui' ou 'non'");
//        }
//        Console.WriteLine("Voulez-vous une autre boisson ? oui - non");
//        choix = Console.ReadLine();
//    } while (choix != "oui" && choix != "non");

//    Console.Clear();
//} while (choix == "oui" );





#endregion

#region Exo Calculatrice Boucle


//double nbr1, nbr2;
//string operateur, choix;

//do
//{

//    Console.WriteLine("Veuillez entrer un premier nombre : ");
//    nbr1 = double.Parse(Console.ReadLine());

//    Console.WriteLine("Veuillez entrer un operateur (+,-,*,/) : ");
//    operateur = Console.ReadLine();

//    Console.WriteLine("Veuillez entrer un second nombre : ");
//    nbr2 = double.Parse(Console.ReadLine());

//    switch (operateur)
//    {
//        case "+":
//            Console.WriteLine($"{nbr1} {operateur} {nbr2} = {nbr1 + nbr2}");
//            break;
//        case "-":
//            Console.WriteLine($"{nbr1} {operateur} {nbr2} = {nbr1 - nbr2}");
//            break;
//        case "*":
//            Console.WriteLine($"{nbr1} {operateur} {nbr2} = {nbr1 * nbr2}");
//            break;
//        case "/":
//            if (nbr2 != 0)
//            {
//                Console.WriteLine($"{nbr1} {operateur} {nbr2} = {nbr1 / nbr2}");
//            }
//            else
//            {
//                Console.WriteLine("Division par zero impossible");
//            }
//            break;
//        default:
//            Console.WriteLine("Operateur invalide !");
//            break;
//    }

//    choix = "oui";
//    do
//    {
//        if (choix != "oui" && choix != "non")
//        {
//            Console.WriteLine("Attention, le choix doit être 'oui' ou 'non'");
//        }
//        Console.WriteLine("Voulez-vous faire une autre opération ? oui - non");
//        choix = Console.ReadLine();
//    } while (choix != "oui" && choix != "non");


//} while (choix == "oui");



#endregion

#region Exo Exposant Boucle
//int nombre, exposant, resultat, compteur;

//Console.WriteLine("Veuillez entrer un nombre : ");
//nombre = int.Parse(Console.ReadLine());


//Console.WriteLine("Veuillez entrer l'exposant désiré : ");
//exposant = int.Parse(Console.ReadLine());

//compteur = 1;
//resultat = 1;

//Console.Clear();
//Console.WriteLine("###### CALCUL #####");
//while (compteur <= exposant)
//{
//    resultat = resultat * nombre;
//    Console.WriteLine(resultat);
//    compteur = compteur + 1;
//}

#endregion

#region Tableaux
//int[] ints = new int[10];
//Console.WriteLine(ints.Length);


//string[] tableSem = { "lundi", "mardi", "mercredi", "jleudi", "vendredi", "jeudi", "dimanche" };


//Console.WriteLine(tableSem[3]);

//tableSem[3] = tableSem[5];

//Console.WriteLine(tableSem[3]);


//tableSem[5] = "samedi";

//Console.WriteLine(tableSem[5]);



//for(int i = 0; i < tableSem.Length; i++)
//{
//    Console.WriteLine(tableSem[i]);
//}

// VARIABLES tableSem = TABLE[10] de Chaines
#endregion

#region Exo Liste de nombre
//int[] listeNombre = new int[6];


//for(int i = 0; i < listeNombre.Length; i++)
//{
//    Console.WriteLine("Veuillez entrer la valeur N°" + (i + 1));
//    listeNombre[i] = int.Parse(Console.ReadLine());
//}

//Console.WriteLine("---- RESULTAT ----");

//for (int i = 0; i < listeNombre.Length; i++)
//{
//    Console.Write(listeNombre[i] + ", ");
//}
#endregion

#region Exo Bonus Nombre
//listeNombre[0] = 2;
//for (int i = 1; i < listeNombre.Length; i++)
//{
//    listeNombre[i] = listeNombre[i - 1] * 2;
//}

//int[] listeNombre = new int[10];
//int resultat;

//resultat = 2;
//for(int i = 0; i < listeNombre.Length; i++)
//{
//    listeNombre[i] = resultat;
//    resultat = resultat * 2;
//    Console.Write(listeNombre[i] + ", ");
//}
#endregion

#region Exo Moyenne joueurs

//int nbrJoueur;
//double somme = 0;

//do
//{

//    Console.WriteLine("Veuillez entrer le un nombre de joueur (Max 10) :");
//    nbrJoueur = int.Parse(Console.ReadLine());

//} while (nbrJoueur < 1 || nbrJoueur > 10);


//double[] scores = new double[nbrJoueur];


//for (int i = 0;  i < nbrJoueur; i++)
//{
//    Console.WriteLine("Veuillez entrer le score du joueur N° "+ (i+1));
//    scores[i] = double.Parse(Console.ReadLine());

//}

//for (int i = 0;i < nbrJoueur; i++)
//{
//    somme = somme + scores[i];
//}

//Console.WriteLine($"La moyenne des joueurs est de {somme / nbrJoueur:F2}");


#endregion

#region Exo Tableau Miroir

//int[] tab = new int[5];
//int[] tabMiroir = new int[5];


//for (int i = 0; i < tab.Length; i++)
//{
//    Console.WriteLine("Veuillez entrer la valeur N°" +(i+1));
//    tab[i] = int.Parse(Console.ReadLine());
//}

////for (int i = tab.Length - 1; i >= 0; i--)
////{
////    tabMiroir[tab.Length - i - 1] = tab[i];
////}

////for (int i = 0;i < tab.Length; i++)
////{
////    tabMiroir[i] = tab[tab.Length - i - 1];
////}


//for (int i = 0; i < tab.Length / 2; i++)
//{
//    (tab[i], tab[tab.Length - 1 - i]) = (tab[tab.Length - 1 - i], tab[i]);
//}

//for (int i = 0; i < tab.Length ; i++)
//{
//    Console.Write(tab[i] + ", ");
//}


#endregion

#region Exo Tri a bulle
//int[] ints = new int[10];

//Random random = new Random();

//for (int i = 0; i < ints.Length; i++)
//{
//    ints[i] = random.Next(0, 20);
//}

//for (int i = 0; i < ints.Length; i++)
//{
//    Console.Write($"[{ints[i]}]");
//}

//for (int i = 0; i < ints.Length - 1; i++)
//{
//    for (int j = 0; j < ints.Length - 1 - i; j++)
//    {
//        if (ints[j] > ints[j + 1])
//        {
//            (ints[j], ints[j + 1]) = (ints[j + 1], ints[j]);
//        }
//    }
//}

//Console.WriteLine();

//for (int i = 0; i < ints.Length; i++)
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.Write($"[{ints[i]}]");
//    Console.ResetColor();
//}
#endregion

#region Exo Tableau Fusion

//int[] tab = { 31, 2, 2, 16, 4, 10, 14, 19, 0, 42 };
//int[] tab2 = { 42, 2, 0, 13, 3, 15, 8, 0, 20, 9 };
//int[] tabFusion = new int[tab.Length + tab2.Length];
//int indice;


//for (int i = 0; i < tab.Length; i++)
//{
//    indice = 0;
//    for (int j = 0; j < tab.Length; j++)
//    {
//        indice = tab[j] < tab[i] ? indice + 1 : indice;
//        indice = tab2[j] < tab[i] ? indice + 1 : indice;

//    }
//    tabFusion[indice] = tab[i];

//    //Tab 2
//    indice = 0;
//    for (int j = 0; j < tab2.Length; j++)
//    {
//        indice = tab[j] < tab2[i] ? indice + 1 : indice;
//        indice = tab2[j] < tab2[i] ? indice + 1 : indice;

//    }
//    tabFusion[indice] = tab2[i];
//}

//for (int i = 0; i < tabFusion.Length; i++)
//{
//    if (tabFusion[i] == 0 && i != 0)
//    {
//        tabFusion[i] = tabFusion[i - 1];
//    }
//}
//Console.ReadLine();
#endregion

#region Pion
//char[] plateau = new char[10];
//int indice = 0;
//char key;


//for (int i = 0; i < plateau.Length; i++)
//{
//    plateau[i] = '_';
//}
//plateau[indice] = 'P';


//do
//{

//    Console.Write($"|");
//    foreach (char item in plateau)
//    {
//        Console.Write($"{item}|");
//    }

//    Console.WriteLine("\nDeplacez-vous avec G - D ou Q pour Quitter");
//    key = Console.ReadKey().KeyChar;

//    Console.Clear();

//    switch (key)
//    {
//        case 'd':
//            if (indice == plateau.Length - 1)
//            {
//                Console.WriteLine("Impossible d'aller plus loin à droite");
//            }
//            else
//            {
//                (plateau[indice], plateau[indice + 1]) = (plateau[indice + 1], plateau[indice]);
//                indice++;
//            }
//            break;

//        case 'g':
//            if (indice == 0)
//            {
//                Console.WriteLine("Impossible d'aller plus loin à gauche");
//            }
//            else
//            {
//                (plateau[indice], plateau[indice - 1]) = (plateau[indice - 1], plateau[indice]);
//                indice--;
//            }
//            break;
//        case 'q':
//            break;
//        default:
//            Console.WriteLine("Touche invalide !");
//            break;
//    }
//} while (key != 'q');

#endregion

#region Recherche
//int[] tab = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 5 };


//Console.WriteLine("Veuillez entrer la valeur à trouver : ");
//int nbrATrouver = int.Parse(Console.ReadLine());


//for (int i = 0; i < tab.Length; i++)
//{
//    if (tab[i] == nbrATrouver)
//    {
//        Console.WriteLine("Le nombre est à l'indice " + i);
//    }
//}
#endregion

#region PlusPetit


//int[] tab = new int[10];
//Random rnd = new Random();

//for (int i = 0; i < tab.Length; i++)
//{

//    tab[i] = rnd.Next(50)+1;
//}

//int min = tab[0];

//foreach(int item in tab)
//{
//    if(item < min)
//    {
//        min = item;
//    }
//}

//Console.WriteLine("Le minimum est : "+ min );

#endregion

#region Ajouter
//int[] tab = { 1, 2, 3, 5, 6, 7, 8, 9, 10, 0 };
//int position = 0;


//tab[tab.Length - 1] = 0;

//Console.WriteLine("Veuillez entrer le nombre à ajouter");
//int nbrUtilisateur = int.Parse(Console.ReadLine());



//for (int i = 0; i < tab.Length - 1; i++)
//{
//    if (nbrUtilisateur > tab[i])
//    {
//        position++;
//    }
//    else
//    {
//        i = tab.Length;
//    }
//}

//for(int i = tab.Length - 1; i > position; i--)
//{
//    (tab[i], tab[i - 1]) = (tab[i - 1], tab[i]);
//}

//tab[position] = nbrUtilisateur;


//foreach (int i in tab)
//{
//    Console.Write(i + ",");
//}
#endregion

#region supprimer
//int[] tab = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};


//int nbrADelete = 6;

//for(int i = 0; i < tab.Length; i++)
//{
//    if (tab[i] == nbrADelete)
//    {
//        for(int j = i;  j < tab.Length - 1; j++)
//        {
//            (tab[j], tab[j + 1]) = (tab[j + 1], tab[j]);
//        }

//        i = tab.Length;
//    }

//}
//tab[tab.Length -1] = 0;
//foreach (int item in tab)
//{
//    Console.WriteLine(item + ",");
//}
#endregion

#region recap


// Utilisation de variables

// Il faut les typer

//int nombre = 5;
//double nombre2 = 6.86;
//string message = "42";

//nombre = (int)nombre2;

//Console.WriteLine(nombre);


//Console.WriteLine("Veuillez entrer votre age : ");
//int age = int.Parse(Console.ReadLine());

//if(age >= 18 && age < 65)
//{

//    Console.WriteLine("Vous pouvez entrer voir cette personne se faire peter les dents");
//}
//else if(age >= 65)
//{
//    Console.WriteLine("Vous pouvez entrer voir cette personne se faire peter les dents, mais assis");
//}
//else
//{
//    Console.WriteLine("Rentre chez toi, trop jeune pour cette violence, va voir south park");
//}


//Console.WriteLine("Veuillez faire votre selection : \n" +
//                  "1. Club Sandwich\n" +
//                  "2. Américain\n" +
//                  "3. Poulet cury\n" +
//                  "4. Poulet cury bien épicé");


//int choix = int.Parse(Console.ReadLine());

//switch (choix)
//{
//    case 1: Console.WriteLine("Voici votre club sandwich !");
//            break;
//    case 2: Console.WriteLine("Voici votre Américain, le sandwich !");
//            break;
//    case 3: 
//    case 4: Console.WriteLine("Voici votre Poulet Cury");
//        break;
//    default: Console.WriteLine("Choix invalide");
//        break;
//}


//Random rand = new Random();

//int nombreMystere = rand.Next(1, 11);
//int nombreUtilisateur;

//do
//{

//    Console.Write("Votre tentative : ");
//    nombreUtilisateur = int.Parse(Console.ReadLine());

//    if (nombreUtilisateur > nombreMystere)
//    {
//        Console.WriteLine("Le nombre mystère est plus petit");
//    }
//    else if (nombreUtilisateur < nombreMystere)
//    {
//        Console.WriteLine("Le nombre mystère est plus grand");
//    }

//} while (nombreUtilisateur != nombreMystere);

//Console.WriteLine("Bravo le nombre mystère était : "+ nombreMystere);



//List<int> list = new List<int> { 1, 2, 3 };




//for (int i = 0; i < list.Count; i++)
//{
//    Console.WriteLine(list[i]++);
//}


//int nombre = ++list[0];

// list[0] = list[0] + 1
// nombre = list[0]


//nombre = list[0]++;
// nombre = list[0]
// list[0] = list[0] + 1

//foreach (int element in list)
//{
//    Console.WriteLine(element);
//}

#endregion

#region methodes
//using TI_DEVEOPS_RECAP;

//Methode m = new Methode();

////string prenom = "John";
////string nom = "Doe";

////m.DireBonjour(prenom, nom); // Bonjour John Doe // 

////Console.WriteLine(prenom +" " + nom); // Super John Doe le Dauphin


//List<string> list = new List<string>() { "lundi", "mardi", "mercredi" };

//m.ChangerJour(list);

//Console.WriteLine(list[0]);

//string prenom = "John";

//prenom = m.ChangerPrenom(prenom);

//Console.WriteLine(prenom); // Super John

//string[] monTab = { "hello", "à", "tous" };

//Console.ReadLine();



//int[] ints = new int[10];

//Random rnd = new Random();

//for (int i = 0; i < ints.Length; i++)
//{
//    ints[i] = rnd.Next(1, 101);
//}

//Console.ReadLine();

#endregion

#region Methode carré

//using TI_DEVEOPS_RECAP;

//Console.WriteLine("Veuillez entrer le nombre dont vous voulez calculer le carré : ");
//int nombre = int.Parse(Console.ReadLine());


//int carre = CalculCarre(nombre);

//Console.WriteLine($"Le carré de {nombre} est : {carre}");



//int CalculCarre(int nombre)
//{
//    int result = nombre * nombre;
//    return result;
//}


#endregion

#region Methode Recherche

//int[] tableauNombre = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//Console.WriteLine("Veuillez entrer le nombre que vous voulez trouver : ");
//int nombreRecherche = int.Parse(Console.ReadLine());

//int indice = TrouverNombre(tableauNombre, nombreRecherche);

//if(indice == -1)
//{
//    Console.WriteLine($"Le nombre {nombreRecherche} n'est pas dans la liste !");
//}
//else
//{
//    Console.WriteLine($"Le nombre {nombreRecherche} est à l'indice {indice}");
//}


//int TrouverNombre(int[] tableauDeInts, int nombreATrouver)
//{
//    int indice = -1;

//    for(int i = 0; i < tableauDeInts.Length; i++)
//    {
//        if (tableauDeInts[i] == nombreATrouver)
//        {
//            indice = i;
//            return indice;
//        }
//    }
//    return indice;
//}


#endregion

#region Methode Fusion

//int[] tableau1 = new int[5];
//int[] tableau2 = new int[5];
//int[] tableauFusion = new int[tableau1.Length + tableau2.Length];



//GenererValeurTableau(tableau1);
//GenererValeurTableau(tableau2);

//FusionTableau(tableau1, tableau2, tableauFusion);

//AfficherTableau(tableau1);
//AfficherTableau(tableau2);
//AfficherTableau(tableauFusion);


//void FusionTableau(int[] tableau1, int[] tableau2, int[] tableauFusion)
//{
//    for (int i = 0;i < tableau1.Length; i++)
//    {
//        tableauFusion[i] = tableau1[i];
//    }
//    for (int i = tableau1.Length; i < tableauFusion.Length; i++)
//    {
//        tableauFusion[i] = tableau2[i - tableau1.Length];
//    }
//}

//void AfficherTableau(int[] tableau)
//{
//    foreach(int nombre in tableau)
//    {
//        Console.Write(nombre + ", ");
//    }
//    Console.WriteLine();
//}

//void GenererValeurTableau(int[] tableau)
//{
//    Random rnd = new Random();

//    for (int i = 0; i < tableau.Length; i++)
//    {
//        tableau[i] = rnd.Next(1, 101);
//    }
//}






#endregion

#region Patate

//string[] sceau = new string[17];
//string[] marmitte = new string[50];
//int patateDansMarmitte = 0;

//while(marmitte.Length != patateDansMarmitte)
//{
//    RemplirSceau(sceau);
//    patateDansMarmitte = RemplirMarmitte(sceau, marmitte, patateDansMarmitte);
//}

//Console.WriteLine("La marmitte est remplie");








//void RemplirSceau(string[] sceau)
//{
//    if (SceauVide(sceau))
//    {
//        for(int i = 0;  i < sceau.Length; i++)
//        {
//            sceau[i] = "O";
//        }
//    }
//}

//int RemplirMarmitte(string[] sceau, string[] marmitte, int patateDansMarmitte)
//{
//    int indice = patateDansMarmitte;

//    for(int i = 0;i < sceau.Length && patateDansMarmitte < 50; i++)
//    {
//        marmitte[i + indice] = "P";
//        patateDansMarmitte++;
//        sceau[i] = "";
//    }

//    return patateDansMarmitte;
//}

//bool SceauVide(string[] sceau)
//{
//    foreach(string element in sceau)
//    {
//        if(element == "O")
//        {
//            return false;
//        }
//    }
//    return true;
//}
#endregion