using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEmploye.Models
{
    public partial class FRM_Add : Form
    {
        private UserControl userserv;
        public FRM_Add(UserControl userS)
        {
            InitializeComponent();
            this.userserv = userS;
        }
        string textoblig()
        {
            if(txtlib.Text == "")
            {
                return "Entrer le libelle";
            }
            if (txtNbre.Text== "")
            {
                return "Entrer le Nombre d'employé";
            }
            return null;
        }

        private void FRM_Add_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textoblig()!=null)
            {
                MessageBox.Show(textoblig(),"Obligatoire",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }else
            {
                Services.CLS_Service clsserv = new Services.CLS_Service();
                if(clsserv.Add_Service(txtlib.Text, int.Parse(txtNbre.Text))==true)
                {
                    MessageBox.Show("Service ajouter avec succé", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (userserv as User_Service).Ajoutdgv();
                }else
                {
                    MessageBox.Show("Libelle existe deja", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
