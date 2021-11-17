using System;
using c06_RemoteControl.Commands;
using c06_RemoteControl.Devices;

namespace c06_RemoteControl
{
    class Program
    {
        static void Main(string[] args)
        {
            var remote = new RemoteControl();

            var light = new Light();
            var garageDoor = new GarageDoor();

            var lightOnCommand = new LightOnCommand(light);
            var lightOffCommand = new LightOffCommand(light);
            var garageOpen = new GarageDoorOpenCommand(garageDoor);
            var garageClose = new GarageDoorOpenCommand(garageDoor);

            remote.SetCommand(1, lightOffCommand, lightOnCommand);
            remote.SetCommand(2, garageClose, garageOpen);
            
            Console.WriteLine(remote.ToString());
            
            remote.OffButtonWasPushed(1);
        }
    }
}