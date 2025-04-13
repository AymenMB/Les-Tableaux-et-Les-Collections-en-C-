// Etudiant.cs
using System;
using System.Collections.Generic;
using System.Linq; // Important pour le tri et la recherche
using System.Text.RegularExpressions;

namespace GestionEtudiant
{
    public class Etudiant
    {
        // --- Propriétés ---
        public int Id { get; private set; } // Id en lecture seule
        public string Nom { get; private set; } // Nom et Age : plus de set public
        public int Age { get; private set; }
        public string Email { get; private set; }

        private static int _idCourant = 1;
        private static List<Etudiant> _tousLesEtudiants = new List<Etudiant>(); // Liste *statique*

        // --- Constructeur ---
        public Etudiant(string nom, int age, string email)
        {
            Id = _idCourant++;
            _tousLesEtudiants.Add(this); // Ajout à la liste statique
            SetNom(nom); //Utilisation des methodes de validation
            SetAge(age);
            SetEmail(email);
        }

        // --- Méthodes de modification (avec validation) ---

        public void SetNom(string nom)
        {
            if (string.IsNullOrWhiteSpace(nom))
            {
                throw new ArgumentException("Le nom ne peut pas être vide ou composé uniquement d'espaces.", nameof(nom));
            }
            if (nom.Length > 15)
            {
                throw new ArgumentException("Le nom est trop long (maximum 15 caractères).", nameof(nom));
            }
            if (!EstNomValide(nom))
            {
                throw new ArgumentException("Le nom contient des caractères invalides.", nameof(nom));
            }
            Nom = nom;
        }

        public void SetAge(int age)
        {
            if (age < 1 || age > 150)
            {
                throw new ArgumentOutOfRangeException(nameof(age), "L'âge doit être compris entre 1 et 150.");
            }
            Age = age;
        }

        public void SetEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentException("L'email ne peut pas être vide ou composé uniquement d'espaces.", nameof(email));
            }
            if (!EstEmailValide(email))
            {
                throw new ArgumentException("L'email n'est pas valide.", nameof(email));
            }
            Email = email;
        }
        // --- Méthodes de validation (pourraient être privées, mais utiles pour les tests) ---
        private bool EstNomValide(string nom)
        {
            string caracteresAutorises = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 -'";
            foreach (char c in nom)
            {
                if (caracteresAutorises.IndexOf(c) == -1)
                {
                    return false;
                }
            }
            return true;
        }
        private bool EstEmailValide(string email)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                             + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                             + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }

        // --- Méthodes statiques pour gérer la liste de *tous* les étudiants ---

        public static List<Etudiant> TousLesEtudiants()
        {
            return _tousLesEtudiants;
        }
        public static Etudiant GetEtudiantParId(int id)
        {
            return _tousLesEtudiants.FirstOrDefault(e => e.Id == id);
        }

        public static void SupprimerEtudiant(int id)
        {
            Etudiant etudiant = _tousLesEtudiants.FirstOrDefault(e => e.Id == id);
            if (etudiant != null)
            {
                _tousLesEtudiants.Remove(etudiant);
            }
            else
            {
                throw new ArgumentException("L'étudiant n'existe pas.", nameof(id));
            }

        }

        public static void TrierEtudiantsParNom()
        {
            _tousLesEtudiants = _tousLesEtudiants.OrderBy(e => e.Nom).ToList();
        }

        public static List<Etudiant> RechercherEtudiantsParNom(string nom)
        {
            return _tousLesEtudiants.Where(e => e.Nom.ToLower().Contains(nom.ToLower())).ToList();
        }
        // --- Destructeur (pour la démo, mais pas vraiment utile dans ce cas) ---
        // En C#, on utilise rarement des destructeurs explicitement.  Le garbage collector s'en occupe.
        ~Etudiant()
        {
            //  _tousLesEtudiants.Remove(this); // Enlevez si vous ne voulez *pas* supprimer automatiquement
            // les étudiants de la liste lorsqu'ils sont détruits.
        }

    }
}