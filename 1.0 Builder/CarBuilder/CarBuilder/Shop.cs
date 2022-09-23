using Ninject;

namespace DoFactory.GangOfFour.Builder.RealWorld
{
    class Shop
    {
        [Inject]
        internal IVehicleBuilder vehicleBuilder { get; set; }

        public void BuildIt()
        {
            vehicleBuilder.BuildFrame()
                .BuildEngine()
                .BuildWheels()
                .BuildDoors();
        }
    }
}