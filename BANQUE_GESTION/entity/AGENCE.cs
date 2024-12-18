using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANQUE_GESTION.entity {

    internal class AGENCE
    {
        public static int id = 0;
        public int numA;
        public string code;
        public string libelle;
        public List<CLIENT> clients = new List<CLIENT>();
        public List<COMPTE> comptes = new List<COMPTE>();

        public AGENCE()
        {
            numA = id;
            id++;
        }
        public AGENCE(String code)
        {
            numA = id;
            id++;
            this.code = code;
        }

        public int getId()
        {
            return numA;
        }

        public string getCode()
        {
            return code;
        }

        public void setCode(String code)
        {
            this.code = code;
        }
        public string getLibelle()
        {
            libelle = getId() + getCode();
            return libelle;
        }


        public void createClient(CLIENT client)
        {
             clients.Add(client);
        }

        public void updateClient(int ID)
        {
            int choix;

            foreach (CLIENT client in clients)
            {
                if (client.getIdClient() == ID)
                {
                    Console.WriteLine("Que souhaiteriez-vous modifier?");
                    do
                    {
                        Console.WriteLine("1-MON NOM");
                        Console.WriteLine("2-MON PRENOM");
                        Console.WriteLine("3-MON NUMERO DE TELEPHONE");
                        Console.WriteLine("4-QUITTER");
                        choix = int.Parse(Console.ReadLine());

                        switch (choix)
                        {
                            case 1:
                                Console.WriteLine("Saisissez le nouveau nom");
                                String nomup = Console.ReadLine();
                                client.setNom(nomup);
                                break;

                            case 2:
                                Console.WriteLine("Saisissez le nouveau prenom");
                                String prenomup = Console.ReadLine();
                                client.setPrenom(prenomup);
                                break;

                            case 3:
                                Console.WriteLine("Saisissez le nouveau numéro de téléphone");
                                String telup = Console.ReadLine();
                                client.setTel(telup);
                                break;

                            case 4:
                                Console.WriteLine("MODIFICATION TERMINÉE");
                                break;

                            default:
                                Console.WriteLine("Choix indisponible");
                                break;
                        }
                    } while (choix != 4);
                }
            }
        }
        public void deleteClient(int ID)
        {
            for (int i = 0; i < clients.Count; i++)
            {
                if (clients[i].getIdClient() == ID)
                {
                    clients.Remove(clients[i]);
                }
            }
        }

        public void readClient()
        {
            foreach (CLIENT cli in clients)
            {
                Console.WriteLine(cli.ToString());
            }
        }

        public void createCompte(COMPTE compte)
        {
            Console.WriteLine("Entrez l'id du client");
            int idc = int.Parse(Console.ReadLine());

            foreach (CLIENT cli in clients)
            {
                if (cli.getIdClient() == idc)
                {
                    compte.tel = cli.tel;
                    idc = compte.getIdClient();
                    comptes.Add(compte);
                }
            }
        }
        
        public void updateCompte(int id)
        {
            int choice;
            double montr;
            double montd;
            int idCli;

            Console.WriteLine("Saisissez l'id du client");
            idCli = int.Parse(Console.ReadLine());  

            foreach (CLIENT c in clients)
            {
                if (c.getIdClient() == idCli)
                {
                    foreach (COMPTE cpt in comptes)
                    {
                        if (cpt.getId() == id)
                        {
                            do
                            {
                                Console.WriteLine("Voulez-vous effectuer un retrait ou un dépôt?");
                                Console.WriteLine("1-RETRAIT");
                                Console.WriteLine("2-DÉPÔT");
                                Console.WriteLine("3-QUITTER");
                                choice = int.Parse(Console.ReadLine());

                                switch (choice)
                                {
                                    case 1:

                                        Console.WriteLine("Veuillez entrer le montrait de retrait");
                                        montr = double.Parse(Console.ReadLine());

                                        if (montr < cpt.getSolde())
                                        {
                                            cpt.setSolde(cpt.getSolde() - montr);
                                        }

                                        break;

                                    case 2:

                                        Console.WriteLine("Veuillez entrer le montrait de dépôt");
                                        montd = double.Parse(Console.ReadLine());
                                        cpt.setSolde(cpt.getSolde() + montd);

                                        break;

                                    case 3:
                                        Console.WriteLine("MODIFICATION EFFECTUÉE");
                                        break;
                                    default:
                                        Console.WriteLine("Choix indisponible");
                                        break;
                                }
                            } while (choice != 3);

                        }
                    }
                }
            }
            }

        public void deleteCompte(int id)
        {
            for(int i = 0; i < comptes.Count; i++)
            {
                comptes.Remove(comptes[i]); 
            }
        }

        public void readCompte()
        {
            foreach (COMPTE compte in comptes)
            {
                Console.WriteLine(compte);
            }
        }

        public override string ToString()
        {
            return getId() + "\t" + getCode() + "\t" + getLibelle() + "\n";
        }
    }
}
