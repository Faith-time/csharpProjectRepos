using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANQUE_GESTION.entity
{
    internal interface IAgence
    {
        void createAgence(AGENCE agence);
        void updateAgence(int ID);
        void deleteAgence(int ID);
        void readAgence();
    }
}
