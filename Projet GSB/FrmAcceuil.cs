using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_GSB
{
    public partial class FrmAcceuil : Form
    {
        public FrmAcceuil()
        {
            InitializeComponent();
        }

        private void fermerMDI()
        {
            Form c;
            c = this.ActiveMdiChild;    //Récupère le formulaire actif
            if(c!= null)    //S'il existe,
            {
                c.Close();  //On le ferme
            }
        }

        private void rendVisible(bool val) //val vaut true of false
        {
            pictureBox1.Visible = val;  //La propriété Visible passe à Vrai ou Faux
            btnQuitter.Visible = val;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuMedicamentListe_Click(object sender, EventArgs e)
        {
            fermerMDI();    //Ferme le formulaire actif
            rendVisible(false); //Rend invisivles les composants de FrmAccueil
            FrmMedicament frmMedicament = new FrmMedicament();  //Crée une insstance de FrmMedicament
            frmMedicament.MdiParent = this; //Le formulaire MDI parent est l'instance en cours(this) de FrmAcceuil

            frmMedicament.Show(); //Montre le nouceau formulaire
        }
    }
}
