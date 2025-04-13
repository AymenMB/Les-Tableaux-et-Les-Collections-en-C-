// GestionEtudiantsForm_Tableau.cs
// Activité 1 : Implémentation avec tableaux statiques de dictionnaires

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestionEtudiant
{
    public class GestionEtudiantsForm_Tableau : Form
    {
        // Tableau FIXE de dictionnaires  
        private Dictionary<string, object>[] _etudiantsTableau = new Dictionary<string, object>[10];
        private int _prochainId = 1;

        // Composants du formulaire
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView;
        private GroupBox groupBoxEtudiant;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelNom;
        private Label labelAge;
        private TextBox textBoxNom;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonAjouter;
        private Button buttonModifier;
        private Button buttonSupprimer;
        private NumericUpDown numericUpDownAge;
        private TextBox textBoxRecherche;
        private Button buttonRechercher;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button buttonTrier;

        private System.ComponentModel.IContainer components = null;

        public GestionEtudiantsForm_Tableau()
        {
            InitializeComponent();
            ConfigurerDataGridView();
            InitialiserDonneesTest();
            RafraichirGrille();
        }

        // --- Méthodes d'initialisation ---  
        private void ConfigurerDataGridView()
        {
            // Création manuelle des colonnes
            dataGridView.Columns.Add("Id", "ID");
            dataGridView.Columns.Add("Nom", "Nom");
            dataGridView.Columns.Add("Age", "Âge");
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void InitialiserDonneesTest()
        {
            AjouterEtudiant("Alice", 20);
            AjouterEtudiant("Bob", 22);
        }

        private void RafraichirGrille()
        {
            dataGridView.Rows.Clear();
            foreach (var etudiant in _etudiantsTableau)
            {
                if (etudiant != null)
                {
                    dataGridView.Rows.Add(etudiant["Id"], etudiant["Nom"], etudiant["Age"]);
                }
            }
        }

        // --- Opérations CRUD ---  
        private void AjouterEtudiant(string nom, int age)
        {
            if (_prochainId - 1 < _etudiantsTableau.Length)
            {
                _etudiantsTableau[_prochainId - 1] = new Dictionary<string, object>
                {
                    { "Id", _prochainId },
                    { "Nom", nom },
                    { "Age", age }
                };
                _prochainId++;
            }
            else
            {
                MessageBox.Show("Tableau plein !");
            }
        }

        private void ModifierEtudiant(int id, string nom, int age)
        {
            for (int i = 0; i < _etudiantsTableau.Length; i++)
            {
                if (_etudiantsTableau[i] != null && (int)_etudiantsTableau[i]["Id"] == id)
                {
                    _etudiantsTableau[i]["Nom"] = nom;
                    _etudiantsTableau[i]["Age"] = age;
                    break;
                }
            }
        }

        private void SupprimerEtudiant(int id)
        {
            for (int i = 0; i < _etudiantsTableau.Length; i++)
            {
                if (_etudiantsTableau[i] != null && (int)_etudiantsTableau[i]["Id"] == id)
                {
                    _etudiantsTableau[i] = null;
                    break;
                }
            }
        }

        // --- Tri et Recherche ---  
        private void TrierParNom()
        {
            for (int i = 0; i < _etudiantsTableau.Length - 1; i++)
            {
                for (int j = 0; j < _etudiantsTableau.Length - i - 1; j++)
                {
                    if (_etudiantsTableau[j] != null && _etudiantsTableau[j + 1] != null &&
                        String.Compare((string)_etudiantsTableau[j]["Nom"], (string)_etudiantsTableau[j + 1]["Nom"]) > 0)
                    {
                        var temp = _etudiantsTableau[j];
                        _etudiantsTableau[j] = _etudiantsTableau[j + 1];
                        _etudiantsTableau[j + 1] = temp;
                    }
                }
            }
        }

        private void RechercherParNom(string nom)
        {
            foreach (var etudiant in _etudiantsTableau)
            {
                if (etudiant != null && etudiant["Nom"].ToString().ToLower().Contains(nom.ToLower()))
                {
                    MessageBox.Show($"Trouvé : {etudiant["Nom"]} (ID: {etudiant["Id"]})");
                    return;
                }
            }
            MessageBox.Show("Aucun résultat.");
        }

        // --- Gestionnaires d'événements ---  
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNom.Text) && int.TryParse(numericUpDownAge.Value.ToString(), out int age))
            {
                AjouterEtudiant(textBoxNom.Text, age);
                RafraichirGrille();
                textBoxNom.Clear();
                numericUpDownAge.Value = 1;
            }
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView.SelectedRows[0].Cells[0].Value;
                ModifierEtudiant(id, textBoxNom.Text, int.Parse(numericUpDownAge.Value.ToString()));
                RafraichirGrille();
                textBoxNom.Clear();
                numericUpDownAge.Value = 1;
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView.SelectedRows[0].Cells[0].Value;
                SupprimerEtudiant(id);
                RafraichirGrille();
            }
        }

        private void buttonTrier_Click(object sender, EventArgs e)
        {
            TrierParNom();
            RafraichirGrille();
        }

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            RechercherParNom(textBoxRecherche.Text);
        }

        // --- Code généré par le concepteur Windows Form ---
        private void InitializeComponent()
        {
            // Ce code est similaire à celui de GestionEtudiantsForm.Designer.cs
            // Mais n'est pas inclus ici pour des raisons de clarté.
            // Dans une mise en œuvre réelle, vous auriez le même code d'interface utilisateur.
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}