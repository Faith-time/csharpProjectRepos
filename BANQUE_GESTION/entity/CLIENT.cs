using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANQUE_GESTION.entity
{
    internal class CLIENT
    {
        public static int id = 0;
        public int numClient;
        public string prenom;
        public string nom;
        public string tel;


        public CLIENT()
        {
            id++;
            numClient = id;
        }
        public CLIENT(string prenom, string nom, string tel) {
            id++;
            numClient = id;
            this.prenom = prenom;
            this.nom = nom;
            this.tel = tel;
        }

        public int getIdClient() {
            return numClient;
        }
        public string getPrenom()
        {
            return prenom;
        }
        public void setPrenom(String prenom)
        {
            this.prenom = prenom;
        }
        public string getNom()
        {
            return nom;
        }

        public void setNom(String nom)
        {
            this.nom = nom;
        }

        public string getTel()
        {
            return tel;
        }

        public void setTel(String tel)
        {
            this.tel = tel;
        }

        public override string ToString()
        {
            return getIdClient() + "\t" + getPrenom() + "\t" + getNom() + "\t" + getTel() + "\n";
        }

        public void createCompte()
        {

        }

    }
}
