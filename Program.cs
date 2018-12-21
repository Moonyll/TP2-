using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = new Random().Next(0, 50); // nombre aléatoire entre 0 et 50
            int essai = 0;                    // nombre d'essais
            bool ok = false;              // variable booléenne
            Console.WriteLine("Veuillez deviner un nombre compris entre 0 et 50");
            while (!ok)                   // Démarrage de la boucle while avec négation de la valeur booléenne
            {
                int rep = int.Parse(Console.ReadLine()); // conversion string en int et démarrage de la 1ière boucle if
                if (rep == n) // le chiffre saisi est le bon                       
                {
                ok = true; // boucle while stoppée
                }
                else
                {
                if (rep < n)
                {Console.WriteLine("Le chiffre saisi est trop petit, veuillez recommencer...");} // nombre trop petit
                    // Console.Clear() permet de réinitialiser la fenêtre console
                elsei
                {Console.WriteLine("Le chiffre saisi est trop grand, veuillez recommencer...");} // nombre trop grand
                }
            essai++; // incrémentation du nombre d'essais
            }
            Console.WriteLine("Bravo, vous avez trouvé le bon chiffre en " + essai + " fois.");
            Console.ReadKey();            
        }
    }    
}
// Console.ForegroundColor = Console.Color.Black; Console.BackgroundColor = Console.Color.Cyan changer les couleurs !
// Console.SetCursorPosition(20,1) pour centrer en position 20 et 1 !
