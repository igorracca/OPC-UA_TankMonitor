using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quickstarts.ReferenceClient
{
    public static class TankDataTypes
    {
        public const string tanks = "Simulation";
        public static readonly string[] props = {
            "Grupo",
            "Nome",
            "MatériaPrima",
            "Capacidade",
            "VolumeMorto",
            "Status",
            "Nível",
            "Nível%",
            "Temperatura"
        };
         
        public static bool containsProp(string prop)
        {
            for (int i = 0; i < props.Length; i++)
            {
                if(props[i].Equals(prop))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
