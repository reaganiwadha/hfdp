using c06_RemoteControl.Commands;
using c06_RemoteControl.Devices;

namespace c06_RemoteControl
{
    class Program
    {
        static void Main(string[] args)
        {
            var remote = new SimpleRemoteControl();
            
            var light = new Light();
            var garageDoor = new GarageDoor();
            
            var lightOnCommand = new LightOnCommand(light);
            var garageOpen = new GarageDoorOpenCommand(garageDoor);
            
            remote.SetCommand(lightOnCommand);
            remote.ButtonWasPressed();
            remote.SetCommand(garageOpen);
            remote.ButtonWasPressed();
        }
    }
}
