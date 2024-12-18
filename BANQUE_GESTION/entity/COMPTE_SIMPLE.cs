using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANQUE_GESTION.entity
{
    internal class COMPTE_SIMPLE : COMPTE
    {
        public int  tauxCouvert;

        public COMPTE_SIMPLE()
        {
            idCompte++;
            numCompte = idCompte;
        }
        public COMPTE_SIMPLE(String nom, String prenom, String tel, double solde,int tauxCouvert) : base(nom, prenom, tel, solde){
            idCompte++;
            numCompte = idCompte;
            this.tauxCouvert = tauxCouvert;
        }

        public int getTauxCouvert() { 
            return tauxCouvert;
        }

        public override String ToString()
        {
            return base.ToString() + "\t" + getTauxCouvert() + "\n";   
        }


    }
}
