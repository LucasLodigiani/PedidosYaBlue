using PedidosYaBlue.Interfaces;
using PedidosYaBlue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosYaBlue.Services
{
    public sealed class RepartidorSingleton
    {
        private RepartidorSingleton()
        {
            repartidores = new List<IRepartidor>();
        }

        private List<IRepartidor> repartidores;


        private static RepartidorSingleton _instance;

        public static RepartidorSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new RepartidorSingleton();
            }
            return _instance;
        }

        //ABMC
        public List<IRepartidor> ObtenerRepartidores()
        {
            return repartidores;
        }
        public void AgregarRepartidor(IRepartidor repartidor)
        {
            repartidores.Add(repartidor);
        }
        
        public void EliminarRepartidor(IRepartidor repartidor)
        {
            repartidores.Remove(repartidor);
        }

        public void ModificarRepartidor(IRepartidor repartidorModificado)
        {
            //Buscar el repartidor
            var repartidorAModificar = repartidores.First(r => r.Id == repartidorModificado.Id);
            //Eliminarlo
            repartidores.Remove(repartidorAModificar);

            //Agregarlo
            repartidores.Add(repartidorModificado);



        }

        


    }
}
