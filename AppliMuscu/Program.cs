using System;

namespace AppliMuscu
{
    public class Seance
    {
        public DateTime ChronoS { get; }
        public TimeSpan DureeS { get; set; }
        public int VolumeS { get; set; }
        public int NbSerieS { get; set; }

        public Seance(DateTime chrono, TimeSpan duree, int volume, int nbSerie)
        {
            ChronoS = chrono;
            DureeS = duree;
            VolumeS = volume;
            NbSerieS = nbSerie;
        }

        public void CommencerChronometre()
        {
            // Boucle infinie pour simuler le chronomètre
            while (true)
            {
                // Mise à jour de la durée de la séance
                DureeS = DateTime.Now.Subtract(ChronoS);

                // Affichage de la durée au format HH:MM:SS
                Console.WriteLine(DureeS.ToString("hh\\:mm\\:ss"));
            }
        }
    }

    public class Exercice
    {
        public string Nom { get; set; }
        public int Poids { get; set; }
        public int Repetitions { get; set; }

        public Exercice(string nom, int poids, int repetitions)
        {
            Nom = nom;
            Poids = poids;
            Repetitions = repetitions;
        }
    }

    public class Utilisateur
    {
        public string Nom { get; set; }
        public DateTime DateNaissance { get; set; }
        public int Taille { get; set; }
        public int Poids { get; set; }

        public Utilisateur(string nom, DateTime dateNaissance, int taille, int poids)
        {
            Nom = nom;
            DateNaissance = dateNaissance;
            Taille = taille;
            Poids = poids;
        }

        public double CalculerProgression()
        {
            // Implémentez ici le calcul de la progression
            return 0.0;
        }

        public void SauvegarderDonnees()
        {
            // Implémentez ici la sauvegarde des données
        }

        public void ChargerDonnees()
        {
            // Implémentez ici le chargement des données
        }
    }
}
