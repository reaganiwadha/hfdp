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
            var lightOnCommand = new LightOnCommand(light);
            
            remote.SetCommand(lightOnCommand);
            light.On();
        }
    }
}
