using Opc.Ua.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quickstarts.ReferenceClient
{
    public class Tank
    {
        private MonitoredItem[] properties;

        public Tank()
        {
            this.properties = new MonitoredItem[4];
        }
    }
}
