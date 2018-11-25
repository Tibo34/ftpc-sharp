using System;

namespace ftpAppli
{
    internal class serveurFTP
    {
        private int port;
        private string hote;
        private string identifiant;
        private string mdp;

        public serveurFTP(int p,string h,string i,string m)
        {
            port = p;
            hote = h;
            identifiant = i;
            mdp = m;
        }


        public serveurFTP(string p, string h, string i, string m) : this (Int32.Parse(p), h, i, m)
        {
            
        }


    }
}