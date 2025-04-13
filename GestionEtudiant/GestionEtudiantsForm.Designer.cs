// GestionEtudiantsForm.Designer.cs

namespace GestionEtudiant
{
    partial class GestionEtudiantsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView = new DataGridView();
            groupBoxEtudiant = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            labelNom = new Label();
            labelAge = new Label();
            textBoxNom = new TextBox();
            numericUpDownAge = new NumericUpDown();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonAjouter = new Button();
            buttonModifier = new Button();
            buttonSupprimer = new Button();
            textBoxRecherche = new TextBox();
            buttonRechercher = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            buttonTrier = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBoxEtudiant.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dataGridView, 0, 3);
            tableLayoutPanel1.Controls.Add(groupBoxEtudiant, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 166F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1100, 630);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(4, 310);
            dataGridView.Margin = new Padding(4);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1092, 316);
            dataGridView.TabIndex = 0;
            // 
            // groupBoxEtudiant
            // 
            groupBoxEtudiant.AutoSize = true;
            groupBoxEtudiant.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxEtudiant.BackgroundImageLayout = ImageLayout.None;
            groupBoxEtudiant.Controls.Add(tableLayoutPanel2);
            groupBoxEtudiant.Dock = DockStyle.Fill;
            groupBoxEtudiant.Location = new Point(4, 76);
            groupBoxEtudiant.Margin = new Padding(4);
            groupBoxEtudiant.Name = "groupBoxEtudiant";
            groupBoxEtudiant.Padding = new Padding(4);
            groupBoxEtudiant.Size = new Size(1092, 158);
            groupBoxEtudiant.TabIndex = 4;
            groupBoxEtudiant.TabStop = false;
            groupBoxEtudiant.Text = "Détails étudiant";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 446F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(labelNom, 0, 0);
            tableLayoutPanel2.Controls.Add(labelAge, 0, 1);
            tableLayoutPanel2.Controls.Add(textBoxNom, 1, 0);
            tableLayoutPanel2.Controls.Add(numericUpDownAge, 1, 1);
            tableLayoutPanel2.Controls.Add(labelEmail, 0, 2);
            tableLayoutPanel2.Controls.Add(textBoxEmail, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(4, 31);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1084, 123);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Dock = DockStyle.Fill;
            labelNom.Location = new Point(4, 0);
            labelNom.Margin = new Padding(4, 0, 4, 0);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(88, 45);
            labelNom.TabIndex = 7;
            labelNom.Text = "&Nom : ";
            labelNom.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Dock = DockStyle.Fill;
            labelAge.Location = new Point(4, 45);
            labelAge.Margin = new Padding(4, 0, 4, 0);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(88, 42);
            labelAge.TabIndex = 9;
            labelAge.Text = "A&ge :";
            labelAge.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxNom
            // 
            textBoxNom.Dock = DockStyle.Fill;
            textBoxNom.Location = new Point(100, 4);
            textBoxNom.Margin = new Padding(4);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(438, 34);
            textBoxNom.TabIndex = 8;
            // 
            // numericUpDownAge
            // 
            numericUpDownAge.Location = new Point(100, 49);
            numericUpDownAge.Margin = new Padding(4);
            numericUpDownAge.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownAge.Name = "numericUpDownAge";
            numericUpDownAge.Size = new Size(80, 34);
            numericUpDownAge.TabIndex = 10;
            numericUpDownAge.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Dock = DockStyle.Fill;
            labelEmail.Location = new Point(4, 87);
            labelEmail.Margin = new Padding(4, 0, 4, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(88, 45);
            labelEmail.TabIndex = 11;
            labelEmail.Text = "E&mail :";
            labelEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Dock = DockStyle.Fill;
            textBoxEmail.Location = new Point(100, 91);
            textBoxEmail.Margin = new Padding(4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(438, 34);
            textBoxEmail.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonAjouter);
            flowLayoutPanel1.Controls.Add(buttonModifier);
            flowLayoutPanel1.Controls.Add(buttonSupprimer);
            flowLayoutPanel1.Controls.Add(textBoxRecherche);
            flowLayoutPanel1.Controls.Add(buttonRechercher);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(4, 4);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1092, 64);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // buttonAjouter
            // 
            buttonAjouter.AutoSize = true;
            buttonAjouter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAjouter.Cursor = Cursors.Hand;
            buttonAjouter.Font = new Font("Segoe UI", 12.1008406F, FontStyle.Bold);
            buttonAjouter.Image = Properties.Resources.add_icon;
            buttonAjouter.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAjouter.Location = new Point(4, 4);
            buttonAjouter.Margin = new Padding(4);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(145, 54);
            buttonAjouter.TabIndex = 0;
            buttonAjouter.Text = "&Ajouter";
            buttonAjouter.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAjouter.UseVisualStyleBackColor = true;
            buttonAjouter.Click += buttonAjouter_Click;
            // 
            // buttonModifier
            // 
            buttonModifier.AutoSize = true;
            buttonModifier.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonModifier.Cursor = Cursors.Hand;
            buttonModifier.Font = new Font("Segoe UI", 12.1008406F, FontStyle.Bold);
            buttonModifier.Image = Properties.Resources.pencil_small_icon;
            buttonModifier.ImageAlign = ContentAlignment.MiddleLeft;
            buttonModifier.Location = new Point(157, 4);
            buttonModifier.Margin = new Padding(4);
            buttonModifier.Name = "buttonModifier";
            buttonModifier.Size = new Size(156, 54);
            buttonModifier.TabIndex = 1;
            buttonModifier.Text = "&Modifier";
            buttonModifier.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonModifier.UseVisualStyleBackColor = true;
            buttonModifier.Click += buttonModifier_Click;
            // 
            // buttonSupprimer
            // 
            buttonSupprimer.AutoSize = true;
            buttonSupprimer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonSupprimer.Cursor = Cursors.Hand;
            buttonSupprimer.Font = new Font("Segoe UI", 12.1008406F, FontStyle.Bold);
            buttonSupprimer.Image = Properties.Resources.remove_icon;
            buttonSupprimer.Location = new Point(321, 4);
            buttonSupprimer.Margin = new Padding(4);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Size = new Size(174, 54);
            buttonSupprimer.TabIndex = 2;
            buttonSupprimer.Text = "&Supprimer";
            buttonSupprimer.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSupprimer.UseVisualStyleBackColor = true;
            buttonSupprimer.Click += buttonSupprimer_Click;
            // 
            // textBoxRecherche
            // 
            textBoxRecherche.Location = new Point(502, 15);
            textBoxRecherche.Margin = new Padding(3, 15, 3, 3);
            textBoxRecherche.Name = "textBoxRecherche";
            textBoxRecherche.Size = new Size(289, 34);
            textBoxRecherche.TabIndex = 4;
            // 
            // buttonRechercher
            // 
            buttonRechercher.AutoSize = true;
            buttonRechercher.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonRechercher.Cursor = Cursors.Hand;
            buttonRechercher.Font = new Font("Segoe UI", 12.1008406F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRechercher.Image = Properties.Resources.spyglass_icon;
            buttonRechercher.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRechercher.Location = new Point(797, 3);
            buttonRechercher.Name = "buttonRechercher";
            buttonRechercher.Size = new Size(179, 54);
            buttonRechercher.TabIndex = 3;
            buttonRechercher.Text = "&Rechercher";
            buttonRechercher.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRechercher.UseVisualStyleBackColor = true;
            buttonRechercher.Click += buttonRechercher_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(buttonTrier);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(4, 242);
            flowLayoutPanel2.Margin = new Padding(4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1092, 60);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // buttonTrier
            // 
            buttonTrier.AutoSize = true;
            buttonTrier.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonTrier.Cursor = Cursors.Hand;
            buttonTrier.Image = Properties.Resources.arrow_double_up_icon;
            buttonTrier.Location = new Point(890, 4);
            buttonTrier.Margin = new Padding(4);
            buttonTrier.Name = "buttonTrier";
            buttonTrier.Size = new Size(198, 54);
            buttonTrier.TabIndex = 11;
            buttonTrier.Text = "&Trier par Nom";
            buttonTrier.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonTrier.UseVisualStyleBackColor = true;
            buttonTrier.Click += buttonTrier_Click;
            // 
            // GestionEtudiantsForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12.1008406F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KeyPreview = true;
            Margin = new Padding(4);
            Name = "GestionEtudiantsForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion des Etudiants";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBoxEtudiant.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView;
        private GroupBox groupBoxEtudiant;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelNom;
        private Label labelAge;
        private TextBox textBoxNom;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonTrier;
        private Button buttonSupprimer;
        private Button buttonAjouter;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button buttonModifier;
        private NumericUpDown numericUpDownAge;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private TextBox textBoxRecherche;
        private Button buttonRechercher;
    }
}