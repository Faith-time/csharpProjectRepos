using System;
using System.Collections.Generic;

namespace BANQUE_GESTION.entity
{
    internal class IAgenceImp : IAgence
    {
        public List<AGENCE> agences = new List<AGENCE>();


        public void createAgence(AGENCE agence)
        {
            agences.Add(agence);
        }
        public void updateAgence(int ID)
        {
            foreach (AGENCE agence in agences)
            {
                if (agence.getId() == ID)
                {
                        Console.WriteLine("Saisissez le nouveau code de l'agence");
                        String codeup = Console.ReadLine();
                        agence.setCode(codeup);
                }
            }
        }
        public void deleteAgence(int ID)
        {
            for (int i=0; i<agences.Count; i++)
            {
                if (agences[i].getId() == ID)
                {
                    agences.Remove(agences[i]);
                }
            }
        }

        public void readAgence()
        {
            foreach (AGENCE ag in agences)
            {
                Console.WriteLine(ag.ToString());
            }
        }
    }
}
