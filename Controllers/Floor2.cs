using LiftSystem.DTO;
using LiftSystem.interfaces;
using LiftSystem.Model;

namespace LiftSystem.controllers
{
    public class Floor2 : IFloor
    {
        public override void LogRequest()
        {
            new LiftModel().Log("Request received for floor 2");
        }

        public override void LogArrival()
        {
            new LiftModel().Log("Lift Arrived at floor 2");
        }
        
        public override int GetFloorNumber() => 2;
    }
}