using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANQUE_GESTION.entity
{
    internal abstract class COMPTE : CLIENT
    {
        public static int idCompte = 0;
        public int numCompte;
        public String numerocompte;
        public double solde;

        public COMPTE()
        {
           
        }
        public COMPTE(String nom,String prenom,String tel, double solde) : base(nom, prenom, tel)
        {
            
            this.solde = solde;
        }   
        public int getId() {
            return numCompte; 
        }


        public double getSolde()
        {
            return solde;
        }

        public void setSolde(double solde)
        {
            this.solde = solde;
        }

        public String genererNumeroCompte() {
            String numcompte = "000" + getIdClient() + getTel();
            Console.WriteLine(numCompte);  
            return numcompte;   
        }

       
        public override string ToString()
        {
            return getId() + "\t" + genererNumeroCompte() + "\t" + getSolde() + "\t";
        }

    }
}
