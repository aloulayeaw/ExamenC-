namespace GestionEmploye.Models
{
    partial class User_Emp
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjout = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NbreEnfant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anciennete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salaire_Base = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimeS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ipres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "ENREGISTREMENT D\'UN EMPLOYE";
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(545, 86);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(133, 48);
            this.btnAjout.TabIndex = 5;
            this.btnAjout.Text = "Ajouter Employe";
            this.btnAjout.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(311, 90);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 37);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Recherche";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.Matricule,
            this.Prenom,
            this.Nom,
            this.NbreEnfant,
            this.Anciennete,
            this.Salaire_Base,
            this.Statut,
            this.PrimeS,
            this.Prime,
            this.Ipres,
            this.Nom_Service});
            this.dataGridView1.Location = new System.Drawing.Point(15, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(779, 289);
            this.dataGridView1.TabIndex = 8;
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            // 
            // Matricule
            // 
            this.Matricule.HeaderText = "Matricule";
            this.Matricule.Name = "Matricule";
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.Name = "Prenom";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // NbreEnfant
            // 
            this.NbreEnfant.HeaderText = "NbreEnfant";
            this.NbreEnfant.Name = "NbreEnfant";
            // 
            // Anciennete
            // 
            this.Anciennete.HeaderText = "Anciennete";
            this.Anciennete.Name = "Anciennete";
            // 
            // Salaire_Base
            // 
            this.Salaire_Base.HeaderText = "Salaire_Base";
            this.Salaire_Base.Name = "Salaire_Base";
            // 
            // Statut
            // 
            this.Statut.HeaderText = "Statut";
            this.Statut.Name = "Statut";
            // 
            // PrimeS
            // 
            this.PrimeS.HeaderText = "PrimeS";
            this.PrimeS.Name = "PrimeS";
            // 
            // Prime
            // 
            this.Prime.HeaderText = "Prime";
            this.Prime.Name = "Prime";
            // 
            // Ipres
            // 
            this.Ipres.HeaderText = "Ipres";
            this.Ipres.Name = "Ipres";
            // 
            // Nom_Service
            // 
            this.Nom_Service.HeaderText = "Service";
            this.Nom_Service.Name = "Nom_Service";
            // 
            // User_Emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.label1);
            this.Name = "User_Emp";
            this.Size = new System.Drawing.Size(812, 602);
            this.Load += new System.EventHandler(this.User_Emp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn NbreEnfant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anciennete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salaire_Base;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statut;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimeS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ipres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Service;
    }
}
