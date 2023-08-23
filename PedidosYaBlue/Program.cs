using PedidosYaBlue.Factories;
using PedidosYaBlue.Interfaces;
using PedidosYaBlue.Services;
using System;

namespace PedidosYaBlue
{
    class Program
    {
        //Patrones utilizados: Singleton, Factory Methods, Prototype
        //https://refactoring.guru/es/design-patterns/singleton/csharp/example
        //https://refactoring.guru/es/design-patterns/factory-method/csharp/example
        //https://refactoring.guru/es/design-patterns/prototype/csharp/example

        static void Main(string[] args)
        {
            //Crear instancia y verificar
            RepartidorSingleton repartidoresRepository = RepartidorSingleton.GetInstance();
            RepartidorSingleton repartidoresRepository2 = RepartidorSingleton.GetInstance();
            Console.WriteLine(repartidoresRepository == repartidoresRepository2 ? "Singleton funciona, las instancias son las mismas" : "Singleton no funciona, las instancias son distinas");

            //Instanciar droneFactory y repartidorFactory
            RepartidorCreator droneFactory = new DronFactory();
            RepartidorCreator repartidorFactory = new RepartidorFactory();

            //Crear repartidores
            IRepartidor drone = droneFactory.NuevoObjetoRepartidor();
            IRepartidor repartidor = repartidorFactory.NuevoObjetoRepartidor();




            //Agregar la descripcion y el id a ambos
            drone.Id = 0;
            drone.Descripcion = "Este es un dron repartidor";

            repartidor.Id = 1;
            repartidor.Descripcion = "Este es un repartidor humano";


            //ABMC

            //Agregar repartidores a la lista singleton
            repartidoresRepository.AgregarRepartidor(drone);
            repartidoresRepository.AgregarRepartidor(repartidor);
            ImprimirRepartidores();



            //Borrar un repartidor
            repartidoresRepository.EliminarRepartidor(repartidor);
            ImprimirRepartidores();



            //Modificar repartidor
            drone.Descripcion = "Este es un dron repartidor modificado";
            repartidoresRepository.ModificarRepartidor(drone);
            ImprimirRepartidores();


            //Prototype

            IRepartidor repartidorClonado = repartidor.Clonar();
            Console.WriteLine($"Repartidor ({repartidor.Id}) a clonar: Descripcion:{repartidor.Descripcion}");
            Console.WriteLine($"Repartidor ({repartidorClonado.Id}) clonado: Descripcion:{repartidorClonado.Descripcion}");

        }

        private static void ImprimirRepartidores()
        {
            //La instancia es la misma
            RepartidorSingleton repartidoresRepository = RepartidorSingleton.GetInstance();
            foreach (var rep in repartidoresRepository.ObtenerRepartidores())
            {
                Console.WriteLine($"{rep.Id} - {rep.Descripcion}");
            }
            Console.WriteLine("---------------------------------------");
        }


    }
}

