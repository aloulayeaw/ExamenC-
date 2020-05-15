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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnService_Click(object sender, EventArgs e)
        {
            if(!pnlaff.Controls.Contains(User_Service.Instance))
            {
                pnlaff.Controls.Add(User_Service.Instance);
                User_Service.Instance.Dock = DockStyle.Fill;
                User_Service.Instance.BringToFront();
            }else
            {
                User_Service.Instance.BringToFront();
            }
        }
    }
}
