using System;
using System.Collections.Generic;

namespace ExamCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans l'appli de gestion des villes");
            // déclaration liste villes
            List<Ville> listeVilles = new List<Ville>();
            while (true)
            {
                string choix = Menu();

                if (choix == "1")
                {
                    Ville v = CreateVille();
                    listeVilles.Add(v);
                }
                else if (choix == "2")
                {
                    Console.WriteLine("Liste des Villes créees");
                    Affiche(listeVilles);
                }
                else
                {
                    Console.WriteLine("Je n'ai pas compris");
                }
            }
        }

        private static string Menu()
        {
            Console.WriteLine("Que voulez-vous faire ?");
            Console.WriteLine("1. Creer une nouvelle ville");
            Console.WriteLine("2. Afficher la liste des villes");
            string choix = Console.ReadLine();
            return choix;
        }

        public static void Affiche(List<Ville> villes)
        {
            // pour chaque personne, on affiche un message
            foreach (Ville v in villes)
            {
                string message;
                message = CreerMessage(v);
                Console.WriteLine(message);
            }
        }

        public static Ville CreateVille()
        {
            // initialisation de la ville et ajout à la liste
            Ville v = new Ville();

            // demande du nom
            Console.WriteLine("Nom :");
            v.nom = Console.ReadLine();
            // demande du code postal
            v.cp = DemandeEntier("Code Postal:");
            // demande nombre habitans
            v.habitans = DemandeEntier("Nombre d'Habitans:");

            // construction du message
            string message;
            message = CreerMessage(v);
 
            return v;
        }

        public static string CreerMessage(Ville v)
        {
            string result;

            result = "Nom : " + v.nom + ", Code Postal: " + v.cp + "\nNombre d'habitants: " + v.habitans + "\n---------------------";

            return result;
        }

        public static int DemandeEntier(string message)
        {
            Console.WriteLine(message);
            string entree;
            entree = Console.ReadLine();
            int intValue;
            while (!int.TryParse(entree, out intValue))
            {
                Console.WriteLine("Saisie Incorrecte");
                entree = Console.ReadLine();
            }
            return intValue;
        }
    }
}
