using System;
using System.Collections.Generic;
using Ninject;
using Ninject.Modules;

namespace DoFactory.GangOfFour.Builder.RealWorld
{
    public class MainApp
    {
        //[Inject]
        //static Shop shop { get; set; }

        //[Inject]
        //static IVehicleBuilder builder {  get; set; }

        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public static void Main()
        {
            int NumberOfKnownModules = 1;
            List<NinjectModule> moduleList = new List<NinjectModule>(NumberOfKnownModules);
            moduleList.Add(new BuilderModule());
            using (IKernel kernel = new StandardKernel(moduleList.ToArray()))
            {
                //Shop shop = kernel.Get<Shop>();
                //kernel.Inject(shop);
                Shop shop = new Shop();
                kernel.Bind<Shop>().ToSelf();
                shop.BuildIt();
            }


            // Create shop with vehicle builders
            //Shop shop = new Shop();

            // Construct and display vehicles
            //VehicleBuilder builder = new ScooterBuilder();
            //shop.Construct();
            //builder.Vehicle.Show();

            //builder = new CarBuilder();
            //shop.Construct(builder);
            //builder.Vehicle.Show();

            //builder = new MotorCycleBuilder();
            //shop.Construct(builder);
            //builder.Vehicle.Show();

            // Wait for user
            Console.ReadKey();
        }

        public class BuilderModule : NinjectModule
        {
            public override void Load()
            {
                Bind<IVehicleBuilder>().To<ScooterBuilder>();
            }
        }
    }
}