using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_DEVEOPS_RECAP
{
    public class Methode
    {


        public void DireBonjour(string prenom, string nom)
        {

            prenom = "Super John";
            nom = "Doe Le Dauphin";
            Console.WriteLine($"Bonjour {prenom} {nom}");
        }


        public void ChangerJour(List<string> list)
        {
            list[0] = "Jeremdi";
            Console.WriteLine(list[0]);
        }

        public string ChangerPrenom(string prenom)
        {
            prenom = "SuperJohn";
            Console.WriteLine(prenom);

            return prenom;
        }
    }
}
