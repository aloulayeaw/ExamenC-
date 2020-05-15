namespace GestionEmploye.Models
{
    partial class User_Service
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
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgService = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id_Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NbreEmploye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgService)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(37, 152);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(133, 48);
            this.btnAjout.TabIndex = 0;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(37, 295);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(133, 48);
            this.btnModif.TabIndex = 1;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(37, 438);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(133, 48);
            this.btnSupp.TabIndex = 2;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "ENREGISTREMENT D\'UN SERVICE";
            // 
            // dvgService
            // 
            this.dvgService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.Id_Service,
            this.Libelle,
            this.NbreEmploye});
            this.dvgService.EnableHeadersVisualStyles = false;
            this.dvgService.Location = new System.Drawing.Point(306, 152);
            this.dvgService.Name = "dvgService";
            this.dvgService.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgService.RowTemplate.Height = 24;
            this.dvgService.Size = new System.Drawing.Size(447, 334);
            this.dvgService.TabIndex = 4;
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            // 
            // Id_Service
            // 
            this.Id_Service.HeaderText = "Id_Service";
            this.Id_Service.Name = "Id_Service";
            // 
            // Libelle
            // 
            this.Libelle.HeaderText = "Libelle";
            this.Libelle.Name = "Libelle";
            // 
            // NbreEmploye
            // 
            this.NbreEmploye.HeaderText = "NbreEmploye";
            this.NbreEmploye.Name = "NbreEmploye";
            // 
            // User_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dvgService);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnAjout);
            this.Name = "User_Service";
            this.Size = new System.Drawing.Size(812, 602);
            this.Load += new System.EventHandler(this.User_Service_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgService;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn NbreEmploye;
    }
}
