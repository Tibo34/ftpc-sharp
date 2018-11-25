using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ftpAppli
{
    public partial class MainForm : Form
    {
        private ArrayList ftpServeurs;

        public MainForm()
        {
            InitializeComponent();
            ftpServeurs = new ArrayList();
        }

        private void CloseApp(object sender, EventArgs e)
        {
            Close();
        }

        private void AddFTP(object sender, EventArgs e)
        {
            ConnexionFTP ftpForm = new ConnexionFTP();
            ftpForm.ShowDialog();
            ftpServeurs.Add(ftpForm.Ftp);            
        }

        private void ftpConnect(serveurFTP ftp)
        {
            string target = ftp.Hote;
            FtpWebRequest ftpRequest = (FtpWebRequest)FtpWebRequest.Create(target); ;
        }

        private void ConsulterFTP(object sender, EventArgs e)
        {
            foreach(serveurFTP ftp in ftpServeurs)
            {
                DisplayFtp(ftp);
            }
        }

        private void DisplayFtp(serveurFTP ftp)
        {
            Label port, hote, id, mdp;
            port = new Label();
            port.Text = ftp.Port.ToString();
            hote = new Label();
            hote.Text = ftp.Hote;
            id = new Label();
            id.Text = ftp.Identifiant;
            mdp = new Label();
            mdp.Text = ftp.Mdp;
            int row = ftpServeurs.IndexOf(ftp) + 1;
            Serveur.Controls.Add(port, 0, row);
            Serveur.Controls.Add(hote, 1, row);
            Serveur.Controls.Add(id, 2, row);
            Serveur.Controls.Add(mdp, 3, row);
        }
    }
}
