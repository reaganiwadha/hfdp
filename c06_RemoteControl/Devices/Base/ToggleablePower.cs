using System;

namespace c06_RemoteControl.Devices.Base
{
    public abstract class ToggleablePower
    {
        protected bool _powerState;

        public void On()
        {
            _powerState = true;
            Console.WriteLine($"{GetType().Name} is turned on");
        }

        public void Off()
        {
            _powerState = false;
            Console.WriteLine($"{GetType().Name} is turned off");
        }
    }
}