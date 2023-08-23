using PedidosYaBlue.Interfaces;
using PedidosYaBlue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosYaBlue.Factories
{
    public class RepartidorFactory : RepartidorCreator
    {
        public override IRepartidor NuevoObjetoRepartidor()
        {
            return new Repartidor();
        }
    }
}
