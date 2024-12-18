using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BANQUE_GESTION.entity;

namespace BANQUE_GESTION.entity
{
    internal class Gestion_banque
    {
        static void Main(string[] args)
        {
            IAgenceImp ia = new IAgenceImp();

            AGENCE agence2 = new AGENCE();

            int choice;
            int choix1;
            int choix2;
            int choix3;
            int option;

            do
            {
                Console.WriteLine("1-CRUD AGENCE");
                Console.WriteLine("2-CRUD CLIENT");
                Console.WriteLine("3-CRUD COMPTE");
                Console.WriteLine("4-QUITTER");
                choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                            case 1:
                                do
                                {
                                    Console.WriteLine("Quelle action souhaitez-vous effectuer?");
                                    Console.WriteLine("1-AJOUTER AGENCE");
                                    Console.WriteLine("2-MODIFIER AGENCE");
                                    Console.WriteLine("3-SUPPRIMER AGENCE");
                                    Console.WriteLine("4-AFFICHER LA LISTE DES AGENCES");
                                    Console.WriteLine("5-QUITTER");
                                    choix1 = int.Parse(Console.ReadLine());
                             
                                    switch (choix1)
                                    {
                                        case 1:
                                            AGENCE agence1 = new AGENCE();
                                            Console.WriteLine("Définissez le code de l'agence");
                                            agence1.code = Console.ReadLine();
                                            ia.createAgence(agence1);
                                            break;

                                        case 2:
                                            Console.WriteLine("Entrez l'id de l'agence");
                                            int ID = int.Parse(Console.ReadLine());
                                            ia.updateAgence(ID);
                                            break;

                                        case 3:
                                            Console.WriteLine("Entrez l'id de l'agence");
                                            int id = int.Parse(Console.ReadLine());
                                            ia.deleteAgence(id);
                                            break;

                                        case 4:
                                            ia.readAgence();
                                            break;

                                        case 5:
                                            Console.WriteLine("Vous venez de quitter!");
                                            break;

                                        default:
                                            Console.WriteLine("Choix indisponible");
                                            break;
                                    }
                                }while (choix1 != 5);
                        
                                break;

                        case 2:
                                do
                                {
                                    Console.WriteLine("Quelle action souhaitez-vous effectuer?");
                                    Console.WriteLine("1-AJOUTER CLIENT");
                                    Console.WriteLine("2-MODIFIER CLIENT");
                                    Console.WriteLine("3-SUPPRIMER CLIENT");
                                    Console.WriteLine("4-AFFICHER LA LISTE DES CLIENTS");
                                    Console.WriteLine("5-QUITTER");
                                    choix2 = int.Parse(Console.ReadLine());

                                    switch (choix2)
                                    {
                                        case 1:

                                            CLIENT client1 = new CLIENT();
                                            Console.WriteLine("Veuillez entrer votre prenom");
                                            client1.prenom = Console.ReadLine();

                                            Console.WriteLine("Veuillez entrer votre nom");
                                            client1.nom = Console.ReadLine();   

                                            Console.WriteLine("Veuillez entrer votre numero de téléphone");
                                            client1.tel = Console.ReadLine();
                                        
                                            agence2.createClient(client1);

                                            
                                            break;

                                        case 2:
                                            Console.WriteLine("Entrez l'id du client");
                                            int ID = int.Parse(Console.ReadLine());
                                            agence2.updateClient(ID);
                                            break;

                                        case 3:
                                            Console.WriteLine("Entrez l'id du client");
                                            int id = int.Parse(Console.ReadLine());
                                            agence2.deleteClient(id);
                                            break;

                                        case 4:
                                            agence2.readClient();       
                                            break;

                                        case 5:
                                            Console.WriteLine("Vous venez de quitter!");
                                            break;

                                        default:
                                            Console.WriteLine("Choix indisponible");
                                            break;
                                    }
                                }while (choix2 != 5);

                                 break;

                        case 3:
                                do
                                {
                                    Console.WriteLine("Quelle action souhaitez-vous effectuer?");
                                    Console.WriteLine("1-AJOUTER COMPTE");
                                    Console.WriteLine("2-MODIFIER COMPTE");
                                    Console.WriteLine("3-SUPPRIMER COMPTE");
                                    Console.WriteLine("4-AFFICHER LA LISTE DES COMPTES");
                                    Console.WriteLine("5-QUITTER");
                                    choix3 = int.Parse(Console.ReadLine());

                            switch (choix3)
                            {
                                case 1:

                                    do
                                    {
                                        Console.WriteLine("Quel type de compte souhaitez-vous ajouter?");
                                        Console.WriteLine("1-COMPTE SIMPLE");
                                        Console.WriteLine("2-COMPTE ÉPARGNE");
                                        Console.WriteLine("3-QUITTER");
                                        option = int.Parse(Console.ReadLine());

                                        switch (option)
                                        {
                                            case 1:                                               
                                                
                                                COMPTE_SIMPLE compte1 = new COMPTE_SIMPLE();

                                                Console.WriteLine("Entrez le montant de départ");
                                                compte1.solde = double.Parse(Console.ReadLine());

                                                Console.WriteLine("Entrez le taux de couvert");
                                                compte1.tauxCouvert = int.Parse(Console.ReadLine());

                                                agence2.createCompte(compte1);

                                                break;

                                            case 2:
                                                COMPTE_EPARGNE compte2 = new COMPTE_EPARGNE();

                                                Console.WriteLine("Entrez le montant de départ");
                                                compte2.solde = double.Parse(Console.ReadLine());

                                                agence2.createCompte(compte2);

                                                break;

                                            case 3:
                                                Console.WriteLine("Vous venez de quitter le menu compte");
                                                break;

                                            default:
                                                Console.WriteLine("Choix indisponible");
                                                break;
                                        }
                                    } while (option != 3);
                                    
                                break;

                                        case 2:
                                            Console.WriteLine("Entrez l'id du compte");
                                            int ID = int.Parse(Console.ReadLine());
                                            agence2.updateCompte(ID);
                                            break;

                                        case 3:
                                            Console.WriteLine("Entrez l'id du comptant");
                                            int id = int.Parse(Console.ReadLine());
                                            agence2.deleteCompte(id);
                                            break;

                                        case 4:
                                            agence2.readCompte();
                                            break;

                                        case 5:
                                            Console.WriteLine("Vous venez de quitter!");
                                            break;

                                        default:
                                            Console.WriteLine("Choix indisponible");
                                            break;
                                    }
                                }while (choix3 != 5);
                                break;

                        case 4:
                                Console.WriteLine("Vous venez de quitter le menu");
                                break;

                        default:
                                Console.WriteLine("Choix non disponible");
                                break;
                    }
            } while(choice != 4);
        }
    }
}
