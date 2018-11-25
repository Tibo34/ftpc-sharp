using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ftpAppli
{
    public partial class ConnexionFTP : Form
    {
        private serveurFTP ftp;

        internal serveurFTP Ftp { get => ftp; set => ftp = value; }

        public ConnexionFTP()
        {
            InitializeComponent();
        }

        private void SaveFTP(object sender, EventArgs e)
        {
            if (!CheckCas())
            {
                MessageBox.Show("Tous les champs sont nécéssaire");
                return;
            }
            Ftp = new serveurFTP(this.portValue.Text,this.hoteValue.Text,this.idValue.Text,this.mdpValue.Text);
            Close();
        }

        private bool CheckCas()
        {
           foreach(Control c in this.Controls)
            {
                Console.WriteLine(c.Text);
                if(c is TextBox&& ((TextBox)c).Text==null)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
