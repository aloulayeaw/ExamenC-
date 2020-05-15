using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEmploye.Models
{
    public partial class User_Service : UserControl
    {
        private static User_Service UserServ;
        private dbgestionemployeContext db;

        public static User_Service Instance
        {
            get
            {
                if(UserServ==null)
                {
                    UserServ = new User_Service();
                }
                return UserServ;
            }
        }

        public User_Service()
        {
            InitializeComponent();
            db = new dbgestionemployeContext();
        }

        public void Ajoutdgv()
        {
            dvgService.Rows.Clear();
            foreach(var S in db.Service_Emp)
            {
                dvgService.Rows.Add(false, S.ID_SERVICE, S.Libelle, S.NbrEmploye);
            }
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            Models.FRM_Add frmserv = new FRM_Add(this);
            frmserv.ShowDialog();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            Models.FRM_Add frmserv = new FRM_Add(this);
            frmserv.ShowDialog();
        }

        private void User_Service_Load(object sender, EventArgs e)
        {
            Ajoutdgv();
        }
    }
}
