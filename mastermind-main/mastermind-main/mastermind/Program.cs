using System;

namespace mastermind
{
    class Program
    { // Cette fonction sert à démarrer le Mastermind
        static void Main(string[] args)
        {
            string combinaison;
            int[] proposition;
            int[] combi;
            ChoixCombi(out combi);
            Afficher(combi);
            Console.WriteLine("Définis les nombres choisis");
            combinaison = Console.ReadLine();
            StringToArray(combinaison, out proposition);
            Afficher(proposition);
        }

        // Cette fonction sert à définir la cominaison
        static void ChoixCombi(out int[] combi)
        {
            combi = new int[4];
            Random rnd = new Random();
            for (int i = 0; i <= 3; i++)
            {
                int valeur = rnd.Next(1, 7);
                combi[i] = valeur;
            }
        }
        // Cette fonction sert à afficher un tableau
        static void Afficher(int[] combi)
        {
            for (int i = 0; i <= 3; i++)
            {
                Console.Write(combi[i]);
            }
        }

        static void StringToArray(string combinaison, out int[] proposition)
        {
            proposition = new int[4];
            for (int i = 0; i <= 3; i++)
            {
                proposition[i] = combinaison[i];
            }
        }
    }
}
