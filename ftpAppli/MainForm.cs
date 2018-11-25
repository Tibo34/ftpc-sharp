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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CloseApp(object sender, EventArgs e)
        {
            Close();
        }

        private void AddFTP(object sender, EventArgs e)
        {
            ConnexionFTP ftpForm = new ConnexionFTP();
            ftpForm.ShowDialog();
        }
    }
}
