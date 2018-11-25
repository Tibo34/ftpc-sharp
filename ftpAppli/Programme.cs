using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ftpAppli
{
    class fptAppli
    {
      
        [STAThread]
        public static void Main()
        {
            MainForm form = new MainForm();
            form.ShowDialog();        
            
            
        }
    }
}
