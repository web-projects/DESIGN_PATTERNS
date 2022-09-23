using Ninject;

namespace DoFactory.GangOfFour.Builder.RealWorld
{
    class MotorCycleBuilder : VehicleBuilder
    {
        [Inject]
        public MotorCycleBuilder()
        {
            vehicle = new Vehicle("MotorCycle");
        }

        public override VehicleBuilder BuildFrame()
        {
            vehicle["frame"] = "MotorCycle Frame";
            return this;
        }

        public override VehicleBuilder BuildEngine()
        {
            vehicle["engine"] = "500 cc";
            return this;
        }

        public override VehicleBuilder BuildWheels()
        {
            vehicle["wheels"] = "2";
            return this;
        }

        public override VehicleBuilder BuildDoors()
        {
            vehicle["doors"] = "0";
            return this;
        }
    }
}