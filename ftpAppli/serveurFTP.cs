using System;

namespace ftpAppli
{
    public class serveurFTP
    {
        private readonly int port;
        private readonly string hote;
        private readonly string identifiant;
        private readonly string mdp;

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

       

        public string Hote => hote;

        public string Identifiant => identifiant;

        public string Mdp => mdp;

        public int Port => port;
    }
}