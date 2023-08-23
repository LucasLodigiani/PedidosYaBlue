using PedidosYaBlue.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosYaBlue.Factories
{
    public abstract class RepartidorCreator
    {
        public abstract IRepartidor NuevoObjetoRepartidor();
    }
}
