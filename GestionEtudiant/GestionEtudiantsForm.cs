// GestionEtudiantsForm.cs (Version avec presque toute la logique dans Etudiant.cs)

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestionEtudiant
{
    public partial class GestionEtudiantsForm : Form
    {
        // Plus besoin de la liste _etudiants ici !
        private ErrorProvider errorProvider1 = new ErrorProvider(); // Toujours besoin de l'ErrorProvider

        public GestionEtudiantsForm()
        {
            InitializeComponent();
            ConfigurerDataGridView();
            InitialiserDonneesTest();
            RafraichirGrille();

            numericUpDownAge.Text = "";
            numericUpDownAge.Minimum = -1;
        }

        private void ConfigurerDataGridView()
        {
            dataGridView.Columns.Add("Id", "ID");
            dataGridView.Columns.Add("Nom", "Nom");
            dataGridView.Columns.Add("Age", "Âge");
            dataGridView.Columns.Add("Email", "Email");
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void InitialiserDonneesTest()
        {
            // On crée les étudiants *directement*. La validation est dans la classe Etudiant.
            new Etudiant("Alice", 20, "alice@example.com");
            new Etudiant("Bob", 22, "bob@example.com");
            //RafraichirGrille(); //Pas besoin ici
        }

        private void RafraichirGrille()
        {
            dataGridView.Rows.Clear();
            // On utilise la méthode *statique* TousLesEtudiants() de la classe Etudiant.
            foreach (var etudiant in Etudiant.TousLesEtudiants())
            {
                dataGridView.Rows.Add(etudiant.Id, etudiant.Nom, etudiant.Age, etudiant.Email);
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                // Tentative de création.  Si ça échoue, le constructeur de Etudiant lèvera une exception.
                new Etudiant(textBoxNom.Text.Trim(), int.Parse(numericUpDownAge.Text.Trim()), textBoxEmail.Text.Trim());
                RafraichirGrille();
                textBoxNom.Clear();
                textBoxEmail.Clear();
                numericUpDownAge.Text = "";
                errorProvider1.SetError(numericUpDownAge, "");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                //Pour tous les autres types d'erreurs
                MessageBox.Show("Une erreur inattentue s'est produite: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView.SelectedRows[0].Cells["Id"].Value;
                Etudiant etudiant = Etudiant.GetEtudiantParId(id); // Utilisation de la méthode statique

                if (etudiant != null)
                {
                    try
                    {
                        // On utilise les méthodes "Set" de la classe Etudiant
                        etudiant.SetNom(textBoxNom.Text.Trim());
                        etudiant.SetAge(int.Parse(numericUpDownAge.Text.Trim()));
                        etudiant.SetEmail(textBoxEmail.Text.Trim());
                        RafraichirGrille();
                        textBoxNom.Clear();
                        textBoxEmail.Clear();
                        numericUpDownAge.Text = "";
                        errorProvider1.SetError(numericUpDownAge, "");
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show(ex.Message, "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception ex)
                    {
                        //Pour tous les autres types d'erreurs
                        MessageBox.Show("Une erreur inattentue s'est produite: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un étudiant à modifier.", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView.SelectedRows[0].Cells["Id"].Value;
                try
                {
                    Etudiant.SupprimerEtudiant(id); // Utilisation de la méthode statique
                    RafraichirGrille();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur inatendue s'est produite: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un étudiant à supprimer.", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonTrier_Click(object sender, EventArgs e)
        {
            Etudiant.TrierEtudiantsParNom(); // Utilisation de la méthode statique
            RafraichirGrille();
        }

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            //  RechercherParNom(textBoxRecherche.Text);
            List<Etudiant> resultats = Etudiant.RechercherEtudiantsParNom(textBoxRecherche.Text); // Utilisation de la méthode statique
            if (resultats.Count > 0)
            {
                string message = "";
                foreach (var etudiant in resultats)
                {
                    message += $"Trouvé : {etudiant.Nom} (ID: {etudiant.Id}), Email: {etudiant.Email})\n";
                }
                MessageBox.Show(message, "Résultats de la recherche", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Aucun résultat.", "Résultat de la recherche", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void numericUpDownAge_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(numericUpDownAge.Text) || !int.TryParse(numericUpDownAge.Text, out int age) || age < 1 || age > 150)
            {
                errorProvider1.SetError(numericUpDownAge, "Veuillez entrer un âge valide (entre 1 et 150).");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(numericUpDownAge, "");
            }
        }
    }
}