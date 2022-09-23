namespace DoFactory.GangOfFour.Builder.RealWorld
{
    interface IVehicleBuilder
    {
        Vehicle Vehicle { get; }

        VehicleBuilder BuildDoors();
        VehicleBuilder BuildEngine();
        VehicleBuilder BuildFrame();
        VehicleBuilder BuildWheels();
    }
}