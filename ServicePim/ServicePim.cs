using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MyAirport.Pim.Entities;

namespace MyAirport.Pim.Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class ServicePim : IServicePim
    {
        int NbAppelTotale = 0;
        int NbAppelInstance = 0;

        public int CreateBagage(BagageDefinition bag)
        {
            NbAppelTotale++;
            this.NbAppelInstance++;
            int res = MyAirport.Pim.Models.Factory.Model.CreateBagage(bag);
            return res;
        }

        public BagageDefinition GetBagageByCodeIata(string codeIata)
        {
            NbAppelTotale++;
            this.NbAppelInstance++;
            List<BagageDefinition> list = MyAirport.Pim.Models.Factory.Model.GetBagage(codeIata);

            if (res != null)
            {
                if (res.Count == 1)
                {
                    return res[0];
                }
                else
                {
                    throw new FaultException(new FaultReason(res.Count + " bagages ont déjà ce code Iata"), new FaultCode("MultipleBagage"));
                }
            }
            else
            {
                return null;
            }
        }

        public BagageDefinition GetBagageById(int idBagage)
        {
            NbAppelTotale++;
            this.NbAppelInstance++;
            return MyAirport.Pim.Models.Factory.Model.GetBagage(idBagage);
        }
    }
}
