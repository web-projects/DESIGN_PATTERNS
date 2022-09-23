namespace DoFactory.GangOfFour.Builder.RealWorld
{
    abstract class VehicleBuilder : IVehicleBuilder
    {
        protected Vehicle vehicle;

        public Vehicle Vehicle
        {
            get { return vehicle; }
        }

        // Abstract build methods
        public abstract VehicleBuilder BuildFrame();
        public abstract VehicleBuilder BuildEngine();
        public abstract VehicleBuilder BuildWheels();
        public abstract VehicleBuilder BuildDoors();
    }
}