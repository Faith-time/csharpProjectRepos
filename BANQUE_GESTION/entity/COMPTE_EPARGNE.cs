using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BANQUE_GESTION.entity
{
    internal class COMPTE_EPARGNE : COMPTE
    {
        private const string V = "15/12/2024";
        public DateTime date_debut = DateTime.Parse(V);
        public int duree;

        public COMPTE_EPARGNE()
        {
            idCompte++;
            numCompte = idCompte;
        }
        public COMPTE_EPARGNE(String nom,String prenom,String tel,double solde,DateTime date_debut) : base (nom,prenom,tel,solde)
        {
            idCompte++;
            numCompte = idCompte;
            this.date_debut = date_debut;
        }

        public DateTime getDateDebut()
        {
            return date_debut;
        }

        public int getduree()
        {
            DateTime actual_date = DateTime.Now;

            int actual_day = actual_date.Day;
            int day_debut = date_debut.Day;    
                duree = actual_day - day_debut;

                return duree;
        }

        public override String ToString()
        {
            return base.ToString() + "\t" + getduree() + "\n";
        }

    }
}
