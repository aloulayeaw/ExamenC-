namespace GestionEmploye.Models
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnService = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlaficher = new System.Windows.Forms.Panel();
            this.pnlaff = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnService);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 702);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.pnlaficher);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 100);
            this.panel2.TabIndex = 1;
            // 
            // btnService
            // 
            this.btnService.Location = new System.Drawing.Point(26, 246);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(136, 63);
            this.btnService.TabIndex = 2;
            this.btnService.Text = "SERVICE";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 63);
            this.button1.TabIndex = 3;
            this.button1.Text = "EMPLOYE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlaficher
            // 
            this.pnlaficher.Location = new System.Drawing.Point(0, 100);
            this.pnlaficher.Name = "pnlaficher";
            this.pnlaficher.Size = new System.Drawing.Size(812, 602);
            this.pnlaficher.TabIndex = 2;
            // 
            // pnlaff
            // 
            this.pnlaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlaff.Location = new System.Drawing.Point(200, 100);
            this.pnlaff.Name = "pnlaff";
            this.pnlaff.Size = new System.Drawing.Size(812, 602);
            this.pnlaff.TabIndex = 2;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 702);
            this.Controls.Add(this.pnlaff);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlaficher;
        private System.Windows.Forms.Panel pnlaff;
    }
}